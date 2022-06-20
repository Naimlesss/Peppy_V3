using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class Levelup : ModuleBase<SocketCommandContext>
    {
        [Command("Level up")]
        public async Task PingAsync()
        {

            await ReplyAsync("Con*kweh*tulations");
        }
    }
}
