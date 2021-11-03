using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainTravelCo.Models;


namespace TrainTravelCo.Data
{
    public class DataStore
    {
        private static DataStore _instance = null;
        public static DataStore Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DataStore();
                }
                return _instance;
            }

        }


        private List<Train> _trains;

       

        private List<Trip> _trips;

        private DataStore()
        {
            _trains = new List<Train>()
            {
                new Train()
                {
                     MaxCapacity = 5, RegistrationNumber = "JSR912"
                },
                new Train()
                {
                    MaxCapacity = 3, RegistrationNumber = "JAS739"
                }

            };

            _trips = new List<Trip>()
            {
                new Trip()
                {
                    Origin = "Orebro", Destination = "Stockholm", DepartureTime = "08:45", TrainToDestination = _trains[0]
                },
                new Trip()
                {
                    Origin = "Malmoe", Destination = "Karlstad", DepartureTime = "09:10", TrainToDestination = _trains[1]
                }, 
                new Trip()
                {
                    Origin = "Helsingborg", Destination = "Helsingör", DepartureTime = "21.12", TrainToDestination = _trains[1]
                }
            };
            

        }


        public void CreateTrain(Train trainToCreate)
        {
            _trains.Add(trainToCreate);
        }

        public List<Train> ListTrains()
        {
            return _trains;
        }


        public void CreateTrip(Trip tripsToCreate)
        {
            _trips.Add(tripsToCreate);
        }

        public List<Trip> ListTrips()
        {
            return _trips;
        }









    }
}
