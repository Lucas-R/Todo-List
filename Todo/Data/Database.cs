using Microsoft.EntityFrameworkCore;
using TodoList.Domain;

namespace TodoList.Data
{
    public class Database(DbContextOptions<Database> options) : DbContext(options)
    {
        public DbSet<Todo> Todos => Set<Todo>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Todo>(entity =>
            {
                entity.HasIndex(todo => todo.Code).IsUnique();

                entity.Property(todo => todo.Code).IsRequired().HasMaxLength(20);
            });
        }
    }
}
