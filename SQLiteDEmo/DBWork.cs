using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;

namespace SQLiteDEmo
{
    internal class DBWork
    {
        
        static public string MakeDB(string _dbname = "test02")
        {
            string result = "Ошибка чтения данных...";
            //подключение к бд
            string path = $"Data Source={_dbname};";

            //инициализирующий запрос
            string init_db = "CREATE TABLE IF NOT EXISTS " +
                "Category " +
                "(id INTEGER  PRIMARY KEY AUTOINCREMENT, " +
                "Name VARCHAR);";
            //наполнение данными
            string init_data = "INSERT INTO " +
                "Category" +
                "(Name) " +
                "VALUES" +
                "('SportwatchWatch');";

            //просмотр данных
            string show_all_data = "SELECT * FROM Category;";
            SQLiteConnection conn = new SQLiteConnection(path);

            //создание команд, для последовательного выполнения на базе
            SQLiteCommand cmd01 = conn.CreateCommand();
            SQLiteCommand cmd02 = conn.CreateCommand();
            SQLiteCommand cmd03 = conn.CreateCommand();
            //команды
            cmd01.CommandText = init_db;
            cmd02.CommandText = init_data;
            cmd03.CommandText = show_all_data;
            //открытие соединения
            conn.Open();
            //выполнение запроса успех/не успех
            cmd01.ExecuteNonQuery();
            //cmd02.ExecuteNonQuery();
            //возврат
            var reader = cmd03.ExecuteReader();
            if (reader.HasRows)
            {
                result = " "; //обнуляем
                // reader.FieldCount - количество полей
                while (reader.Read())
                {
                    result += reader.GetValue(0).ToString();//метод возвращающий определенную колонку
                    result += " | ";
                    result += reader.GetValue(1).ToString();
                    result += "\n";
                }
            }
            conn.Close();
            return result;
        }
        static public void AddData(string _newCategoryInsert, 
            string _dbname = "test02")
        {
            string path = $"Data Source={_dbname};";
            using (SQLiteConnection conn = new SQLiteConnection(path))
            {
                SQLiteCommand cmd = new SQLiteCommand(conn);
                cmd.CommandText = _newCategoryInsert;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        static public DataSet Refresh (string _dbname = "test02")
        {
            DataSet result = new DataSet();
            string path = $"Data Source={_dbname};";
            string show_all_data = "SELECT * FROM Category;";
            using (SQLiteConnection conn = new SQLiteConnection(path))
            {
                //SQLiteCommand cmd = new SQLiteCommand(conn);
                //cmd.CommandText = show_all_data;
                //создание адаптера и наполнение данными
                conn.Open();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(show_all_data, conn);
                adapter.Fill(result);

            }
            return result;
        }
        
        static public void Save(DataTable dt, out string _query, string _dbname = "test02")
        {
            string path = $"Data Source={_dbname};"; //строка соединения
            string show_all_data = "SELECT * FROM Category;"; //необходимые данные
            using (SQLiteConnection conn = new SQLiteConnection(path)) 
            {
                conn.Open();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(show_all_data, conn); //создаем адаптер и указываем данные с соединением
                SQLiteCommandBuilder commandBuilder = new SQLiteCommandBuilder(adapter);
                adapter.Update(dt);
                _query = commandBuilder.GetUpdateCommand().CommandText; //
            }
        }



    }
}
