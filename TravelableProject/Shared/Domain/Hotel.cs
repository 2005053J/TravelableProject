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
        public int DurationId { get; set; }
        public virtual Duration Duration { get; set; }
        public int RoomId { get; set; }
        public virtual Room Room { get; set; }
        public int PaymentId { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual List<Booking> Bookings { get; set; }

    }
}
