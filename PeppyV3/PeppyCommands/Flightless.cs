using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class Flightless : ModuleBase<SocketCommandContext>
    {
        [Command(".p Is Flightless")]
        public async Task PingAsync()
        {

            await ReplyAsync("Well atleast i don't poop on your head");
        }
    }
}
