using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using WekaWeka.Data;
using WekaWeka.Models;
using WekaWeka.Repositories;

namespace WekaWeka.Services
{
    public class SyncService
    {
        public void SyncCustomers()
        {
            using var sqlite = new SQLiteConnection(Db.ConnectionString);
            using var mysql = MySqlDb.GetConnection();

            sqlite.Open();
            mysql.Open();

            using var transaction = sqlite.BeginTransaction();

            try
            {
                PushCustomers(sqlite, mysql);
                PullCustomers(sqlite, mysql);

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw;
            }
        }
        private void PushCustomers(SQLiteConnection sqlite, MySqlConnection mysql)
        {
            var localChanges = sqlite.Query<Customer>(@"
                SELECT *
                FROM customers
                WHERE last_synced_at IS NULL
                   OR updated_at > last_synced_at
            ").AsList();

                    foreach (var c in localChanges)
                    {
                        mysql.Execute(@"
                    INSERT INTO customers (
                        id, name, phone, email,
                        id_number, id_type,
                        node_id, created_at, updated_at, is_deleted
                    )
                    VALUES (
                        @Id, @Name, @Phone, @Email,
                        @IdNumber, @IdType,
                        @NodeId, @CreatedAt, @UpdatedAt, @IsDeleted
                    )
                    ON DUPLICATE KEY UPDATE
                        name = VALUES(name),
                        phone = VALUES(phone),
                        email = VALUES(email),
                        id_number = VALUES(id_number),
                        id_type = VALUES(id_type),
                        updated_at = VALUES(updated_at),
                        is_deleted = VALUES(is_deleted);
                ", c);

                        // mark as synced
                        sqlite.Execute(@"
                    UPDATE customers
                    SET last_synced_at = @now
                    WHERE id = @id
                ", new
                {
                    now = DateTime.UtcNow.ToString("o"),
                    id = c.Id
                });
            }
        }
        private void PullCustomers(SQLiteConnection sqlite, MySqlConnection mysql)
        {
            var metaRepo = new SyncMetadataRepository();
            var lastSync = metaRepo.Get("last_sync_customers") ?? "1970-01-01T00:00:00Z";

            var serverChanges = mysql.Query<Customer>(@"
        SELECT *
        FROM customers
        WHERE updated_at > @lastSync
    ", new { lastSync }).AsList();

            foreach (var c in serverChanges)
            {
                sqlite.Execute(@"
            INSERT INTO customers (
                id, name, phone, email,
                id_number, id_type,
                node_id, created_at, updated_at, is_deleted,
                last_synced_at
            )
            VALUES (
                @Id, @Name, @Phone, @Email,
                @IdNumber, @IdType,
                @NodeId, @CreatedAt, @UpdatedAt, @IsDeleted,
                @updated_at
            )
            ON CONFLICT(id) DO UPDATE SET
                name = excluded.name,
                phone = excluded.phone,
                email = excluded.email,
                id_number = excluded.id_number,
                id_type = excluded.id_type,
                updated_at = excluded.updated_at,
                is_deleted = excluded.is_deleted,
                last_synced_at = excluded.updated_at
        ", c);
            }

            metaRepo.Set("last_sync_customers", DateTime.UtcNow.ToString("o"));
        }
    }
}