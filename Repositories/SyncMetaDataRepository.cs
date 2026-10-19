using System.Data.SQLite;
using Dapper;
using WekaWeka.Data;

namespace WekaWeka.Repositories
{
    public class SyncMetadataRepository
    {
        public string Get(string key)
        {
            using var conn = new SQLiteConnection(Db.ConnectionString);

            return conn.QueryFirstOrDefault<string>(
                "SELECT value FROM sync_metadata WHERE key = @key",
                new { key }
            );
        }

        public void Set(string key, string value)
        {
            using var conn = new SQLiteConnection(Db.ConnectionString);

            conn.Execute(@"
                INSERT INTO sync_metadata (key, value)
                VALUES (@key, @value)
                ON CONFLICT(key) DO UPDATE SET value = excluded.value
            ", new { key, value });
        }
    }
}