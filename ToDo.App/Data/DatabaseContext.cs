using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using ToDo.App.Models;

namespace ToDo.App.Data
{
    public class DatabaseContext
    {
        public SQLiteAsyncConnection Connection { get; set; }
        public DatabaseContext(string path)
        {
            Connection = new SQLiteAsyncConnection(path);
            Connection.CreateTableAsync<ToDoItem>().Wait();
        }
    }
}
