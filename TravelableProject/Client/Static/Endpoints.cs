using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelableProject.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string RoomsEndpoint = $"{Prefix}/rooms";
        public static readonly string DurationsEndpoint = $"{Prefix}/durations";
        public static readonly string HotelsEndpoint = $"{Prefix}/hotels";
        public static readonly string PaymentsEndpoint = $"{Prefix}/payments";
        public static readonly string BookingsEndpoint = $"{Prefix}/bookings";
        public static readonly string CustomersEndpoint = $"{Prefix}/customers";
    }
}
