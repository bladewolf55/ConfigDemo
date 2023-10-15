using ConfigFramework.Data;
using ConfigFramework.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ConfigCore.Controllers;

public class HomeController : Controller
{
    readonly ILogger<HomeController> _logger;
    readonly ConfigDb db;
    readonly Settings settings;

    public HomeController(ILogger<HomeController> logger, ConfigDb db, IOptions<Settings> settings)
    {
        _logger = logger;
        this.db = db;
        this.settings = settings.Value;
    }

    public IActionResult Index()
    {
        var customer = db.Customers.First();
        var model = new CustomerViewModel()
        {
            CustomerId = customer.CustomerId,
            Name = customer.Name,
            TestKey = settings.TestKey
        };
        return View(model);
    }
}
