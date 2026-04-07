using Dapper;
using System.Data.SQLite;
using WekaWeka.Data;
using WekaWeka.Models;

namespace WekaWeka.Repositories
{
    public class UserRepository
    {
        private readonly string _connectionString = "Data Source=local.db";

        public User GetByUsername(string username)
        {
            using var conn = new SQLiteConnection(_connectionString);

            return conn.QueryFirstOrDefault<User>(
                "SELECT * FROM users WHERE username = @Username AND is_deleted = 0",
                new { Username = username }
            );
        }

        public User GetById(string id)
        {
            using var conn = new SQLiteConnection(Db.ConnectionString);

            return conn.QueryFirstOrDefault<User>(
                "SELECT * FROM users WHERE id = @Id AND is_deleted = 0",
                new { Id = id }
            );
        }
    }
}