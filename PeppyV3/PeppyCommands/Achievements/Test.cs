using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace BotPeppy
{

    

    public class Test : ModuleBase<SocketCommandContext>
    {
        public static string[] array = { "Boop", "Can't stop won't stop", "I'm on top of the world" };

        List<string> option = new List<string>(array);



        [Command("Lucio")]
        public async Task PingAsync()
        {
            Random r = new Random();
            int rnd = r.Next(3);
            await ReplyAsync(option[rnd]);
        }
    }
}
