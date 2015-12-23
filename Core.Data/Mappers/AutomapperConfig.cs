using AutoMapper;

namespace Core.Data.Mappers
{
    public static class AutomapperConfig
    {
        public static void RegisterAutomapper()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile(new AdjustmentMapper());
                cfg.AddProfile(new JournalMapper());
                cfg.AddProfile(new NominalLedgerCodeMapper());
                cfg.AddProfile(new EntityMapper());
            });
        }
    }
}
