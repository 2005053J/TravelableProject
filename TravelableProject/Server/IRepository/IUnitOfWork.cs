using TravelableProject.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelableProject.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Duration> Durations { get; }
        IGenericRepository<Payment> Payments { get; }
        IGenericRepository<Hotel> Hotels { get; }
        IGenericRepository<Room> Rooms { get; }
        IGenericRepository<Booking> Bookings { get; }
        IGenericRepository<Customer> Customers { get; }
    }
}
