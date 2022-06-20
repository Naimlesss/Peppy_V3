using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class TrueColours : ModuleBase<SocketCommandContext>
    {
        [Command("TrueColours")]
        public async Task PingAsync()
        {

            await ReplyAsync("The real reason the server mascot became a penguin has nothing to do with what oceanic claimed they meant. The reality is that penguins live in a communistic society, second to that they appear to be exaclty the same. The penguin is literally the perfect communistic animal. Oceanic wanted this to be the server mascott as part of his 5 year plan to create the perfect communistic society. <@260856700125315077>");
        }
    }
}
