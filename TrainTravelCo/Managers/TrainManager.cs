using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainTravelCo.Models;
using TrainTravelCo.Data;

namespace TrainTravelCo.Managers
{
    public class TrainManager
    {
        public void CreateTrain(Train trainToCreate)
        {
            DataStore.Instance.CreateTrain(trainToCreate);
        }

        public List<Train> ListTrains()
        {
            return DataStore.Instance.ListTrains();
        }
    }
}
