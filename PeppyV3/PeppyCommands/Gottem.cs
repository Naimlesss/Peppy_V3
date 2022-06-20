using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class Gottem : ModuleBase<SocketCommandContext>
    {
        [Command("Gotem")]
        public async Task PingAsync()
        {

            await ReplyAsync("Gotem.peng");
        }
    }
}
