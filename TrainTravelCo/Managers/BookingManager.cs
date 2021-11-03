using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainTravelCo.Data;
using TrainTravelCo.Models;

namespace TrainTravelCo.Managers
{
    public class BookingManager
    {
        public List<TripListDTO> Search(string origin)
        {
            List<Trip> temp = new List<Trip>();
            bool isFull = false;
            for (int i = 0; i < DataStore.Instance.ListTrips().Count; i++)
            {
                temp.Add(DataStore.Instance.ListTrips()[i]);
            }
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[i].Origin != origin)
                {
                    temp.RemoveAt(i);
                    --i;

                }
            }
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[i].Allbookings.Count >= temp[i].TrainToDestination.MaxCapacity)
                {
                    isFull = true;
                }
                if (isFull)
                {
                    temp.RemoveAt(i);
                    isFull = false;
                    --i;
                }


            }

             List < TripListDTO > DTOlist = new List<TripListDTO>();
            for (int i = 0; i < temp.Count; i++)
            {
                DTOlist.Add(new TripListDTO() { Origin = temp[i].Origin, DepartureTime = temp[i].DepartureTime, Destination = temp[i].Destination, TrainToDestination = temp[i].TrainToDestination, Id = temp[i].Id });
            }

            return DTOlist;

        }


        public string BookTrip(int Id, Customer customer)
        {
            
            
            foreach (var item in DataStore.Instance.ListTrips())
            {
                if (item.Id == Id)
                {
                    
                    
                    if (item.Allbookings.Count < item.TrainToDestination.MaxCapacity)
                    {
                        Booking newBooking = new Booking()
                        {
                            RegisteredCustomer = customer,
                            RegisteredTrip = item

                        };
                        item.Allbookings.Add(newBooking);
                        return "Booking succesfull";
                    }
                    else
                    {
                        return "The train is full";
                    }
                }
                
            }
            return "No trip matched the booking";







        }



    }
}
