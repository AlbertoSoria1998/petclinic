using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using petclinic.Data;
using petclinic.Models;

using System.Globalization;
namespace petclinic.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly UserManager<IdentityUser> _userManager;
    private readonly ApplicationDbContext _context;

    public HomeController(ILogger<HomeController> logger, UserManager<IdentityUser> userManager, ApplicationDbContext context)
    {
        _logger = logger;

        _userManager = userManager;
        _context = context;
    }

    public IActionResult Index()
    {
        var totalClientes = _context.Users.Count();
        var totalProductos = _context.DataProductos.Count();
        var totalPedidos = _context.DataPedido.Count();

        ViewBag.TotalClientes = totalClientes;
        ViewBag.TotalProductos = totalProductos;
        ViewBag.TotalPedidos = totalPedidos;
        return View();
    }

    public IActionResult Privacy() { return View(); }

    [HttpGet]
    public JsonResult TotalClientesRegistrados()
    {
        var totalClientes = _context.Users.Count();
        return Json(new { totalClientes });
    }

    [HttpGet]
    public JsonResult ProductosMasVendidos()
    {
        var productos = _context.DataProductos
            .Select(p => new
            {
                nombre = p.Name,
                totalVentas = _context.DataDetallePedido.Count(dp => dp.Producto.Id == p.Id)
            })
            .OrderByDescending(p => p.totalVentas)
            .Take(5)
            .ToList();

        return Json(productos);
    }

    [HttpGet]
    public JsonResult VentasMensuales()
    {
        _logger.LogInformation("Iniciando el método VentasMensuales.");
        var ventasMensuales = new List<dynamic>();

        try
        {
            var ventas = _context.DataPago
                .GroupBy(p => new
                {
                    Year = p.PaymentDate.Year,
                    Month = p.PaymentDate.Month
                })
                .Select(g => new
                {
                    Year = g.Key.Year,
                    Month = g.Key.Month,
                    TotalVentas = g.Sum(p => p.MontoTotal)
                })
                .OrderBy(g => g.Year).ThenBy(g => g.Month)
                .ToList();

            foreach (var venta in ventas)
            {
                var mes = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(venta.Month);
                ventasMensuales.Add(new
                {
                    Mes = $"{mes} {venta.Year}",
                    venta.TotalVentas
                });
                _logger.LogInformation($"Agregado registro: Mes = {mes} {venta.Year}, TotalVentas = {venta.TotalVentas}");
            }

            _logger.LogInformation($"Se encontraron {ventasMensuales.Count} registros de ventas mensuales.");
        }
        catch (Exception ex)
        {
            _logger.LogError($"Error al obtener ventas mensuales: {ex.Message}");
            _logger.LogError(ex.StackTrace);
            return Json(new { error = "Ocurrió un error al obtener las ventas mensuales." });
        }

        return Json(ventasMensuales);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
