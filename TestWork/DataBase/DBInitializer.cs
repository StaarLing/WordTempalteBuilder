using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace TestWork.DataBase
{
    public class DBInitializer
    {
        public static void Initialize(string databasePath)
        {
            using (var connection = new SQLiteConnection($"Data Source={databasePath};Version=3;"))
            {
                connection.Open();
                string createTableQuery = @"
                CREATE TABLE IF NOT EXISTS log_operation (
	                id_log INTEGER NOT NULL,
	                Operation TEXT NOT NULL,
	                TemplateName TEXT NOT NULL,
	                EmailUser TEXT NOT NULL,
	                OperationDate TEXT NOT NULL,
                    OperationStatus TEXT,
	                PRIMARY KEY(id_log AUTOINCREMENT)
                )";
                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
