using TodoList.Domain;

namespace TodoList.Interfaces
{
    public interface ITodoRepository
    {
        Task Add(TodoDTO todo);
        Task<List<TodoDTO>> FindAll();
    }
}
