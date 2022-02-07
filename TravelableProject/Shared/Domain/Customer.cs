using System.Collections.Generic;

namespace TravelableProject.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        public string GuestName { get; set; }
        public string GuestAddress { get; set; }
        public string ContactNumber { get; set; }
        public string EmailAddress { get; set; }
        public virtual List<Booking> Bookings { get; set; }
    }
}