using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using admin_panel.Models;
using admin_panel.Data;
using admin_panel.Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace admin_panel.Controllers;

public class UpdateController : Controller
{
    private readonly MyContext _context;

    public UpdateController(MyContext context)
    {
        _context = context;
    }


    [HttpGet]
    public async Task<IActionResult> Index(int id)
    {   
        var product =await _context.urunler
                    .Include(x => x.Tablo)
                    .Include(x => x.Kategori)
                    .FirstOrDefaultAsync(x => x.Id == id);

        ViewBag.Tablolar = new SelectList(_context.tablolar.ToList(),"tabloId","tabloName");
        ViewBag.Kategoriler = new SelectList(_context.kategoriler.ToList(),"kategoriId","kategoriName"); 
        if (product == null)
        {
            return NotFound(); // Ürün bulunamazsa hata sayfasına yönlendirme yapabilirsiniz
        }

        
       return View(product);
    }

    [HttpPost]
    public async Task<IActionResult> Index(Urun model, int id)
    {
            if(id != model.Id)
            {
               return NotFound();
            }

                try
                {
                    
                    _context.Update(model);
                    await _context.SaveChangesAsync();
                    
                }
                catch (System.Exception)
                {              
                    throw;
                }
            
            
            return RedirectToAction("AdminIndex");
    }

}
