using System;
using System.Data.SQLite;
using Dapper;
using WekaWeka.Models;
using WekaWeka.Utils;

namespace WekaWeka.Repositories
{
    public class LuggageCheckoutRepository
    {
        public bool Checkout(LuggageCheckout checkout)
        {
            using var conn = new SQLiteConnection(Data.Db.ConnectionString);
            conn.Open();

            using var transaction = conn.BeginTransaction();

            try
            {
                // Insert checkout record
                var insertSql = @"
                INSERT INTO luggage_checkouts (
                    id,
                    luggage_id,
                    customer_id,
                    collector_name,
                    collector_phone,
                    collector_id_number,
                    relationship_to_customer,
                    remarks,
                    checked_out_by_user_id,
                    node_id,
                    checked_out_at
                )
                VALUES (
                    @id,
                    @luggage_id,
                    @customer_id,
                    @collector_name,
                    @collector_phone,
                    @collector_id_number,
                    @relationship_to_customer,
                    @remarks,
                    @checked_out_by_user_id,
                    @node_id,
                    @checked_out_at
                );
                ";

                conn.Execute(insertSql, checkout, transaction);

                // Update luggage
                var updateSql = @"
                UPDATE luggage
                SET 
                    is_checkedout = 1,
                    checkout_id = @checkout_id,
                    status = 'checked_out',
                    updated_at = @updated_at
                WHERE id = @luggage_id;
                ";

                conn.Execute(updateSql, new
                {
                    checkout_id = checkout.id,
                    luggage_id = checkout.luggage_id,
                    updated_at = DateTime.UtcNow.ToString("o")
                }, transaction);

                transaction.Commit();
                return true;
            }
            catch
            {
                transaction.Rollback();
                return false;
            }
        }


        public bool CheckoutMultiple(List<LuggageCheckout> checkouts)
        {
            using var conn = new SQLiteConnection(Data.Db.ConnectionString);
            conn.Open();

            using var transaction = conn.BeginTransaction();

            try
            {
                foreach (var checkout in checkouts)
                {
                    var insertSql = @"
                    INSERT INTO luggage_checkouts (
                        id, luggage_id, customer_id,
                        collector_name, collector_phone, collector_id_number,
                        relationship_to_customer, remarks,
                        checked_out_by_user_id, node_id, checked_out_at
                    )
                    VALUES (
                        @id, @luggage_id, @customer_id,
                        @collector_name, @collector_phone, @collector_id_number,
                        @relationship_to_customer, @remarks,
                        @checked_out_by_user_id, @node_id, @checked_out_at
                    );";

                    conn.Execute(insertSql, checkout, transaction);

                    var updateSql = @"
                    UPDATE luggage
                    SET 
                        is_checkedout = 1,
                        checkout_id = @checkout_id,
                        status = 'checked_out',
                        updated_at = @updated_at
                    WHERE id = @luggage_id
                        AND is_checkedout = 0;
                    ";

                    var rows = conn.Execute(updateSql, new
                    {
                        checkout_id = checkout.id,
                        luggage_id = checkout.luggage_id,
                        updated_at = DateTime.UtcNow.ToString("o")
                    }, transaction);

                    // guard against double checkout
                    if (rows == 0)
                        throw new Exception("One or more luggage already checked out.");
                }

                transaction.Commit();
                return true;
            }
            catch
            {
                transaction.Rollback();
                return false;
            }
        }
    }
}