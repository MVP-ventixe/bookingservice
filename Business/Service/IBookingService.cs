using Business.Models;

namespace Business.Service
{
    public interface IBookingService
    {
        Task<BookingResult> CreateBookingAsync(CreateBookingRequest request);
    }
}