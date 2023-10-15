using ConfigFramework.Data;
using ConfigFramework.Models;
using System.Linq;
using System.Web.Mvc;

namespace ConfigFramework.Controllers
{
    public class HomeController : Controller
    {
        ConfigDb db = new ConfigDb();

        public ActionResult Index()
        {
            var customer = db.Customers.First();
            var model = new CustomerViewModel()
            {
                CustomerId = customer.CustomerId,
                Name = customer.Name,
                TestKey = Settings.TestKey
            };
            return View(model);
        }
    }
}