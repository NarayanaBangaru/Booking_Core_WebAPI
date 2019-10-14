using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelBooking.Models;

namespace HotelBooking.BusinessLayer
{
    public class BookingRepository : IBookingRepository
    {
        #region private&public variables
        private readonly BookingDBContext _bookingDBContext;

        public string[] SuccessResponseMessage = { "True - Successfully deleted" };
        public string[] FailureResponseMessage = { "False - booking id does not exists" };
        #endregion

        #region constructor
        public BookingRepository(BookingDBContext bookingDBContext)
        {
            _bookingDBContext = bookingDBContext;
        }
        #endregion

        #region Get API
        public IEnumerable<Booking> GetBookings()
        {
            return  _bookingDBContext.Bookings.ToList();
        }
        #endregion

        #region Post Capacity provider API
        public async Task<string> PostCapacityProvider(CapacityProvider capacity)
        {
            try
            {
                _bookingDBContext.CapacityProviders.Add(capacity);
                await _bookingDBContext.SaveChangesAsync();
                return "True - Successfully added capacity provider";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
        #endregion


        #region Post Bookings API
        public async Task<string> PostBookings(Booking booking)
        {
            try
            {
                var s = _bookingDBContext.CapacityProviders.FirstOrDefault(c => c.Id == booking.Capacity_Provider_Id);
                if (s != null)
                {
                    _bookingDBContext.Bookings.Add(booking);
                     await _bookingDBContext.SaveChangesAsync();
                    return "True - Successfully booked";
                }
                else
                {
                    return "False - Capacity Provider does not exists.";
                }
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
        #endregion
        

        #region Delete booking API
        public async Task<string[]> DeleteBooking(int id)
        {
            try
            {
                var entity = _bookingDBContext.Bookings.FirstOrDefault(e => e.Id == id);
               
                if (entity != null)
                {
                    _bookingDBContext.Bookings.Remove(entity);
                    await _bookingDBContext.SaveChangesAsync();
                    return SuccessResponseMessage;
                }
                return FailureResponseMessage;
            }
            catch(Exception ex)
            {
                return new[] { ex.Message };
            }
        }
        #endregion
    }
}
