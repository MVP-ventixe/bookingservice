using Business.Models;
using Business.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController(IBookingService bookingService) : ControllerBase
    {
        private readonly IBookingService _bookingService = bookingService;

        [HttpPost]
        public async Task<IActionResult> CreateBooking(CreateBookingRequest request)
        {
            if (request == null)
            {
                return BadRequest("Booking data is required.");
            }
            var result = await _bookingService.CreateBookingAsync(request);
            if (result.IsSuccess)
            {
                return Ok();

            }
            return BadRequest(result.ErrorMessage);
        }
    }
}
