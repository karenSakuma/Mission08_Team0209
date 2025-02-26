using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace Mission08_Team0209.Controllers;

public class HomeController : Controller
{

    //create private context instance here
    
    public HomeController() //constructor with temp variable
    {
        
    }

    public IActionResult Index()
    {
        return View();
    }
    
    /*[HttpGet]
     show the view where users can add a task to the database*/
    
    /*[HttpPost]
     show the new task that was added to the database*/
    
}