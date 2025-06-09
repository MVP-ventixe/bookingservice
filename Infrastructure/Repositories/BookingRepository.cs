using Infrastructure.Data;
using Infrastructure.Entities;
using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;


public class BookingRepository(DataContext context) : BaseRepository<BookingEntity>(context), IBookingRepository
{
    public override async Task<RepositoryResult<IEnumerable<BookingEntity>>> GetAllAsync()
    {
        try
        {
            var list = await _dbSet.Include(x => x.BookingUser).ThenInclude(x => x!.Address).ToListAsync();
            return new RepositoryResult<IEnumerable<BookingEntity>> { IsSuccess = true, Result = list };
        }
        catch (Exception ex)
        {
            return new RepositoryResult<IEnumerable<BookingEntity>> { IsSuccess = false, ErrorMessage = ex.Message };
        }
    }

    public override async Task<RepositoryResult<BookingEntity?>> GetByIdAsync(object id)
    {
        try
        {
            var entity = await _dbSet
                .Include(x => x.BookingUser)
                .ThenInclude(x => x!.Address)
                .FirstOrDefaultAsync(x => x.Id == (string)id);

            if (entity == null)
                return new RepositoryResult<BookingEntity?> { IsSuccess = false, ErrorMessage = "Not found" };

            return new RepositoryResult<BookingEntity?> { IsSuccess = true, Result = entity };
        }
        catch (Exception ex)
        {
            return new RepositoryResult<BookingEntity?> { IsSuccess = false, ErrorMessage = ex.Message };
        }
    }
}
