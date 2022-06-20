using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class SorryPeppy : ModuleBase<SocketCommandContext>
    {
        public static string[] array = { "Okay, I forgive you", "I accept your apoligy :3", "No harm done ^^" };

        List<string> option = new List<string>(array);



        [Command("Sorry Peppy")]
        public async Task PingAsync()
        {
            Random r = new Random();
            int rnd = r.Next(array.Length);
            await ReplyAsync(option[rnd]);
        }
    }
}