using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XZZ.Fk.Core;

namespace CodeFirstBlog.Controllers
{
    public class HomeController : Controller
    {
        private ILog _log;
        private IEnumerable<ILog> _logs;

        public HomeController(ILog log, IEnumerable<ILog> logList)
        {
            _log = log;
            _logs = logList;
        }

        public ActionResult Index()
        {
            ViewBag.LogName = _log.GetType().Name;
            ViewBag.LogNames = _logs.Select(x => x.GetType().Name).Aggregate((x, y) => { return x + ',' + y; });
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}