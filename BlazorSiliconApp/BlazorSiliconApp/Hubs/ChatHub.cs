using Microsoft.AspNetCore.SignalR;

namespace BlazorSiliconApp.ChatHuben;

public class ChatHub : Hub
{
    public async Task SendMessage( string user , string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}
































//{
//    public override Task OnConnectedAsync()
//    {
//        return base.OnConnectedAsync();
//    }

//    public override Task OnDisconnectedAsync(Exception? exception)
//    {
//        return base.OnDisconnectedAsync(exception);
//    }
//    public async Task Typing(string userName)
//    {
//        await Clients.Others.SendAsync("UserTyping", userName);
//    }

//    public async Task SendMessageToAll(string userName, string message, DateTime dateTime)
//    {
//        await Clients.All.SendAsync("ReceiveMessage", userName, message, dateTime);
//    }
//}

