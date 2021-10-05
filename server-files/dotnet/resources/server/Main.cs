using System;
using GTANetworkAPI;


namespace server
{
    public class Main : Script
    {
        

        [ServerEvent(Event.PlayerConnected)]
        public void OnPlayerConnected(Player player)
        {
            player.SendChatMessage("Welcome to our server!");
        }

        public Main()
        {
            Console.WriteLine("Pass3");
            return;
        }
    }
    
}
