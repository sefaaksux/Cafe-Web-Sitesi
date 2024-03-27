using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using admin_panel.Models;
using admin_panel.Data;

namespace admin_panel.Controllers;

public class HomeController : Controller
{
    private readonly MyContext _context;
    public HomeController(MyContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult login()
    {
        return View();
    }

    public IActionResult aperatifler()
    {
        return View();
    }

    [HttpPost]
    // public IActionResult GetData(string dataType)
    // {   
    //     if(dataType == "aperatifler")
    //     {
    //        var data = _context.aperatifler.ToList();
    //        return PartialView("_CardPartial", data);
    //     }

    //     if(dataType == "krepler")
    //     {
    //        var data = _context.krepler.ToList();
    //        return PartialView("_CardPartial", data);
    //     }

    // }

    public IActionResult cardMenu()
    {
        return View();
    }

}
