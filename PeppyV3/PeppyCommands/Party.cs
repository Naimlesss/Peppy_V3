using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class Party : ModuleBase<SocketCommandContext>
    {
        [Command("Party time")]
        public async Task PingAsync()
        {

            await ReplyAsync("Whoop Whoop");
        }
    }
}
