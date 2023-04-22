using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using testeCiclodeVida.Interfaces;
using testeCiclodeVida.Models;
using testeCiclodeVida.Services;

namespace testeCiclodeVida.Controllers;

public class HomeController : Controller
{


    IScopedService _scopedService_1;
    IScopedService _scopedService_2;
    ISingletonService _singletonService_1;
    ISingletonService _singletonService_2;
    ITransientService _transientService_1;
    ITransientService _transientService_2;

    public HomeController(IScopedService serviceScoped1,
        IScopedService serviceScoped2,
        ISingletonService serviceSingleton1 ,
        ISingletonService serviceSingleton2,
        ITransientService serviceTransient1,
        ITransientService serviceTransient2)
    {
        _scopedService_1 = serviceScoped1;
        _scopedService_2 = serviceScoped2;
        _singletonService_1 = serviceSingleton1;
        _singletonService_2 = serviceSingleton2;
        _transientService_1 = serviceTransient1;
        _transientService_2 = serviceTransient2;
    }

    public IActionResult Index()
     {
        ViewBag.scoped1 = "Instancia 1 " + _scopedService_1.GetID();
         ViewBag.scoped2 =  "Instancia 2 " + _scopedService_2.GetID();
        ViewBag.transient1 = "Instancia 1 " + _transientService_1.GetID();
        ViewBag.transient2 =  "Instancia 2 " + _transientService_2.GetID();
        ViewBag.singleton1 = "Instancia 1 " + _singletonService_1.GetID();
        ViewBag.singleton2 = "Instancia 2 " + _singletonService_2.GetID();
        return View();
        //return Ok( "Scoped" + Environment.NewLine + "Instancia 1 " +_scopedService_1.GetID() + Environment.NewLine + "Instancia 2 " + _scopedService_2.GetID() + Environment.NewLine +
       ///     "Transient" + Environment.NewLine + "Instancia 1 " + _transientService_1.GetID() + Environment.NewLine + "Instancia 2 " + _transientService_2.GetID() + Environment.NewLine +
      //  //    "Singleton" + Environment.NewLine + "Instancia 1 " + _singletonService_1.GetID() + Environment.NewLine + "Instancia 2 " + _singletonService_2.GetID() + Environment.NewLine
       //    ) ;
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

