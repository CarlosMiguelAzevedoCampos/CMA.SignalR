//Set connection
using Microsoft.AspNetCore.SignalR.Client;

var hub = new HubConnectionBuilder()
               .WithUrl("http://localhost:5278/hubs")
               .WithAutomaticReconnect()
               .Build();

hub.On<string>("new-user", user =>
{
    Console.WriteLine(string.Format("New user added: {0}", user));
});

hub.StartAsync().GetAwaiter().GetResult();

Console.ReadKey();
