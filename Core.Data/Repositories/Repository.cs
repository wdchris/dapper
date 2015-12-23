using System;
using System.Data.SqlClient;

namespace Core.Data.Repositories
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
