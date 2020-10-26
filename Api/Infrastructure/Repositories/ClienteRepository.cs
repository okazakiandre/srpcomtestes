using MongoDB.Driver;
using SrpComTestes.Api.Domain;
using SrpComTestes.Api.Infrastructure.RepositoryDefinitions;
using SrpComTestes.Api.Infrastructure.SeedWork;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SrpComTestes.Api.Infrastructure.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private IMongoCollection<Cliente> CliCol { get; }

        public ClienteRepository(IMongoDbContext db)
        {
            CliCol = db.GetCollection<Cliente>("Cliente");
        }

        public async Task<bool> Incluir(Cliente cli)
        {
            await CliCol.InsertOneAsync(cli);
            return true;
        }

        public async Task<long> Atualizar(Cliente cli)
        {
            var updDef = ClienteUpdateDefinition.Criar(cli);
            var res = await CliCol.UpdateOneAsync(c => c.NumeroCpfCnpj == cli.NumeroCpfCnpj, updDef);
            return res.ModifiedCount;
        }

        public async Task<List<Cliente>> Consultar(string nomeParcial = null, DateTime? dataInicial = null, DateTime? dataFinal = null)
        {
            var filtro = ClienteFilterDefinition.Criar(nomeParcial, dataInicial, dataFinal);
            return await CliCol.Find(filtro).ToListAsync();
        }
    }
}
