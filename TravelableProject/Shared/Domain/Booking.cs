using System;

namespace TravelableProject.Shared.Domain
{
    public class Booking : BaseDomainModel
    {
        public DateTime DateIn { get; set; }
        public DateTime DateOut { get; set; }
        public int HotelId { get; set; }
        public virtual Hotel Hotel { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}