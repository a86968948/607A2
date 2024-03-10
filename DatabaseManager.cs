using _607A2.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _607A2
{
    public class DatabaseManager
    {
        readonly SQLiteConnection connection;

        public DatabaseManager()
        {

            string directoryPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile);
            if (Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            string dbPath = Path.Combine(directoryPath, "Person_Data.db");
            connection = new SQLiteConnection(dbPath);
            connection.CreateTable<Signup>();
        }
        public void InsertUser(Signup new_user)
        {
            connection.Insert(new_user);
        }
    }
}
