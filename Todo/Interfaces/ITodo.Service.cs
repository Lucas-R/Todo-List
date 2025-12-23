using TodoList.Domain;

namespace TodoList.Interfaces
{
    public interface ITodoService
    {
        Task<TodoDTO> Create(string title);
        Task<List<TodoDTO>> FindAll();
    }
}
