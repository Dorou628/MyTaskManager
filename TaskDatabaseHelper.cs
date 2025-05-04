using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTaskManager
{
    public static class TaskDatabaseHelper
    {
        private static string dbPath = "tasks.db";
        private static string connectionString = $"Data Source={dbPath};Version=3;";

        public static void InitializeDatabase()
        {
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
            }

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = @"
                CREATE TABLE IF NOT EXISTS Tasks (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Description TEXT,
                    Priority INTEGER,
                    ReminderTime TEXT,
                    CreateDate TEXT,
                    IsCompleted INTEGER
                );";
                new SQLiteCommand(sql, conn).ExecuteNonQuery();
            }
        }

        public static void SaveAllTasks(List<MyTask> tasks)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                new SQLiteCommand("DELETE FROM Tasks", conn).ExecuteNonQuery(); // 清空旧数据

                foreach (var task in tasks)
                {
                    var cmd = new SQLiteCommand(@"
                        INSERT INTO Tasks 
                        (Name, Description, Priority, ReminderTime, CreateDate, IsCompleted) 
                        VALUES (@Name, @Desc, @Pri, @Rem, @CreateDate, @IsDone)", conn);

                    cmd.Parameters.AddWithValue("@Name", task.Name);
                    cmd.Parameters.AddWithValue("@Desc", task.Description ?? "");
                    cmd.Parameters.AddWithValue("@Pri", (int)(task.Priority ?? PriorityLevel.Low));
                    cmd.Parameters.AddWithValue("@Rem", task.ReminderTime?.ToString("s")); // ISO 格式
                    cmd.Parameters.AddWithValue("@CreateDate", task.CreateDate.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@IsDone", task.IsCompleted ? 1 : 0);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        /*
        public static List<MyTask> GetAllTasks()
        {
            var tasks = new List<MyTask>();

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                var cmd = new SQLiteCommand("SELECT * FROM Tasks", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var task = new MyTask()
                        {
                            Description = reader["Description"].ToString(),
                            Priority = (PriorityLevel)Convert.ToInt32(reader["Priority"]),
                            IsCompleted = Convert.ToInt32(reader["IsCompleted"]) == 1,
                            CreateDate = DateTime.Parse(reader["CreateDate"].ToString())
                        };

                        string reminderStr = reader["ReminderTime"]?.ToString();
                        if (!string.IsNullOrEmpty(reminderStr))
                        {
                            task.ReminderTime = DateTime.Parse(reminderStr);
                        }

                        tasks.Add(task);
                    }
                }
            }

            return tasks;
        }
        */
    }
}
