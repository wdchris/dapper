using System.Collections.Generic;
using System.Linq;
using Core.Data.Models;
using Core.Models;
using Dapper;

namespace Core.Data.Repositories
{
    public class NominalLedgerCodeRepository : Repository
    {
        public NominalLedgerCode Get(int id)
        {
            return Execute(conn => conn.Query<NominalLedgerCodeDb>("select * from NominalLedgerCode where Id = @Id", new { Id = id }).Single().Map());
        }

        public IEnumerable<NominalLedgerCode> GetAll()
        {
            return Execute(conn => conn.Query<NominalLedgerCodeDb>("select * from NominalLedgerCode").Map());
        }
    }
}
