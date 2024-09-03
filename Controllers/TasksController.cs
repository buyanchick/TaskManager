using Microsoft.AspNetCore.Mvc;
using TaskManager.Repositories;

namespace TaskManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITaskRepo _repo;

        public TasksController(ITaskRepo repo)
        {
            _repo = repo;
        }

        [HttpGet("GetTasks")]
        public async Task<IActionResult> Get()
        {
            var tasks = await _repo.GetTasks();
            return Ok(tasks);
        }
    }
}
