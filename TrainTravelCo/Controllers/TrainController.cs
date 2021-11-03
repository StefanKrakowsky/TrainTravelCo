using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrainTravelCo.Models;
using TrainTravelCo.Data;
using TrainTravelCo.Managers;

namespace TrainTravelCo.Controllers
{
    [Route("train")]
    [ApiController]
    public class TrainController : ControllerBase
    {
        private TrainManager _trainManager = new TrainManager();  

        [HttpPost]
        public void CreateTrain(Train trainToCreate)
        {
            _trainManager.CreateTrain(trainToCreate);

        }

        [HttpGet]
        public List<Train> ListTrains()
        {
            return _trainManager.ListTrains();
        }



    }
}
