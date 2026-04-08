using Dapper;
using System.Data.SQLite;
using WekaWeka.Models;
using WekaWeka.Data;

namespace WekaWeka.Repositories
{
    public class CustomerRepository
    {
        public void Insert(Customer customer)
        {
            var nodeRepo = new NodeRepository();
            var node = nodeRepo.GetActiveNode();

            if (node == null)
                throw new Exception("No active node found");

            customer.NodeId = node.id;

            using var conn = new SQLiteConnection(Db.ConnectionString);

            conn.Execute(@"
        INSERT INTO customers (
            id, name, phone, email,
            id_number, id_type,
            node_id, created_at, updated_at, is_deleted
        )
        VALUES (
            @Id, @Name, @Phone, @Email,
            @IdNumber, @IdType,
            @NodeId, @CreatedAt, @UpdatedAt, 0
        )
    ", customer);
        }
        public List<Customer> Search(string query)
        {
            using var conn = new SQLiteConnection(Db.ConnectionString);

            return conn.Query<Customer>(@"
        SELECT 
            id,
            name,
            phone,
            email,
            id_number as IdNumber,
            id_type as IdType,
            node_id as NodeId,
            created_at as CreatedAt,
            updated_at as UpdatedAt,
            is_deleted as IsDeleted
        FROM customers
        WHERE is_deleted = 0
          AND (
              name LIKE @Query OR
              phone LIKE @Query OR
              id_number LIKE @Query
          )
        ORDER BY created_at DESC
        LIMIT 50
    ", new { Query = $"%{query}%" }).AsList();
        }
    }
    
}