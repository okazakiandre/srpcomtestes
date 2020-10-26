using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SrpComTestes.Api.Controllers;
using SrpComTestes.Api.Domain;
using SrpComTestes.Api.Infrastructure.SeedWork;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SrpComTestes.UnitTest.Controllers
{
    [TestClass]
    [TestCategory("UnitTest > Controllers")]
    public class ClientesAcopladoControllerTest
    {
        //[TestMethod]
        //public async Task DeveriaRetornarClientesQueTemOTexto1111NoNome()
        //{
        //    var mockDb = new Mock<IMongoDbContext>();
        //    mockDb.Setup(m => m.GetCollection<Cliente>(It.IsAny<string>())).Returns();
        //    var ctr = new ClientesAcopladoController(mockDb.Object);
        //    var ret = await ctr.Consultar("1111", null, null);
        //    Assert.AreEqual("Cliente 1111", ((List<Cliente>)ret)[0].Nome);
        //}
    }
}
