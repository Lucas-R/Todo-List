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

        [HttpGet("{code}")]
        public async Task<ActionResult<TodoDTO>>  FindOne(string code)
        {
            TodoDTO? todo = await _service.FindOne(code);

            if(todo is null)
                return NotFound(new { message = "Todo not found" });

            return todo;
        }

        [HttpPut("{code}")]
        public async Task<IActionResult> Update(string code, [FromBody] TodoUpdateDTO update)
        {
            TodoDTO? todo = await _service.Update(code, update);

            if (todo is null)
                return NotFound(new { message = "Todo not found" });

            return Ok(todo);
        }
    }
}
