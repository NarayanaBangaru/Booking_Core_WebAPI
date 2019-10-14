using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
     

namespace HotelBooking.Models
{
    public class BookingDBContext:DbContext
    {
        public BookingDBContext(DbContextOptions<BookingDBContext> dbContext) : base(dbContext)
        {

        }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<CapacityProvider> CapacityProviders { get; set; }
    }
}
