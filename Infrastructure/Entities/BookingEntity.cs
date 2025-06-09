using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Infrastructure.Entities;

public class BookingEntity
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string EventId { get; set; } = null!;

    public int TicketConunt { get; set; } = 1;

    public DateTime BookingDate { get; set; }

    public string FullName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string? Notes { get; set; }

    [ForeignKey(nameof(BookingUser))]
    public string? BookingUserId { get; set; }
    public BookingUserEntity? BookingUser { get; set; }



}
