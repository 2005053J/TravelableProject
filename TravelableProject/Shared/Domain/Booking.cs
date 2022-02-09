using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelableProject.Shared.Domain
{
    public class Booking : BaseDomainModel
    {
        public int DurationId { get; set; }
        public virtual Duration Duration { get; set; }
        public int RoomId { get; set; }
        public virtual Room Room { get; set; }
        public int PaymentId { get; set; }
        public virtual Payment Payment { get; set; }
        public int HotelId { get; set; }
        public virtual Hotel Hotel { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}