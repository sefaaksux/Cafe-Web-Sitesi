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

    public IActionResult Index()
    {
        return View();
    }

}
