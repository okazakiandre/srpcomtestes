using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SrpComTestes.Api.Controllers;
using SrpComTestes.Api.Domain;
using SrpComTestes.Api.Infrastructure.Repositories;
using SrpComTestes.Api.Infrastructure.SeedWork;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SrpComTestes.UnitTest.Infrastructure.Repositories
{
    [TestClass]
    [TestCategory("UnitTest > Infrastructure > Repositories")]
    public class ClienteRepositoryTest
    {
        //[TestMethod]
        //public async Task DeveriaRetornarClientesQueTemOTexto1111NoNome()
        //{
        //    var mockDb = new Mock<IMongoDbContext>();
        //    var cliRep = new ClienteRepository(mockDb.Object);
        //    var ret = await cliRep.Consultar("1111", null, null);
        //    Assert.AreEqual("Cliente 1111", ret[0].Nome);
        //}
    }
}
