using dugun1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace dugun1.Controllers
{
    public class PlacesController : ApiController
    {
        private List<Place> places = new List<Place>
        {
           new Place{Id=1,City="izmir",Places="Wedding Place 1"},
           new Place{Id=2,City="izmir",Places="Wedding Place 2"},
           new Place{Id=3,City="izmir",Places="Wedding Place 3"},
           new Place{Id=4,City="istanbul",Places=" Place 1"},
           new Place{Id=5,City="izmir",Places="Holiday Inn"},
           new Place{Id=6,City="ankara",Places="Flowerer 1"},
           new Place{Id=7,City="istanbul",Places="Mihtribat Korusu"},
           new Place{Id=8,City="istanbul",Places="Ciragan Palace"},
           new Place{Id=9,City="izmir",Places="deneme"}
        };
         ///api/places? City = izmir
        public IHttpActionResult GetPlace(string city)
        {
            var temp_place = (from p in places where p.City == city select p).OrderBy(x => x.Places).ToList();
            return Ok(temp_place);
        }
        public IHttpActionResult Getıd(int  id)
        {
            var temp_place = (from p in places where p.Id == id select p).FirstOrDefault();
            return Ok(temp_place);
        }
    }
}
