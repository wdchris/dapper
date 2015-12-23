using System.Collections.Generic;
using System.Linq;

namespace Core.Models
{
    public class Journal
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public JournalStatus JournalStatus { get; set; }
        private readonly List<Adjustment> _adjustments;

        public Journal(int id)
            :this(id, Enumerable.Empty<Adjustment>())
        { }

        public Journal(int id, IEnumerable<Adjustment> adjustments)
        {
            Id = id;
            _adjustments = adjustments.ToList();
        }

        public IEnumerable<Adjustment> GetAdjustments()
        {
            return _adjustments;
        }

        public void AddAdjustment(Adjustment adjustment)
        {
            _adjustments.Add(adjustment);
        }
    }
}
