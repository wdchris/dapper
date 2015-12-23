using AutoMapper;
using Core.Data.Models;
using Core.Models;

namespace Core.Data.Mappers
{
    internal class NominalLedgerCodeMapper : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<NominalLedgerCodeDb, NominalLedgerCode>();
        }
    }
}
