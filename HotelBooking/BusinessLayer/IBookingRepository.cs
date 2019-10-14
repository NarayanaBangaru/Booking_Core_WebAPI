using HotelBooking.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotelBooking.BusinessLayer
{
    public interface IBookingRepository
    {
        Task<string> PostCapacityProvider(CapacityProvider capacity);

        IEnumerable<Booking> GetBookings();

        Task<string[]> DeleteBooking(int id);

        Task<string> PostBookings(Booking booking);

    }
}
