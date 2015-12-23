using AutoMapper;
using Core.Data.Models;
using Core.Models;

namespace Core.Data.Mappers
{
    internal class AdjustmentMapper : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<AdjustmentDb, Adjustment>();
        }
    }
}
