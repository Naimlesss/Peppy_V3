using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class Yay : ModuleBase<SocketCommandContext>
    {
        [Command("Yay")]
        public async Task PingAsync()
        {

            await ReplyAsync("Yay~");
        }
    }
}
