using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BerrasBio.Models.Entity
{
    public class Salon
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaxSeats { get; set; }

        public ICollection<Showing> Showings { get; set; }
    }
}
