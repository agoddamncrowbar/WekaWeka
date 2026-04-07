using System;
using System.Data.SQLite;
using System.IO;
using Dapper;
using WekaWeka.Utils;

namespace WekaWeka.Data
{
    public static class DbInitializer
    {
        private static string DbFile = "local.db";
        private static string ConnectionString = $"Data Source={DbFile}";

        public static void Initialize()
        {
            if (!File.Exists(DbFile))
            {
                SQLiteConnection.CreateFile(DbFile);
            }

            using var conn = new SQLiteConnection(ConnectionString);
            conn.Open();

            CreateTables(conn);
            SeedAdminUser(conn);
        }

        private static void CreateTables(SQLiteConnection conn)
        {
            var sql = @"
            CREATE TABLE IF NOT EXISTS nodes (
                id TEXT PRIMARY KEY,
                name TEXT NOT NULL,
                is_active INTEGER NOT NULL,
                created_at TEXT NOT NULL,
                updated_at TEXT NOT NULL
            );

            CREATE TABLE IF NOT EXISTS users (
                id TEXT PRIMARY KEY,
                username TEXT NOT NULL UNIQUE,
                password_hash TEXT NOT NULL,
                node_id TEXT NOT NULL,
                is_active INTEGER NOT NULL,
                created_at TEXT NOT NULL,
                updated_at TEXT NOT NULL,
                is_deleted INTEGER NOT NULL
            );
            CREATE TABLE IF NOT EXISTS luggage (
                id TEXT PRIMARY KEY,
                customer_id TEXT NOT NULL,
                description TEXT,
                weight REAL,
                tag_number TEXT UNIQUE,
                status TEXT NOT NULL,
                origin TEXT,
                destination TEXT,
                node_id TEXT NOT NULL,
                created_at TEXT NOT NULL,
                updated_at TEXT NOT NULL,
                is_deleted INTEGER NOT NULL DEFAULT 0,
                FOREIGN KEY (customer_id) REFERENCES customers(id)
            );
            ";

            conn.Execute(sql);
        }

        private static void SeedAdminUser(SQLiteConnection conn)
        {
            var existing = conn.QueryFirstOrDefault<int>(
                "SELECT COUNT(1) FROM users WHERE username = 'admin'"
            );

            if (existing > 0)
                return;

            var now = DateTime.UtcNow.ToString("o");

            // ensure at least one node exists
            var nodeId = Guid.NewGuid().ToString();

            conn.Execute(@"
                INSERT INTO nodes (id, name, is_active, created_at, updated_at)
                VALUES (@Id, @Name, 1, @CreatedAt, @UpdatedAt)
            ", new
            {
                Id = nodeId,
                Name = "Default Node",
                CreatedAt = now,
                UpdatedAt = now
            });

            var userId = Guid.NewGuid().ToString();
            var passwordHash = PasswordHelper.Hash("1234");

            conn.Execute(@"
                INSERT INTO users (id, username, password_hash, node_id, is_active, created_at, updated_at, is_deleted)
                VALUES (@Id, @Username, @PasswordHash, @NodeId, 1, @CreatedAt, @UpdatedAt, 0)
            ", new
            {
                Id = userId,
                Username = "admin",
                PasswordHash = passwordHash,
                NodeId = nodeId,
                CreatedAt = now,
                UpdatedAt = now
            });
            var sql = @"
            CREATE TABLE IF NOT EXISTS customers (
                id TEXT PRIMARY KEY,
                name TEXT NOT NULL,
                phone TEXT NOT NULL,
                email TEXT,
                id_number TEXT,
                id_type TEXT,
                node_id TEXT NOT NULL,
                created_at TEXT NOT NULL,
                updated_at TEXT NOT NULL,
                is_deleted INTEGER NOT NULL DEFAULT 0
            );
            ";

            conn.Execute(sql);
        }
    }
}