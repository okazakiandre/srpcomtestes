using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using SrpComTestes.Api.Domain;
using SrpComTestes.Api.Infrastructure.SeedWork;
using System;
using System.Threading.Tasks;

namespace SrpComTestes.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientesAcopladoController : ControllerBase
    {
        private IMongoCollection<Cliente> CliCol { get; }

        public ClientesAcopladoController(IMongoDbContext db)
        {
            CliCol = db.GetCollection<Cliente>("Cliente");
        }

        [HttpGet]
        public async Task<IActionResult> Consultar(string nomeParcial, DateTime? dataInicial, DateTime? dataFinal)
        {
            nomeParcial ??= "";
            dataInicial ??= DateTime.MinValue;
            dataFinal ??= DateTime.MaxValue;
            var ret = await CliCol.Find(c => c.Nome.Contains(nomeParcial) &&
                                             c.DataCadastro >= dataInicial.Value &&
                                             c.DataCadastro <= dataFinal.Value &&
                                             c.Tipo == 2).ToListAsync();
            return Ok(ret);
        }
    }
}
