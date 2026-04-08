using System.IO;
using WekaWeka.Models;
using WekaWeka.Repositories;

namespace WekaWeka.Utils
{
    public static class SessionManager
    {
        private static readonly string SessionFile = "session.txt";

        public static User CurrentUser { get; private set; }
        public static string CurrentNodeId { get; private set; }

        public static bool IsLoggedIn => CurrentUser != null;

        // Start session after login
        public static void StartSession(User user)
        {
            CurrentUser = user;
            CurrentNodeId = user.node_id;

            // persist session (save user id)
            File.WriteAllText(SessionFile, user.Id);
        }

        // Load session on app startup
        public static void LoadSession()
        {
            if (!File.Exists(SessionFile))
                return;

            var userId = File.ReadAllText(SessionFile);

            if (string.IsNullOrWhiteSpace(userId))
                return;

            var repo = new UserRepository();
            var user = repo.GetById(userId);

            if (user == null || user.Is_active!=1)
            {
                ClearSession();
                return;
            }

            CurrentUser = user;
            CurrentNodeId = user.node_id;
        }

        // Logout
        public static void ClearSession()
        {
            CurrentUser = null;
            CurrentNodeId = null;

            if (File.Exists(SessionFile))
                File.Delete(SessionFile);
        }
    }
}