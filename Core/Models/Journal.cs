using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Journal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public JournalStatus JournalStatus { get; set; }
        public IEnumerable<Adjustment> Adjustments { get; set; }
    }
}
