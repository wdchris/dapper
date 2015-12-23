using System.Collections.Generic;
using System.Linq;
using Core.Data.Models;
using Core.Models;
using Dapper;

namespace Core.Data.Repositories
{
    public class EntityRepository : Repository
    {
        public Entity Get(int id)
        {
            return Execute(conn => conn.Query<EntityDb>("select * from entity where Id = @Id", new { Id = id }).Single().Map());
        }

        public IEnumerable<Entity> GetAll()
        {
            return Execute(conn => conn.Query<EntityDb>("select * from entity").Map());
        }
    }
}
