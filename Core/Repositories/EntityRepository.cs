using Core.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public class EntityRepository : Repository
    {
        public Entity Get(int id)
        {
            return Execute(conn => conn.Query<Entity>("select * from entity where Id = @Id", new { Id = id }).Single());
        }

        public IEnumerable<Entity> GetAll()
        {
            return Execute(conn => conn.Query<Entity>("select * from entity"));
        }
    }
}
