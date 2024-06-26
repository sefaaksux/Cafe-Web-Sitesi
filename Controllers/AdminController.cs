﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using admin_panel.Models;
using admin_panel.Data;
using admin_panel.Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;


namespace admin_panel.Controllers;

public class AdminController : Controller
{
    

    private readonly MyContext _context;
    public AdminController(MyContext context)
    {
        _context = context;
        
     
    }

    
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    
    public async Task<IActionResult> Index(LoginViewModel model)
    {
        if(ModelState.IsValid)
        {
            if(!string.IsNullOrEmpty(model.userName) && !string.IsNullOrEmpty(model.password))
            {
                var user =await _context.users.AnyAsync(x => x.userName == model.userName && x.password == model.password);
                if(user)
                {              
                    HttpContext.Session.SetString("IsUserLoggedIn","true");
                    
                    return View("AdminIndex");
                }
                
            }
        }

        return View();
    }

   
    public async Task<IActionResult> AdminIndex()
    {
        string? Giris = HttpContext.Session.GetString("IsUserLoggedIn");  
        if(Giris != null)
        {
            
            if(Giris == "true")
            {               
                var viewModel = new CountViewModel
                    {
                        YemekCount =await _context.urunler.Where(x => x.kategoriId == 1).CountAsync(),
                        AlkolCount = await _context.urunler.Where(x => x.kategoriId == 2).CountAsync(),
                        IcecekCount = await _context.urunler.Where(x => x.kategoriId == 3).CountAsync(),
                        ExtraCount = await _context.urunler.Where(x => x.kategoriId == 4).CountAsync(),
                        KampanyaCount =await  _context.urunler.Where(x => x.kategoriId == 5).CountAsync() 
                    };
                 return View(viewModel);
            }else{
                return RedirectToAction("Index");
            }
        }else{
            return RedirectToAction("Index");
        }        
    }
   

    public async Task<IActionResult> Menu(string category)
    {
        if(HttpContext.Session.GetString("IsUserLoggedIn") == "true")
        {
            ViewBag.category = category;
        
            if(category == "hepsi")
            {
                var allProduct = await _context.urunler.ToListAsync();
                return View(allProduct);
            }else{
                var filteredProduct = await _context.urunler
                                            .Include(x => x.Tablo)
                                            .Where(x => x.Tablo.tabloName == category)
                                            .ToListAsync();
                return View(filteredProduct);
            }
        }else{
            return View("Index");
        }
      
    }  

    [HttpGet]
    public IActionResult GetTablolarByKategoriId(int kategoriId)
    {
         var tablolar = _context.tablolar.Where(t => t.kategoriId == kategoriId).ToList();
    
        // JSON olarak tabloları dön
        return Json(tablolar);
    }

    

}
