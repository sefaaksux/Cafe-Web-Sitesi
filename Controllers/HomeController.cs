using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using admin_panel.Models;
using admin_panel.Data;
using admin_panel.Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace admin_panel.Controllers;

public class HomeController : Controller
{
    private readonly MyContext _context;
    public HomeController(MyContext context)
    {
        _context = context;
    }
    public IActionResult AdminIndex()
    {
        int yemekCount = _context.urunler.Where(x => x.kategoriId == 1).Count();
        int alkolCount = _context.urunler.Where(x => x.kategoriId == 2).Count();
        int icecekCount = _context.urunler.Where(x => x.kategoriId == 3).Count();
        int extraCount = _context.urunler.Where(x => x.kategoriId == 4).Count();

        ViewBag.yemekCount = yemekCount;
        ViewBag.alkolCount = alkolCount;
        ViewBag.icecekCount = icecekCount;
        ViewBag.extraCount = extraCount;

        return View();
    }
    public IActionResult login()
    {
        return View();
    }

    public async Task<IActionResult> Menu(string category)
    {
        ViewBag.category = category;

        var filteredProduct = await _context.urunler
                            .Include(x => x.Tablo)
                            .Where(x => x.Tablo.tabloName == category)
                            .ToListAsync();

        return View(filteredProduct);
    }  

}
