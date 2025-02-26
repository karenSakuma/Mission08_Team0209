using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace Mission08_Team0209.Controllers;

public class HomeController : Controller
{

    //create private context instance here
    public HomeController()
    {
        
    }

    public IActionResult Index()
    {
        return View();
    }
    
}