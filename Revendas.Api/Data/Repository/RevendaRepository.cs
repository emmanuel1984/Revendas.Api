using Microsoft.EntityFrameworkCore;
using Revendas.Api.Data.Context;
using Revendas.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Revendas.Api.Data.Repository
{
    public class RevendaRepository : BaseRepository, IRevendaRepository
    {
        public RevendaRepository(AppDbContext context) : base(context) { }

        public async void AddAsync(Revenda revenda)
        {
            _context.Revenda.AddAsync(revenda);
            _context.SaveChanges();
        }

        public async Task<Revenda> FindByIdAsync(int id)
        {
            return await _context.Revenda.FindAsync(id);
        }

        public async Task<IEnumerable<Revenda>> ListAsync()
        {
            return await _context.Revenda.ToListAsync();
        }
        public void Update(Revenda revenda)
        {
            _context.Revenda.Update(revenda);
            _context.SaveChanges();
        }
    }
}
