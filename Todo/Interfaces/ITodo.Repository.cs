using TodoList.Domain;

namespace TodoList.Interfaces
{
    public interface ITodoRepository
    {
        Task Add(Todo todo);
        Task<List<Todo>> FindAll();
    }
}
