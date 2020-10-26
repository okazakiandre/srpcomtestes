using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using SrpComTestes.Api.Domain;
using System;

namespace SrpComTestes.Api.Infrastructure.Repositories
{
    public class ClienteDbMapper : BsonClassMap<Cliente>
    {
        public ClienteDbMapper()
        {
            AutoMap();
            SetIgnoreExtraElements(true);
            DateTimeSerializer dts = new DateTimeSerializer(DateTimeKind.Local);
            MapMember(c => c.DataCadastro).SetSerializer(dts);
            MapMember(c => c.DataNascimento).SetSerializer(dts);
        }
    }
}
