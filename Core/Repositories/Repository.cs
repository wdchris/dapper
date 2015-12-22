using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public abstract class Repository
    {
        protected T Execute<T>(Func<SqlConnection,T> function)
        {
            using (var conn = new SqlConnection("server=.;database=dapper-test;trusted_connection=true;"))
            {
                conn.Open();

                return function(conn);
            }
        }
    }
}
