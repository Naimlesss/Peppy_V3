using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class Good_night : ModuleBase<SocketCommandContext>
    {
        public static string[] array = { "Don't let the bedbugs bite!", "Sleep tight :3", "Goodnight ^^", "Sweet dreams", "*yawn* I wish i could join you" };

        List<string> option = new List<string>(array);



        [Command("Good night")]
        public async Task PingAsync()
        {
            Random r = new Random();
            int rnd = r.Next(5);
            await ReplyAsync(option[rnd]);
        }
    }
}
