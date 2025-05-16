using Microsoft.AspNetCore.Mvc;
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
    
}
