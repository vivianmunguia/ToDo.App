using SQLite;
using System.Threading.Tasks;
using ToDo.App.Models;

namespace ToDo.App.Data
{
    public class DatabaseContext
    {
        public readonly SQLiteAsyncConnection Connection;
        public DatabaseContext(string dbPath)
        {
            Connection = new SQLiteAsyncConnection(dbPath);
            Connection.CreateTableAsync<ToDoItem>().Wait();
        }

        public async Task<int> InsertItemAsync(ToDoItem item)
        {
            return await Connection.InsertAsync(item);
        }
    }
}
