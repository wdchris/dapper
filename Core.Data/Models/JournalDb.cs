using System.Collections.Generic;
using AutoMapper;
using Core.Models;

namespace Core.Data.Models
{
    internal class JournalDb
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public JournalStatus JournalStatus { get; set; }
    }

    internal static class JournalDbExtensions
    {
        public static Journal Map(this JournalDb journal, IEnumerable<AdjustmentDb> adjustments)
        {
            return Mapper.Map(journal, new Journal(journal.Id, adjustments.Map()));
        }
    }
}
