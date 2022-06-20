using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class Shrek : ModuleBase<SocketCommandContext>
    {
        [Command(".p Shrek")]
        public async Task PingAsync()
        {

            await ReplyAsync("https://www.youtube.com/watch?v=5ZYgIrqELFw");
        }
    }
}
