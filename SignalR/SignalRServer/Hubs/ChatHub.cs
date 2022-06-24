using Microsoft.AspNetCore.SignalR;

namespace SignalRServer.Hubs
{
    public class ChatHub :  Hub
    {
        public Task SendData(string user, string message)
        {
            return Clients.All.SendAsync("Publish Message", user, message);
        }
    }
}
