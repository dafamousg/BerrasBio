using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BerrasBio.Models.Entity
{
    public class BookingViewModel
    {

        public BookingViewModel(){ }

        public int ID { get; set; }
        public int NumOfSeats { get; set; }
        public string MovieTitle { get; set; }
        public string SalonName { get; set; }
        public DateTime Date { get; set; }

    }
}
