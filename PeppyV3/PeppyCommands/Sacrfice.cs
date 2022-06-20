using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class Sacrifice : ModuleBase<SocketCommandContext>
    {
        [Command(".p Sacrifice")]
        public async Task PingAsync()
        {

            await ReplyAsync("Bad woe, no sacrificing penguin D:");
        }
    }
}
