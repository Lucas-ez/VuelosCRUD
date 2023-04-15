using Microsoft.AspNetCore.Mvc;
using VuelosCRUD.Models;

namespace VuelosCRUD.Controllers
{
  public class VuelosController : Controller
  {
    public IActionResult Index()
    {
      return View();
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
