namespace Business.Models;

public class CreateBookingRequest
{
    public string eventId { get; set; } = null!;

    public string FullName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public int TicketCount { get; set; } = 1;
    public string? Notes { get; set; }
    public string City { get; set; } = null!;
    public string PostalCode { get; set; } = null!;
    public string Country { get; set; } = null!;
}
