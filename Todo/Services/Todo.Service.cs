using TodoList.Domain;
using TodoList.Interfaces;

namespace TodoList.Services
{
    public class TodoService(ITodoRepository repository)
    {
        private readonly ITodoRepository _repository = repository;

        public async Task<TodoDTO> Create(string title)
        {
            TodoDTO todo = new()
            {
                Title = title,
            };

            await _repository.Add(todo);

            return todo;
        }

        public Task<List<TodoDTO>> FindAll()
        {
            return _repository.FindAll();
        }
    }
}
