using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using admin_panel.Models;
using admin_panel.Data;
using admin_panel.Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace admin_panel.Controllers;

public class CreateController : Controller
{
    private readonly MyContext _context;

    public CreateController(MyContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Index()
    {   ViewBag.Tablolar = new SelectList(_context.tablolar.ToList(),"tabloId","tabloName");
        ViewBag.Kategoriler = new SelectList(_context.kategoriler.ToList(),"kategoriId","kategoriName"); 
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Index(Urun urun)
    {
        _context.urunler.Add(urun);
        await _context.SaveChangesAsync();

        return RedirectToAction("AdminIndex","Admin");

    }

}
