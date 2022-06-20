using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class Hello : ModuleBase<SocketCommandContext>
    {
        public static string[] array = { "*waves*", "Heya ^^", "Hi :>", "Hey, how are you :D", "Hoi" };

        List<string> option = new List<string>(array);



        [Command("Hello")]
        public async Task PingAsync()
        {
            Random r = new Random();
            int rnd = r.Next(5);
            await ReplyAsync(option[rnd]);
        }
    }
}