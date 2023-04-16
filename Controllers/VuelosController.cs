using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;
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
      return View("Form");
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

    [ValidateAntiForgeryToken]
    [HttpPost]
    public IActionResult Save(Vuelo vuelo)
    {

      //Validations
      // ERROR toma 1 campo extra que no existe en la view
      var errors = ModelState.Values.SelectMany(v => v.Errors).ToList();
      if (!ModelState.IsValid && errors.Count() > 1)
      {
        Console.WriteLine(vuelo.ToJson());
        Console.WriteLine(errors[0].ToJToken());
        Console.WriteLine(errors.Count());
        return View("Form", vuelo);
      }


      if (vuelo.Id == 0)
      {
        _context.Vuelos.Add(vuelo);
      }
      else
      {
        var vueloInDb = _context.Vuelos.Single(v => v.Id == vuelo.Id);

        vueloInDb.NumeroVuelo = vuelo.NumeroVuelo;
        vueloInDb.LineaAerea = vuelo.LineaAerea;
        vueloInDb.HorarioLLegada = vuelo.HorarioLLegada;
        vueloInDb.Demorado = vuelo.Demorado;
      }

      _context.SaveChanges();

      return RedirectPermanent("/Vuelos");
    }
  }
}
