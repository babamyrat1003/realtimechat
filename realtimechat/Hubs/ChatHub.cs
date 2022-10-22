﻿using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace realtimechat.Hubs
{
    public class ChatHub : Hub<IChatClient>
    {
        public async Task MessageSender(string user, string message)
        {
            await Clients.All.MessageReceiver(user, message);

        }
    }
}
