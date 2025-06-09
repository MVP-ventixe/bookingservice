using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Entities;

public class BookingUserEntity
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string FullName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;

    [ForeignKey(nameof(Address))]
    public string? BookingAdressId { get; set; }
    public BookingAdressEntity? Address { get; set; }
}
