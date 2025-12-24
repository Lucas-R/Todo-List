using Microsoft.EntityFrameworkCore;
using TodoList.Interfaces;
using TodoList.Domain;
using TodoList.DTOs;

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

        public async Task<Todo?> FindOne(string code)
        {
            return await _database.Todos.AsNoTracking().FirstOrDefaultAsync(todo => todo.Code == code);
        }

        public async Task Update(Todo todo)
        {
            _database.Todos.Update(todo);
            await _database.SaveChangesAsync();
        }

        public async Task<bool> Delete (Todo todo)
        {
                try
                {
                    _database.Todos.Remove(todo);
                    await _database.SaveChangesAsync();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
        }
    }
}
