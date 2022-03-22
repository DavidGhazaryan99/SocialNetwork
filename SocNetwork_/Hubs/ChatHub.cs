using Microsoft.AspNetCore.SignalR;
using SocNetwork_.Models;
using SocNetwork_.ViewModels;
using System.Threading.Tasks;

namespace SocNetwork_.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(Message message) =>
            await Clients.All.SendAsync("receiveMessage", message);
    }
}
