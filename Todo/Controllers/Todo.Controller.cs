using Microsoft.AspNetCore.Mvc;
using TodoList.Interfaces;
using TodoList.DTOs;

namespace TodoList.Controllers
{
    [ApiController]
    [Route("todos")]
    public class TodoController(ITodoService service) : Controller
    {
        private readonly ITodoService _service = service;

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] string title)
        {
            TodoDTO todo = await _service.Create(title);
            return Ok(todo);
        }

        [HttpGet]
        public async Task<IActionResult> FindAll()
        {
            return Ok(await _service.FindAll());
        }
    }
}
