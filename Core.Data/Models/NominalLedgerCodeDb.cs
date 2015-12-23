using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Core.Models;

namespace Core.Data.Models
{
    internal class NominalLedgerCodeDb
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }

    internal static class NominalLedgerCodeDbExtensions
    {
        public static NominalLedgerCode Map(this NominalLedgerCodeDb code)
        {
            return Mapper.Map<NominalLedgerCode>(code);
        }

        public static IEnumerable<NominalLedgerCode> Map(this IEnumerable<NominalLedgerCodeDb> codes)
        {
            return codes.Select(a => a.Map());
        }
    }
}
