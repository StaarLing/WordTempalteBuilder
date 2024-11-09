using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace TestWork.DataBase
{
    public class DBLogger
    {
        private readonly string _connectionString;
        private DBInitializer _initializer;
        public DBLogger(string databasePath)
        {
            _connectionString = $"Data Source={DBInitializer._databasePath};Version=3;";
            _initializer = new DBInitializer() ;

        }

        public void LogOperation(string operation, string templateName, string emailUser, string operationStatus)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = "INSERT INTO log_operation (Operation, TemplateName, EmailUser, OperationDate, OperationStatus) " +
                    "VALUES (@Operation, @TemplateName, @EmailUser, @OperationDate, @OperationStatus)";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Operation", operation);
                    command.Parameters.AddWithValue("@TemplateName", templateName);
                    command.Parameters.AddWithValue("@EmailUser", emailUser);
                    command.Parameters.AddWithValue("@OperationDate", DateTime.Now.ToString());
                    command.Parameters.AddWithValue("@OperationStatus", operationStatus);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
