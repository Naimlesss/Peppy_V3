using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class Food : ModuleBase<SocketCommandContext>
    {
        [Command("Food")]
        public async Task PingAsync()
        {

            await ReplyAsync("*Drooling over sushi*");
        }
    }
}
