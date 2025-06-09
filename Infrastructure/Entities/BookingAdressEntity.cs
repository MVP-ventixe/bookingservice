namespace Infrastructure.Entities;

public class BookingAddressEntity
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string City { get; set; } = null!;
    public string PostalCode { get; set; } = null!;
    public string Country { get; set; } = null!;
}