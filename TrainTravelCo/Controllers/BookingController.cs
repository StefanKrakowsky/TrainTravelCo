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
    [Route("booking")]
    [ApiController]
    public class BookingController : ControllerBase
    {

        private BookingManager _bookingManager = new BookingManager();

        [HttpGet]
        public List<TripListDTO> Search(string start)
        {
            return _bookingManager.Search(start);
        } 

        [HttpPost]
        public string BookTrip(BookingDTO dto)
        {
            Customer newCustomer = new Customer()
            {
                Name = dto.CustomerName,
                PhoneNumber = dto.CustomerPhoneNumber

            };

          return _bookingManager.BookTrip(dto.TripId, newCustomer);
           

        }


    }
}
