using TodoList.Domain;

namespace TodoList.Interfaces
{
    public interface ITodoRepository
    {
        Task Add(Todo todo);
        Task<List<Todo>> FindAll();
        Task<Todo?> FindOne(string code);
        Task Update(Todo update);
        Task<bool> Delete(Todo code);
    }
}
