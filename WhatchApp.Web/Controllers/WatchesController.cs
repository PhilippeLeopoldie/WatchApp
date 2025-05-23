using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileSystemGlobbing;
using WhatchApp.Web.Models;
using WhatchApp.Web.Services;
using WhatchApp.Web.Views.Watches;

namespace WhatchApp.Web.Controllers;

public class WatchesController(IService service) : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        var model = service.GetAll();
        var viewModel = new IndexVM()
        {
            WatchVMs = model.Select(watch => new IndexVM.WatchVM()
            {
                Id = watch.Id,
                Name = watch.Name,
            }).ToArray()
        };
        return View(viewModel);
    }

    [HttpGet("details/{id}")]
    public IActionResult Details(int id)
    {
        var model = service.GetById(id);
        if (model == null) return RedirectToAction("Index");
        var modelVM = new DetailsVM()
        {
            Name = model.Name,
            Description = model.Description,
            Price = model.Price,
            ReferenceNumber = model.ReferenceNumber,
        };
        return View(modelVM);
    }

    [HttpGet("/Create")]
    public IActionResult Create() => View();

    [HttpPost("/Create")]
    public IActionResult Create(CreateVM viewModel)
    {
        if (!ModelState.IsValid) return View();
        var watch = new Watch()
        {
            Name = viewModel.Name,
            Price = viewModel.Price,
            Description = viewModel.Description,
            ReferenceNumber = viewModel.ReferenceNumber,
        };
           
        service.Add(watch);
        return RedirectToAction(nameof(Index));
    }
    
}
