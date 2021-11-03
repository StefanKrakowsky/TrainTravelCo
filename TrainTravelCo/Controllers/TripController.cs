using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrainTravelCo.Managers;
using TrainTravelCo.Models;

namespace TrainTravelCo.Controllers
{
    [Route("trip")]
    [ApiController]
    public class TripController : ControllerBase
    {
        private TripManager _tripManager = new TripManager();


        [HttpPost]
        public string CreateTrip(TripDTO dto)
        {
            return _tripManager.Createtrip(dto);
        }

        [HttpGet]
        public List<TripListDTO> ListTrips()
        {
            return _tripManager.ListTrips();
        }

    }
}
