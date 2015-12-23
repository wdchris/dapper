using System.Collections.Generic;
using System.Linq;
using Core.Data.Models;
using Core.Models;
using Dapper;

namespace Core.Data.Repositories
{
    public class JournalRepository : Repository
    {
        public Journal Get(int id)
        {
            return Execute(conn =>
            {
                using (var multi = conn.QueryMultiple(
                    "select * from Journal where Id = @Id; " +
                    "select * from Adjustment where JournalId = @Id;", new { Id = id }))
                {
                    var journal = multi.Read<JournalDb>().Single();
                    var adjustments = multi.Read<AdjustmentDb>().ToList();

                    return journal.Map(adjustments);
                }
            });
        }

        public IEnumerable<Journal> GetAll()
        {
            return Execute(conn =>
            {
                using (var multi = conn.QueryMultiple(
                    "select * from Journal; " +
                    "select * from Adjustment;"))
                {
                    var journals = multi.Read<JournalDb>().ToList();
                    var adjustments = multi.Read<AdjustmentDb>().ToList();

                    return
                        from journal in journals
                        let journalAdjustments =
                            from adjustment in adjustments
                            where adjustment.JournalId == journal.Id
                            select adjustment
                        select journal.Map(journalAdjustments);
                }
            });
        }
    }
}
