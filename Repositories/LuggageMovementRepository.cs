using System.Data.SQLite;
using Dapper;
using WekaWeka.Data;
using WekaWeka.Utils;

namespace WekaWeka.Repositories
{
    public class LuggageMovementRepository
    {
        public bool Transfer(string luggageId, string toLocation, string remarks, string movementType)
        {
            using var conn = new SQLiteConnection(Db.ConnectionString);
            conn.Open();

            using var transaction = conn.BeginTransaction();

            try
            {
                // get current location
                var fromLocation = conn.QueryFirstOrDefault<string>(
                    "SELECT current_location FROM luggage WHERE id = @id",
                    new { id = luggageId }, transaction
                );

                var movement = new
                {
                    id = Guid.NewGuid().ToString(),
                    luggage_id = luggageId,
                    from_location = fromLocation,
                    to_location = toLocation,
                    moved_by_user_id = SessionManager.CurrentUser.Id,
                    node_id = SessionManager.CurrentNodeId,
                    movement_type = movementType,
                    remarks = remarks,
                    moved_at = DateTime.UtcNow.ToString("o")
                };

                conn.Execute(@"
            INSERT INTO luggage_movements (
                id, luggage_id,
                from_location, to_location,
                moved_by_user_id, node_id,
                movement_type, remarks, moved_at
            )
            VALUES (
                @id, @luggage_id,
                @from_location, @to_location,
                @moved_by_user_id, @node_id,
                @movement_type, @remarks, @moved_at
            );
        ", movement, transaction);

                conn.Execute(@"
            UPDATE luggage
            SET current_location = @to_location,
                updated_at = @updated_at
            WHERE id = @luggage_id;
        ", new
                {
                    to_location = toLocation,
                    updated_at = DateTime.UtcNow.ToString("o"),
                    luggage_id = luggageId
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
    }
}
