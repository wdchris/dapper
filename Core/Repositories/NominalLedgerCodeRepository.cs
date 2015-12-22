using Core.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public class NominalLedgerCodeRepository : Repository
    {
        public NominalLedgerCode Get(int id)
        {
            return Execute(conn => conn.Query<NominalLedgerCode>("select * from NominalLedgerCode where Id = @Id", new { Id = id }).Single());
        }

        public IEnumerable<NominalLedgerCode> GetAll()
        {
            return Execute(conn => conn.Query<NominalLedgerCode>("select * from NominalLedgerCode"));
        }
    }
}
