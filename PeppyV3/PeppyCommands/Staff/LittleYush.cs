using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class LittleYush : ModuleBase<SocketCommandContext>
    {
        [Command("Who's LittleYush")]
        public async Task PingAsync()
        {

            await ReplyAsync("A long time member, I usually call him LittleShush cause he doesn't talk that much but he is a really nice guy :D");
        }
    }
}
