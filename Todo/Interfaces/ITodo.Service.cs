using TodoList.DTOs;

namespace TodoList.Interfaces
{
    public interface ITodoService
    {
        Task<TodoDTO> Create(string title);
        Task<List<TodoDTO>> FindAll();
        Task<TodoDTO?> FindOne(string code);
        Task<TodoDTO?> Update(string code, TodoUpdateDTO update);
    }
}
