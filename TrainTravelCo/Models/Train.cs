using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainTravelCo.Models
{
    public class Train
    {

        public string RegistrationNumber { get; set; }

        public int MaxCapacity { get; set; }

        public int Id { get; private set; }

        private static int _idCount = 0;

        public Train()
        {
            Id = _idCount;
            _idCount += 1;
        }
    }
}
