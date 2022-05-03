using Microsoft.AspNetCore.Mvc;
using Revendas.Api.Models;
using Revendas.Api.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Revendas.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RevendaController : ControllerBase
    {
        private readonly IRevendaServices _revendaServices;

        public RevendaController(IRevendaServices revendaServices)
        {
            _revendaServices = revendaServices;
        }

        [HttpGet]
        public async Task<IEnumerable<Revenda>> GetAllAsync()
        {
            var pessoa = await _revendaServices.ListAsync();
            return pessoa;
        }

        [HttpPost]
        public IActionResult Criar([FromBody] Revenda revenda)
        {
            if (revenda == null)
            {
                return BadRequest();
            }
            _revendaServices.AddAsync(revenda);

            return CreatedAtRoute("", new { Controller = "Revenda", id = revenda.Nome }, revenda);
        }

        [HttpDelete]
        public async Task Deletar(int id)
        {
            await _revendaServices.Remove(id);
        }

        [HttpPut]
        public async Task Atualizar([FromBody] Revenda revenda)
        {
            await _revendaServices.Update(revenda);
        }
    }
}
