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
    public IActionResult Kampanya()
    {   
        if(HttpContext.Session.GetString("IsUserLoggedIn") == "true")
        {

            
            return View();
        }else{
            return RedirectToAction("Index","Admin");
        }  
    }

    [HttpPost]
public async Task<IActionResult> Kampanya(UrunViewModel urunViewModel)
{
    try
    {
        if(HttpContext.Session.GetString("IsUserLoggedIn") == "true")
        {
            if(ModelState.IsValid)
            {
                    // ViewModel'den asıl veritabanı modeline dönüştürme
                var urun = new Urun
                {
                    Name = urunViewModel.Name,
                    Description = urunViewModel.Description,
                    Amount = urunViewModel.Amount,
                    tabloId = urunViewModel.tabloId,
                    kategoriId = urunViewModel.kategoriId
                };
                _context.urunler.Add(urun);
                await _context.SaveChangesAsync();

                return RedirectToAction("AdminIndex","Admin");
            }
            else
            {
                
                return View();
            }
            
        }
        else
        {
            return RedirectToAction("Index","Admin");
        }
    }
    catch(Exception ex)
    {
        // Hata durumunda yapılacak işlemleri burada ele alabilirsiniz
        // Örneğin, hata mesajını loglamak, kullanıcıya hata mesajını göstermek gibi
        // Örnek olarak hata mesajını konsola yazdıralım:
        Console.WriteLine("Hata Oluştu: " + ex.Message);

        // İstisna durumu ele alındıktan sonra uygun bir şekilde kullanıcıya yönlendirme yapabilirsiniz.
        // Örneğin, bir hata sayfasına yönlendirme yapabilirsiniz.
        return RedirectToAction("Hata", "Home");
    }
}

    [HttpGet]
    public IActionResult Index()
    {   
        if(HttpContext.Session.GetString("IsUserLoggedIn") == "true")
        {

            ViewBag.Kategoriler = new SelectList(_context.kategoriler.ToList(),"kategoriId","kategoriName"); 
            ViewBag.Tablolar = new SelectList(_context.tablolar.ToList(),"tabloId","tabloName");
            return View();
        }else{
            return RedirectToAction("Index","Admin");
        }
        
    }

    [HttpPost]
public async Task<IActionResult> Index(UrunViewModel urunViewModel)
{
    try
    {
        if(HttpContext.Session.GetString("IsUserLoggedIn") == "true")
        {
            if(ModelState.IsValid)
            {
                    // ViewModel'den asıl veritabanı modeline dönüştürme
                var urun = new Urun
                {
                    Name = urunViewModel.Name,
                    Description = urunViewModel.Description,
                    Amount = urunViewModel.Amount,
                    tabloId = urunViewModel.tabloId,
                    kategoriId = urunViewModel.kategoriId
                };
                _context.urunler.Add(urun);
                await _context.SaveChangesAsync();

                return RedirectToAction("AdminIndex","Admin");
            }
            else
            {
                ViewBag.Tablolar = new SelectList(_context.tablolar.ToList(),"tabloId","tabloName");
            ViewBag.Kategoriler = new SelectList(_context.kategoriler.ToList(),"kategoriId","kategoriName"); 
                return View();
            }
            
        }
        else
        {
            return RedirectToAction("Index","Admin");
        }
    }
    catch(Exception ex)
    {
        // Hata durumunda yapılacak işlemleri burada ele alabilirsiniz
        // Örneğin, hata mesajını loglamak, kullanıcıya hata mesajını göstermek gibi
        // Örnek olarak hata mesajını konsola yazdıralım:
        Console.WriteLine("Hata Oluştu: " + ex.Message);

        // İstisna durumu ele alındıktan sonra uygun bir şekilde kullanıcıya yönlendirme yapabilirsiniz.
        // Örneğin, bir hata sayfasına yönlendirme yapabilirsiniz.
        return RedirectToAction("Hata", "Home");
    }
}



}
