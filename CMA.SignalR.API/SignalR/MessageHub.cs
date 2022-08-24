using Microsoft.AspNetCore.SignalR;

namespace CMA.SignalR.API.SignalR
{
    public class MessageHub : Hub
    {

        public override async Task OnConnectedAsync()
        {
            Console.WriteLine($"New connection: {Context.ConnectionId}");
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            Console.WriteLine($"Disconnecting: {Context.ConnectionId}");
            await base.OnDisconnectedAsync(exception);
        }
    }
}
