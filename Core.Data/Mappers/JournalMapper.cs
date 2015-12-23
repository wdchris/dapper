using AutoMapper;
using Core.Data.Models;
using Core.Models;

namespace Core.Data.Mappers
{
    internal class JournalMapper : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<JournalDb, Journal>();
        }
    }
}
