using Revendas.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Revendas.Api.Services
{
    public interface IRevendaServices
    {
        Task<IEnumerable<Revenda>> ListAsync();
        Task<Revenda> GetById(int id);
        void AddAsync(Revenda revenda);
        Task Update(Revenda revenda);
        Task Remove(int id);
    }
}
