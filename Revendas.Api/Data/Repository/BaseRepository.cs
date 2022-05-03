using Revendas.Api.Data.Context;

namespace Revendas.Api.Data.Repository
{
    public class BaseRepository
    {
        protected readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }
    }
}
