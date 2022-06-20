using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class TheBestSong : ModuleBase<SocketCommandContext>
    {
        [Command("Peppies Favorite Song")]
        public async Task PingAsync()
        {

            await ReplyAsync("https://www.youtube.com/watch?v=god7hAPv8f0");
        }
    }
}
