using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class Killme : ModuleBase<SocketCommandContext>
    {
        [Command("Kill me")]
        public async Task PingAsync()
        {

            await ReplyAsync("Please don't D:");
        }
    }
}
