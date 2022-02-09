using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelableProject.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string RoomsEndpoint = $"{Prefix}/Rooms";
        public static readonly string DurationsEndpoint = $"{Prefix}/Durations";
        public static readonly string HotelsEndpoint = $"{Prefix}/Hotels";
        public static readonly string PaymentsEndpoint = $"{Prefix}/Payments";
        public static readonly string BookingsEndpoint = $"{Prefix}/Bookings";
        public static readonly string CustomersEndpoint = $"{Prefix}/Customers";
    }
}
