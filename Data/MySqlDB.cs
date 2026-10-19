using MySql.Data.MySqlClient;

namespace WekaWeka.Data
{
    public static class MySqlDb
    {
        public static MySqlConnection GetConnection()
        {
            var connString = $@"
                Server={Utils.ConfigService.Get("Sync:Host")};
                Port={Utils.ConfigService.Get("Sync:Port")};
                Database={Utils.ConfigService.Get("Sync:Database")};
                Uid={Utils.ConfigService.Get("Sync:Username")};
                Pwd={Utils.ConfigService.Get("Sync:Password")};
            ";

            return new MySqlConnection(connString);
        }
    }
}