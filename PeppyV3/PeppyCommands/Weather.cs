using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class Weather : ModuleBase<SocketCommandContext>
    {
        public static string[] array = { "Snow and oh yep more snow", "Cold", "Who knows, there could be a tornado for all I know", "Clear skies sunshine and a nice 20 degrees celsius, atleast somewhere in the world" };

        List<string> option = new List<string>(array);



        [Command(".p Weather")]
        public async Task PingAsync()
        {
            Random r = new Random();
            int rnd = r.Next(4);
            await ReplyAsync(option[rnd]);
        }
    }
}
