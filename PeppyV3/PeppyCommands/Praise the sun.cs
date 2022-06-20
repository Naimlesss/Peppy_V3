using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class Praise_the_sun : ModuleBase<SocketCommandContext>
    {
        [Command("Praise the sun")]
        public async Task PingAsync()
        {

            await ReplyAsync("<@260856700125315077> https://gabooshappytimeplace.files.wordpress.com/2008/10/happypenguin.jpg");
        }
    }
}
