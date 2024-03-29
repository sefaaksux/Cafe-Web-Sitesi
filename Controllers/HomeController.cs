using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using admin_panel.Models;
using admin_panel.Data;
using admin_panel.Entity;

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
        return View();
    }
    public IActionResult login()
    {
        return View();
    }

    public IActionResult Update(int id, string category)
    {
        return View();
    }

    public IActionResult Menu(string category)
    {
            // object menuItems = null;
            object deger = null;
 
            // İstenen kategoriye göre verileri al
            switch (category)
            {
                case "aperatifler":
                    deger = _context.aperatifler.Cast<object>().ToList();
                    ViewBag.Category = "aperatifler";
                    break;
                case "tavuk":
                    deger = _context.tavuklar.Cast<object>().ToList();
                    ViewBag.Category = "tavuklar";
                    break;
                // Diğer kategoriler için gerekli case'leri ekle
                default:
                    return NotFound(); // Geçersiz kategori isteği durumunda 404 döndür
            }

            return View(deger); // View'e verileri gönder
    }  

}
