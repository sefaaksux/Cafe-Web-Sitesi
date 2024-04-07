using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using admin_panel.Models;
using admin_panel.Data;
using admin_panel.Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.IO.Compression;

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
    public IActionResult Kampanyalar()
    {
        return View();
    }

    public IActionResult Yemekler()
    {
        var Yemekler = _context.urunler.Where(x => x.kategoriId == 1).ToList();
        return View(Yemekler);
    }

    public IActionResult Icecekler()
    {
        return View();
    }

    public IActionResult Alkoller()
    {
        return View();
    }

    public IActionResult Extra()
    {
        return View();
    }
    

}
