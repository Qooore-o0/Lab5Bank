using System;
using System.Data.SQLite;

namespace Bank
{
    internal class Base
    {
        static string connectionString = "Data Source=accounts.db;Version=3;";
        string errorText;

        string _login;
        string _password;
        string _fio;

        public void InitializeDatabase()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string createTable = "CREATE TABLE \"Base\" (\r\n\t\"Login\"\tTEXT NOT NULL UNIQUE,\r\n\t\"Password\"\tTEXT NOT NULL,\r\n\t\"FIO\"\tTEXT NOT NULL,\r\n\t\"Sum\"\tINTEGER,\r\n\t\"Day\"\tINTEGER,\r\n\t\"AddSum\"\tINTEGER,\r\n\t\"Procent\"\tINTEGER\r\n);";

                using (SQLiteCommand command = new SQLiteCommand(createTable, connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SQLiteException)
                    {

                    }
                }
            }
        }

        public void AddNewUser(string login, string password, string fio)
        {
            errorText = "";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                //                string insertProductQuery = "INSERT INTO Base (Login, Password, FIO, Sum, Day, AddSum, Procent) VALUES (@Login, @Password, @FIO, @Sum, @Day, @AddSum, @Procent)";
                string insertQuery = "INSERT INTO Base (Login, Password, FIO) VALUES (@Login, @Password, @FIO)";

                using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@FIO", fio);

                    //, float sum, int day, int addSum, float procent

                    //command.Parameters.AddWithValue("@Sum", sum);
                    //command.Parameters.AddWithValue("@Day", day);
                    //command.Parameters.AddWithValue("@AddSum", addSum);
                    //command.Parameters.AddWithValue("@Procent", procent);

                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SQLiteException)
                    {
                        errorText = "Пользователь уже существует!";
                    }
                }
            }
        }
        public string ErrorInfo()
        {
            return errorText;
        }

        public void SearchProduct(string login, string password)
        {
            string userLogin = login;
            string userPassword = password;

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string searchUser = "SELECT * FROM Base WHERE Login = @Login AND Password = @Password";

                using (SQLiteCommand command = new SQLiteCommand(searchUser, connection))
                {
                    command.Parameters.AddWithValue("@Login", userLogin);
                    command.Parameters.AddWithValue("@Password", password);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _login = $"{reader["Login"]}";
                            _password = $"{reader["Password"]}";
                            _fio = $"{reader["FIO"]}";
                        }
                    }
                }
            }
        }

        public string LoginReturn()
        {
            return _login;
        }
        public string PasswordReturn()
        {
            return _password;
        }
        public string FIOReturn()
        {
            return _fio;
        }
        public void DataClear()
        {
            _login = "";
            _password = "";
            _fio = "";
        }
    }
}
