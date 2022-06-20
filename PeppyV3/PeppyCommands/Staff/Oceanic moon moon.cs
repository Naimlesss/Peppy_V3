using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class Oceanic_moon_moon : ModuleBase<SocketCommandContext>
    {
        [Command("Who's Oceanic Moon Moon")]
        public async Task PingAsync()
        {

            await ReplyAsync("A Duke, A dog, in the ocean, pretty sure he's just the staffs pet :3");
        }
    }
}
