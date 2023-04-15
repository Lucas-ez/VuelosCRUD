using Microsoft.AspNetCore.Mvc;
using VuelosCRUD.Models;
using VuelosCRUD.ViewModels;

namespace VuelosCRUD.Controllers
{
  public class VuelosController : Controller
  {
    private VuelosDbContext _context;

    public VuelosController(VuelosDbContext context)
    {
      _context = context;
    }
    protected override void Dispose(bool disposing)
    {
      _context.Dispose();
    }

    public IActionResult Index()
    {
      var vuelos = _context.Vuelos.ToList();

      var viewModel = new VuelosViewModel { Vuelos = vuelos };

      return View(viewModel);
    }

    public IActionResult Create()
    {
      var vuelo = new Vuelo();

      return View("Form", vuelo);
    }
    public IActionResult Update()
    {
      var vuelo = new Vuelo();

      return View("Form", vuelo);
    }
    public IActionResult Delete()
    {
      return View();
    }
  }
}
