using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{

    public DbSet<BookingEntity> Bookings { get; set; }
    public DbSet<BookingUserEntity> BookingUsers { get; set; }
    public DbSet<BookingAddressEntity> BookingAdresses { get; set; }
}
