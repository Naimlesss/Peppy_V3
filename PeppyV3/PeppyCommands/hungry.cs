using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class Hungry : ModuleBase<SocketCommandContext>
    {
        [Command(".p hungry")]
        public async Task PingAsync()
        {

            await ReplyAsync("*belly rumbling*");
        }
    }
}
