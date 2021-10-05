using System;
using GTANetworkAPI;
using RAGE;

namespace server.front
{
    class front
    {
        
        public class Connected : Events.Script
        {
            
            
            [RemoteEvent("OnPlayerLoginAttempt")]
            public void OnPlayerLoginAttempt(Player player, string username, string password)
            {
                NAPI.Util.ConsoleOutput($"[Login Attempt] Username {username} | Password: {password}");

                
                if (username == "Max" && password == "123")
                {
                    player.TriggerEvent("LoginResult", 1);
                }
                else player.TriggerEvent("LoginResult", 0);
            }
            

        } 
    } 
}
