using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class Woe : ModuleBase<SocketCommandContext>
    {
        [Command("Who's Woe")]
        public async Task PingAsync()
        {

            await ReplyAsync("A Marquis, He jokes a lot and sometimes he really scares me, but he is nice deep down ...I hope.");
        }
    }
}
