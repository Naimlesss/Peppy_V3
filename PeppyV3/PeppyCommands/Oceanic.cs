using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class Oceanic : ModuleBase<SocketCommandContext>
    {
        [Command(".p Oceanic")]
        public async Task PingAsync()
        {

            await ReplyAsync("https://www.soulseeds.com/wp-content/uploads/2013/09/penguin-asleep.jpg");
        }
    }
}
