using MessageAnalysisSampleApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MessageAnalysisSampleApp.Controllers
{
    public class HomeController : Controller
    {
        private static bool _clientInitialized;

        public HomeController()
        {
            if (!_clientInitialized)
            {
                _clientInitialized = true;
            }
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MessagesList()
        {
            return PartialView();
        }

        public IActionResult CustomerInsights()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ClearHistory()
        {
            EventsReceived.EventReceivedListStatic = new List<EventReceived>();
            return RedirectToAction("CustomerInsights");
        }
    }
}