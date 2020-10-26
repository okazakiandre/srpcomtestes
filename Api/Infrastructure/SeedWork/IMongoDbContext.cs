using MongoDB.Driver;

namespace SrpComTestes.Api.Infrastructure.SeedWork
{
    public interface IMongoDbContext
    {
        IMongoCollection<T> GetCollection<T>(string collectionName);
    }
}
