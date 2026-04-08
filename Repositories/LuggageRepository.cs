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
                origin, current_location,
                is_fragile,
                node_id, created_at, updated_at, is_deleted
            )
            VALUES (
                @id, @customer_id, @description, @weight,
                @tag_number, @status,
                @origin, @current_location,
                @is_fragile,
                @node_id, @created_at, @updated_at, 0
            )
        ", luggage);
        }

        public Luggage GetByTag(string tag_number)
        {
            using var conn = new SQLiteConnection(Db.ConnectionString);

            return conn.QueryFirstOrDefault<Luggage>(@"
                SELECT
                    id,
                    customer_id as customer_id,
                    description,
                    weight,
                    tag_number as tag_number,
                    status,
                    origin,
                    current_location,
                    node_id as node_id,
                    created_at as created_at,
                    updated_at as updated_at,
                    is_deleted as is_deleted
                FROM luggage
                WHERE tag_number = @tag_number
                  AND is_deleted = 0
                LIMIT 1
            ", new { tag_number = tag_number });
        }

        public List<Luggage> GetByCustomer(string customer_id)
        {
            using var conn = new SQLiteConnection(Db.ConnectionString);

            return conn.Query<Luggage>(@"
                SELECT
                    id,
                    customer_id as customer_id,
                    description,
                    weight,
                    tag_number as tag_number,
                    status,
                    origin,
                    current_location,
                    node_id as node_id,
                    created_at as created_at,
                    updated_at as updated_at,
                    is_deleted as is_deleted
                FROM luggage
                WHERE customer_id = @customer_id
                  AND is_deleted = 0
                  AND is_checkedout = 0
                ORDER BY created_at DESC
            ", new { customer_id = customer_id }).AsList();
        }

        public void UpdateStatus(string id, string status)
        {
            using var conn = new SQLiteConnection(Db.ConnectionString);

            conn.Execute(@"
                UPDATE luggage
                SET status = @status,
                    updated_at = @updated_at
                WHERE id = @id
            ", new
            {
                id = id,
                status = status,
                updated_at = DateTime.UtcNow.ToString("o")
            });
        }
    }
}