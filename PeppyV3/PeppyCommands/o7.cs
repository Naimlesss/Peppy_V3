using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class O7 : ModuleBase<SocketCommandContext>
    {
        [Command("o7")]
        public async Task PingAsync()
        {

            await ReplyAsync("Aye Aye o7");
        }
    }
}
