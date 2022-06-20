using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class TheLegendaryLuxray : ModuleBase<SocketCommandContext>
    {
        [Command("Who's TheLegendaryLuxray")]
        public async Task PingAsync()
        {

            await ReplyAsync("Luxray is the big boss of the server, he might hold all the power but he's still a friendly guy with a big heart and a joke here and there won't hurt");
        }
    }
}
