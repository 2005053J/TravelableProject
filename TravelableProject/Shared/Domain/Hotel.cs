using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelableProject.Shared.Domain
{
    public class Hotel : BaseDomainModel
    {
        public string HotelName { get; set; }
        public string Country { get; set; }
        public string HotelAddress { get; set; }
        public virtual List<Booking> Bookings { get; set; }

    }
}
