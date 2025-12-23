using Microsoft.EntityFrameworkCore;
using TodoList.Domain;
using TodoList.Interfaces;

namespace TodoList.Data.Repositories
{
    public class TodoRepository(Database database) : ITodoRepository
    {
        private readonly Database _database = database;
        public async Task Add(TodoDTO todo)
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

        public async Task<List<TodoDTO>> FindAll()
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
