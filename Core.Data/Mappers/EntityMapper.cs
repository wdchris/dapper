using AutoMapper;
using Core.Data.Models;
using Core.Models;

namespace Core.Data.Mappers
{
    internal class EntityMapper : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<EntityDb, Entity>();
        }
    }
}
