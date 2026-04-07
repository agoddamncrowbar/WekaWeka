using Dapper;
using System.Data.SQLite;
using WekaWeka.Models;
using WekaWeka.Data;

namespace WekaWeka.Repositories
{
    public class NodeRepository
    {
        public Node GetActiveNode()
        {
            using var conn = new SQLiteConnection(Db.ConnectionString);

            return conn.QueryFirstOrDefault<Node>(
                @"SELECT 
                    id,
                    name,
                    is_active as is_active,
                    created_at as created_at,
                    updated_at as updated_at
                  FROM nodes
                  WHERE is_active = 1
                  LIMIT 1"
            );
        }
    }
}