using CMA.SignalR.API.SignalR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace CMA.SignalR.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IHubContext<MessageHub> _hubContext;

        public UserController(IHubContext<MessageHub> hubContext)
        {
            _hubContext = hubContext;
        }

        [HttpPost]
        [Route("new-user")]
        public async Task<IActionResult> GetAsync(string user)
        {
            await _hubContext.Clients.All.SendAsync("new-user", user);
            return Ok();
        }
    }
}