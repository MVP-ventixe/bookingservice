using Business.Models;
using Infrastructure.Entities;
using Infrastructure.Repositories;

namespace Business.Service;

public class BookingService(IBookingRepository bookingRepository) : IBookingService
{
    private readonly IBookingRepository _bookingRepository = bookingRepository;

    public async Task<BookingResult> CreateBookingAsync(CreateBookingRequest request)
    {
        var bookingEntity = new BookingEntity
        {
            EventId = request.eventId,
            FullName = request.FullName,
            Email = request.Email,
            PhoneNumber = request.PhoneNumber,
            TicketConunt = request.TicketCount,
            Notes = request.Notes,
        };
        var bookingUser = new BookingUserEntity
        {
            FullName = request.FullName,
            Email = request.Email,
            PhoneNumber = request.PhoneNumber
        };
        var boookingAdress = new BookingAdressEntity
        {
            City = request.City,
            PostalCode = request.PostalCode,
            Country = request.Country

        };
        var result = await _bookingRepository.AddAsync(bookingEntity);
        if (result == null)
        {
            return new BookingResult
            {
                IsSuccess = false,
                ErrorMessage = "Booking creation failed."
            };
        }
        else
        {
            return new BookingResult
            {
                IsSuccess = true,
                ErrorMessage = "Successfully created booking."
            };

        }

    }
}
