using HotelApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using RouteAttribute = System.Web.Http.RouteAttribute;

namespace HotelApp.Controllers
{
   // [RoutePrefix("api/hotels")]
    public class HotelsController : ApiController
    {
        
            // GET api/<controller>
            [System.Web.Http.HttpGet]
            [Route("api/hotels")]
            public IHttpActionResult GetHotels()
            {
                
                string filePath = System.Web.Hosting.HostingEnvironment.MapPath("~/App_Data/hotels.json");

                string jsonContent = File.ReadAllText(filePath);

                List<Hotel> hotels = JsonConvert.DeserializeObject<List<Hotel>>(jsonContent);

                return Ok(hotels);
            }


            // GET api/<controller>/5
            [System.Web.Http.HttpGet]
            [Route("api/hotels/{id}")]
            public IHttpActionResult GetHotelById(int id)
            {
            
                string filePath = System.Web.Hosting.HostingEnvironment.MapPath("~/App_Data/hotels.json");

                string jsonContent = File.ReadAllText(filePath);

                List<Hotel> hotels = JsonConvert.DeserializeObject<List<Hotel>>(jsonContent);

                Hotel hotel = hotels.FirstOrDefault(h => h.Id == id);

                if (hotel == null)
                {
                    
                    return NotFound();
                }

                return Ok(hotel);
            }

      
            // POST api/<controller>
            public void Post([FromBody] string value)
            {
            }

            // PUT api/<controller>/5
            public void Put(int id, [FromBody] string value)
            {
            }

            // DELETE api/<controller>/5
            public void Delete(int id)
            {
            }
    }
}