using System;
using System.Collections.Generic;
using System.Text;
using GTANetworkAPI;

namespace server.commands
{
    class Classss1:Script
    {
        [Command("hi")]
        public void SayHi(Player player)
        {
            NAPI.Chat.SendChatMessageToPlayer(player, "Hello!");
        }

        
        
    }
}
