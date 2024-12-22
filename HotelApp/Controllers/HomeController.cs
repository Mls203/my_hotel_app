using HotelApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;

namespace HotelApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return View();
        }
      
        public ActionResult Detail(int id)
        {
            string jsonPath = Server.MapPath("~/App_Data/hotels.json");
            string jsonData = System.IO.File.ReadAllText(jsonPath);
            var hotels = JsonConvert.DeserializeObject<List<Hotel>>(jsonData);
            var selectedHotel = hotels.FirstOrDefault(h => h.Id == id);

            if (selectedHotel == null)
            {
                return HttpNotFound("Hotel not found");
            }

            return View(selectedHotel);
           
        }
    }
 }

