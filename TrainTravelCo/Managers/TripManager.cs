using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainTravelCo.Data;
using TrainTravelCo.Models;

namespace TrainTravelCo.Managers
{
    public class TripManager
    {


        public List<TripListDTO> ListTrips()
        {
            List<Trip> temp = DataStore.Instance.ListTrips();
            List<TripListDTO> DTOlist = new List<TripListDTO>();
            for (int i = 0; i < temp.Count; i++)
            {
                DTOlist.Add(new TripListDTO() { Origin = temp[i].Origin, DepartureTime = temp[i].DepartureTime, Destination = temp[i].Destination, TrainToDestination = temp[i].TrainToDestination, Id = temp[i].Id });
            }

            return DTOlist;
        }

      

        public string Createtrip(TripDTO tripdto)
        {


            List<Train> tmp = DataStore.Instance.ListTrains();
            bool TrainFound = false;
            foreach (var item in tmp)
            {
                if (item.Id == tripdto.TrainId)
                {
                    Trip tripToCreate = new Trip()
                    {
                        Origin = tripdto.Origin, Destination = tripdto.Destination, DepartureTime = tripdto.DepartureTime, TrainToDestination = item

                    };
                    DataStore.Instance.CreateTrip(tripToCreate);
                    TrainFound = true;
                    break;

                }
                
            }
            if (TrainFound)
            {
                return "Trip created";
            }
            else
            {
                return "Train with inserted Id not found";
            }
        }





    }
}
