using Core.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public class JournalRepository : Repository
    {
        public Journal Get(int id)
        {
            return Execute(conn => 
            {
                //todo: how to use aggregates - have adjustments in constructor but how to load (simply as a dto then translate?)
                //todo: how should adjustments hold foreign keys - load full objects or have id's too
                var journal = conn.Query<Journal>("select * from Journal where Id = @Id", new { Id = id }).Single();
                journal.Adjustments = conn.Query<Adjustment>("select * from Adjustment where JournalId = @Id", new { Id = id });
                return journal;
            });
        }

        public IEnumerable<Journal> GetAll()
        {
            return Execute(conn => conn.Query<Journal>("select * from Journal"));
        }
    }
}
