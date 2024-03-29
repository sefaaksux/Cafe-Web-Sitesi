using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using admin_panel.Models;
using admin_panel.Data;
using admin_panel.Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq;

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

    [HttpGet]
    public async Task<IActionResult> Update(int id)
    {   
        var product =await _context.urunler.FindAsync(id);

        if (product == null)
        {
            return NotFound(); // Ürün bulunamazsa hata sayfasına yönlendirme yapabilirsiniz
        }

        return View(product);
    }

    public async Task<IActionResult> Menu(string category)
    {
        

        var filteredProduct = await _context.urunler
                            .Include(x => x.Tablo)
                            .Where(x => x.Tablo.tabloName == category)
                            .ToListAsync();

        return View(filteredProduct);
    }  

}
