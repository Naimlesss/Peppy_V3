using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class Hi_Deven : ModuleBase<SocketCommandContext>
    {
        public static string[] array = { "Heya Deven", "Hey, big boss ^^", "It's the big boss o:", "Hey Deven, how are you :D"};

        List<string> option = new List<string>(array);



        [Command("Hi Deven")]
        public async Task PingAsync()
        {
            Random r = new Random();
            int rnd = r.Next(4);
            await ReplyAsync(option[rnd]);
        }
    }
}