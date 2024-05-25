namespace BackEnd.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TodoItems : ControllerBase
{
    // GET: api/TodoItems
    [HttpGet]
    public async Task<ActionResult<IEnumerable<TodoItem>>> GetTodoItems()
    {
        return NotFound();
    }

    // GET: api/TodoItems/5
    [HttpGet("{id}")]
    public async Task<ActionResult<TodoItem>> GetTodoItem(long id)
    {
        return NotFound();
    }

    // GET: api/TodoItems/complete
    [HttpGet("complete")]
    public async Task<ActionResult<IEnumerable<TodoItem>>> GetCompletedTodoItems()
    {
        return NotFound();
    }

    // PUT: api/TodoItems/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutTodoItem(long id, TodoItem todoItem)
    {
        return NotFound();
    }

    // POST: api/TodoItems
    [HttpPost]
    public async Task<ActionResult<TodoItem>> PostTodoItem(TodoItem todoItem)
    {
        return NotFound();
    }

    // DELETE: api/TodoItems/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTodoItem(long id)
    {
        return NotFound();
    }
}
