using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using WekaWeka.Data;
using WekaWeka.Models;

namespace WekaWeka.Repositories
{
    public class LuggageRepository
    {
        public void Insert(Luggage luggage)
        {
            using var conn = new SQLiteConnection(Db.ConnectionString);

            conn.Execute(@"
                INSERT INTO luggage (
                    id, customer_id, description, weight,
                    tag_number, status,
                    origin, destination,
                    node_id, created_at, updated_at, is_deleted
                )
                VALUES (
                    @Id, @CustomerId, @Description, @Weight,
                    @TagNumber, @Status,
                    @Origin, @Destination,
                    @NodeId, @CreatedAt, @UpdatedAt, 0
                )
            ", luggage);
        }

        public Luggage GetByTag(string tagNumber)
        {
            using var conn = new SQLiteConnection(Db.ConnectionString);

            return conn.QueryFirstOrDefault<Luggage>(@"
                SELECT
                    id,
                    customer_id as CustomerId,
                    description,
                    weight,
                    tag_number as TagNumber,
                    status,
                    origin,
                    destination,
                    node_id as NodeId,
                    created_at as CreatedAt,
                    updated_at as UpdatedAt,
                    is_deleted as IsDeleted
                FROM luggage
                WHERE tag_number = @TagNumber
                  AND is_deleted = 0
                LIMIT 1
            ", new { TagNumber = tagNumber });
        }

        public List<Luggage> GetByCustomer(string customerId)
        {
            using var conn = new SQLiteConnection(Db.ConnectionString);

            return conn.Query<Luggage>(@"
                SELECT
                    id,
                    customer_id as CustomerId,
                    description,
                    weight,
                    tag_number as TagNumber,
                    status,
                    origin,
                    destination,
                    node_id as NodeId,
                    created_at as CreatedAt,
                    updated_at as UpdatedAt,
                    is_deleted as IsDeleted
                FROM luggage
                WHERE customer_id = @CustomerId
                  AND is_deleted = 0
                ORDER BY created_at DESC
            ", new { CustomerId = customerId }).AsList();
        }

        public List<Luggage> GetAll()
        {
            using var conn = new SQLiteConnection(Db.ConnectionString);

            return conn.Query<Luggage>(@"
                SELECT
                    id,
                    customer_id as CustomerId,
                    description,
                    weight,
                    tag_number as TagNumber,
                    status,
                    origin,
                    destination,
                    node_id as NodeId,
                    created_at as CreatedAt,
                    updated_at as UpdatedAt,
                    is_deleted as IsDeleted
                FROM luggage
                WHERE is_deleted = 0
                ORDER BY created_at DESC
            ").AsList();
        }

        public void UpdateStatus(string id, string status)
        {
            using var conn = new SQLiteConnection(Db.ConnectionString);

            conn.Execute(@"
                UPDATE luggage
                SET status = @Status,
                    updated_at = @UpdatedAt
                WHERE id = @Id
            ", new
            {
                Id = id,
                Status = status,
                UpdatedAt = DateTime.UtcNow.ToString("o")
            });
        }
    }
}