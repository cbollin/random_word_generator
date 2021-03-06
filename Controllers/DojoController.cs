using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Linq;


namespace ninjagold2.Controllers
{
    public class DojoController : Controller
{
    [HttpGet]
    [Route("/")]
    public IActionResult Index()
    {   
        if(HttpContext.Session.GetInt32("count") == null)
        {
            HttpContext.Session.SetInt32("count", 0);
            @ViewBag.count = HttpContext.Session.GetInt32("count");
        }
        return View("index"); 
    }

    [HttpPost]
    [Route("/generate")]
    public IActionResult Generate()
    {   
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        Random random = new Random();
        string finalString =  new string(Enumerable.Repeat(chars, 8)
        .Select(s => s[random.Next(s.Length)]).ToArray());
        @ViewBag.finalString = finalString;
        HttpContext.Session.SetInt32("count", (int)HttpContext.Session.GetInt32("count") + 1);
        @ViewBag.count = HttpContext.Session.GetInt32("count");
        Console.WriteLine("*********************" + finalString);
        return View("Index");    
    }

  }
}
