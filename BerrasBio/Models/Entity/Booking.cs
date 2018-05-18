using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BerrasBio.Models.Entity
{
    public class Booking
    {
        public int ID { get; set; }
        public int NumOfSeats { get; set; }
        public int ShowingID { get; set; }

        public Showing Showing { get; set; }
    }
}
