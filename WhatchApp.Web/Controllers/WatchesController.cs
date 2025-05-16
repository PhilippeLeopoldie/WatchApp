using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileSystemGlobbing;
using WhatchApp.Web.Models;
using WhatchApp.Web.Services;

namespace WhatchApp.Web.Controllers;

public class WatchesController : Controller
{
    static WatchService watchService = new WatchService();

    [HttpGet("")]
    public IActionResult Index() => View(watchService.GetAll());

    [HttpGet("details/{id}")]
    public IActionResult Details(int id)
    {
        var model = watchService.GetById(id);
        return View(model);
    }

    [HttpGet("/Create")]
    public IActionResult Create() => View();

    [HttpPost("/Create")]
    public IActionResult Create(Watch watch)
    {
        if (!ModelState.IsValid) return View();
        watch.Id = watchService.watches.Count() == 0 ? 1 : watchService.watches.Max(watch => watch.Id) + 1;
        watchService.Add(watch);
        return RedirectToAction(nameof(Index));
    }
    
}
