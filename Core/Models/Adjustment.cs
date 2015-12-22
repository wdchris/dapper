using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Adjustment
    {
        public int Id { get; set; }
        public Journal Journal { get; set; }
        public Entity Entity { get; set; }
        public NominalLedgerCode NominalLedgerCode { get; set; }
        public decimal Value { get; set; }
    }
}
