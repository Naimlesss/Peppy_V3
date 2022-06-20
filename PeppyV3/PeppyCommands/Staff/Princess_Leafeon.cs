using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class Princess_Leafeon : ModuleBase<SocketCommandContext>
    {
        [Command("Who's Grand Princess Leafeon")]
        public async Task PingAsync()
        {

            await ReplyAsync("A Viscountess, She is the oldest sister of the Eeveelutions. She's really sweet and kind.");
        }
    }
}
