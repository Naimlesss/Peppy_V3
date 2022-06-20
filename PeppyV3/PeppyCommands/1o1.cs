using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class Unnamed : ModuleBase<SocketCommandContext>
    {
        [Command("1o1")]
        public async Task PingAsync()
        {
            
            await ReplyAsync("1o1   /                                                                                                                                                                                                                                                                                                                                                                                                                  1o1       __ ");
        }
    }
}
