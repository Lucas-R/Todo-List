using Microsoft.EntityFrameworkCore;
using TodoList.Interfaces;
using TodoList.Domain;

namespace TodoList.Data.Repositories
{
    public class TodoRepository(Database database) : ITodoRepository
    {
        private readonly Database _database = database;
        public async Task Add(Todo todo)
        {
            try
            {
                _database.Todos.Add(todo);
                await _database.SaveChangesAsync();
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public async Task<List<Todo>> FindAll()
        {
            try
            {
                return await _database.Todos.AsTracking().ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return [];
            }
        }
    }
}
