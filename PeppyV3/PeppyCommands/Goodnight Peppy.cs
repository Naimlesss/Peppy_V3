using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class Goodnight : ModuleBase<SocketCommandContext>
    {
        [Command("Goodnight Peppy")]
        public async Task PingAsync()
        {

            await ReplyAsync("Finally                                                                                                                                                                                                                                                                         http://www.eveandersson.com/photos/antarctica/petermann-island-baby-gentoo-penguins-sleeping-large.jpg ");
        }
    }
}