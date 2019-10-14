using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelBooking.BusinessLayer;
using HotelBooking.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelBooking.Controllers
{
    public class BookingController : ControllerBase
    {
        #region private variables
        private readonly IBookingRepository _bookingRepository;
        #endregion

        #region propertiy
        public BookingController(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }
        #endregion

        #region building endpoints
        // Get End Point
        [Route("Booking")]
        public IEnumerable<Booking> GetBookings()
        {
            return  _bookingRepository.GetBookings().ToList();
        }

        // Post end point
        [HttpPost]
        [Route("Booking")]
        public async Task<string> PostBookings([FromBody] Booking booking)
        {
            var result = await _bookingRepository.PostBookings(booking);
            return result;
        }

        // Post end point
        [HttpPost("/capacity-provider")]
        public async Task<string> Post([FromBody] CapacityProvider capacityProvider)
        {
            var result = await _bookingRepository.PostCapacityProvider(capacityProvider);
            return result;
        }


        // DELETE end point
        //[HttpDelete]
        [HttpGet]
        [Route("Booking/{id}")]
        public async Task<string[]> DeleteBook(int id)
        {
            var result = await _bookingRepository.DeleteBooking(id);
            return result;
        }
        #endregion
    }
}