using Revendas.Api.Data.Repository;
using Revendas.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Revendas.Api.Services
{
    public class RevendaServices : IRevendaServices
    {
        private readonly IRevendaRepository _revendaRepository;

        public RevendaServices(IRevendaRepository revendaRepository)
        {
            _revendaRepository = revendaRepository;
        }

        public void AddAsync(Revenda revenda)
        {
            _revendaRepository.AddAsync(revenda);
        }

        public async Task<Revenda> GetById(int id)
        {
            return await _revendaRepository.FindByIdAsync(id);
        }

        public async Task<IEnumerable<Revenda>> ListAsync()
        {
            return await _revendaRepository.ListAsync();
        }

        public async Task Remove(int id)
        {
            var revenda = await _revendaRepository.FindByIdAsync(id);
            _revendaRepository.Remove(revenda);
        }

        public async Task Update(Revenda item)
        {
            var revenda = await _revendaRepository.FindByIdAsync(item.Id);

            if (revenda != null)
            {
                revenda.Id = item.Id;
                revenda.Nome = item.Nome;
                revenda.CNPJ = item.CNPJ;
                revenda.Saldo = item.Saldo;
            }

            _revendaRepository.Update(revenda);
        }
    }
}
