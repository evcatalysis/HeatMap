using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HeatMap.Entity;
using HeatMap.BLL.Repository;
using HeatMap.BLL.Interface;

namespace HeatMap.Controllers
{
    public class HomeController : Controller
    {
        private ILocationRepository _locationRepository;

        public HomeController() : this(new LocationRepository()) { }

        public HomeController(LocationRepository locationRepository)
        {
            this._locationRepository = locationRepository;
        }

        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult getLocationList()
        {
            List<location> list = new List<location>();
            list = _locationRepository.getLocations();
            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}
