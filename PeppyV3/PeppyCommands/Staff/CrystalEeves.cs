using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class CrystalEeves : ModuleBase<SocketCommandContext>
    {
        [Command("Who's CrystalEevees")]
        public async Task PingAsync()
        {

            await ReplyAsync("A long time member. Eevee is a nice canadian girl and fun to talk to, but watch out she bites ;3");
        }
    }
}
