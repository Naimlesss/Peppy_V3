using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class How_are_you : ModuleBase<SocketCommandContext>
    {
        public static string[] array = { "Great now that you are here!", "With you around, amazing :3", "Super happy exicited and hungry, so the same as always ^^", "Really in the mood for some fish", "I am great how are you ^^" };

        List<string> option = new List<string>(array);



        [Command("How are you peppy")]
        public async Task PingAsync()
        {
            Random r = new Random();
            int rnd = r.Next(5);
            await ReplyAsync(option[rnd]);
        }
    }
}