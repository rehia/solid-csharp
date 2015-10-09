using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Common
{
    public class Database : IDatabase
    {
        private static bool userIsSaved;

        public static void UserIsSaved(bool isSaved)
        {
            userIsSaved = isSaved;
        }

        public static bool UserIsSaved()
        {
            return userIsSaved;
        }

        public void Save(User user)
        {
            userIsSaved = true;
        }
    }
}
