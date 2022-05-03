using Revendas.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Revendas.Api.Data.Repository
{
    public interface IRevendaRepository
    {
        Task<IEnumerable<Revenda>> ListAsync();

        void AddAsync(Revenda revenda);

        Task<Revenda> FindByIdAsync(int id);

        void Update(Revenda revenda);

        void Remove(Revenda revenda);
    }
}
