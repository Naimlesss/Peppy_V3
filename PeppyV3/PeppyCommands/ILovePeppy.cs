using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class Peppylove : ModuleBase<SocketCommandContext>
    {
        [Command("I love peppy")]
        public async Task PingAsync()
        {

            await ReplyAsync("I love you too :> https://giphy.com/gifs/love-happy-kiss-CK2cSZB5ilxRe");
        }
    }
}
