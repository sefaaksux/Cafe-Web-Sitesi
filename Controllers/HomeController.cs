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
    
    public IActionResult Menu()
    { 
        var Yemekler = _context.urunler.Where(x => x.kategoriId == 1).ToList();
        return View(Yemekler);
    }
    public IActionResult Deneme()
    {       
        return View();
    }
    public IActionResult Kampanyalar()
    {
        var Kampanyalar = _context.urunler.Where(x => x.kategoriId == 5).ToList();
        return View(Kampanyalar);
    }

    public IActionResult Yemekler()
    {
        var Yemekler = _context.urunler.Where(x => x.kategoriId == 1).ToList();
        return View(Yemekler);
    }

    public IActionResult Icecekler()
    {
        var Icecekler = _context.urunler.Where(x => x.kategoriId == 3).ToList();
        return View(Icecekler);
    }

    public IActionResult Alkoller()
    {
        var Alkoller = _context.urunler.Where(x => x.kategoriId == 2).ToList();
        return View(Alkoller);
    }

    public IActionResult Extra()
    {
         var Extra = _context.urunler.Where(x => x.kategoriId == 4).ToList();
        return View(Extra);
    }
    

}
