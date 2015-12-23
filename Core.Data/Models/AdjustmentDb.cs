using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Core.Models;

namespace Core.Data.Models
{
    internal class AdjustmentDb
    {
        public int Id { get; set; }
        public int JournalId { get; set; }
        public int EntityId { get; set; }
        public int NominalLedgerCodeId { get; set; }
        public decimal Value { get; set; }
    }

    internal static class AdjustmentDbExtensions
    {
        public static Adjustment Map(this AdjustmentDb adjustment)
        {
            return Mapper.Map<Adjustment>(adjustment);
        }

        public static IEnumerable<Adjustment> Map(this IEnumerable<AdjustmentDb> adjustments)
        {
            return adjustments.Select(a => a.Map());
        }
    }
}
