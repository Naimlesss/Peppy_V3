using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class Guzma : ModuleBase<SocketCommandContext>
    {
        [Command("Who's Stabby McTaco")]
        public async Task PingAsync()
        {

            await ReplyAsync("An Emperor, but a fun emperor always in the mood for some excitement. He does have an explosive side.");
        }
    }
}
