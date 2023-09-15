using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Sandbox.Models;
using Sandbox.Services.Abstraction;

namespace Sandbox.Controllers;

public class HomeController : Controller
{
    private readonly INumberService numberService;

    public HomeController(INumberService numberService)
    {
        this.numberService = numberService;
    }
    
    // GET
    public IActionResult Greeting(string name)
    {
        return View(viewName: nameof(Greeting), model: name);
    }


    public IActionResult GetNumber()
    {
        return Ok(numberService.GetNumber());
    }
    
    
}