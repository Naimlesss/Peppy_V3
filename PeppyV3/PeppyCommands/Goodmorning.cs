using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class Goodmorning : ModuleBase<SocketCommandContext>
    {
        public static string[] array = { "Rise and shine", "Wakey wakey I have eggs and bakey :D", "Good morning ^^", "*Yawns* Hai", "Goodmorning, hope you slept well ^^" };

        List<string> option = new List<string>(array);



        [Command("Goodmorning")]
        public async Task PingAsync()
        {
            Random r = new Random();
            int rnd = r.Next(5);
            await ReplyAsync(option[rnd]);
        }
    }
}
