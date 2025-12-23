using Microsoft.EntityFrameworkCore;
using TodoList.Domain;

namespace TodoList.Data
{
    public class Database(DbContextOptions<Database> options) : DbContext(options)
    {
        public DbSet<TodoDTO> Todos => Set<TodoDTO>();
    }
}
