using TodoList.Interfaces;
using TodoList.Domain;
using TodoList.DTOs;

namespace TodoList.Services
{
    public class TodoService(ITodoRepository repository) : ITodoService
    {
        private readonly ITodoRepository _repository = repository;

        public async Task<TodoDTO> Create(string title)
        {
            Todo todo = new(title);

            await _repository.Add(todo);

            return new TodoDTO
            {
                Code = todo.Code,
                Title = todo.Title,
                Done = todo.Done,
                CreatedAt = todo.CreatedAt
            };
        }

        public async Task<List<TodoDTO>> FindAll()
        {
            List<Todo> todos = await _repository.FindAll();

            return [.. todos.Select(todo => new TodoDTO
            {
                Code = todo.Code,
                Title = todo.Title,
                Done = todo.Done,
                CreatedAt = todo.CreatedAt
            })];
        }
    }
}
