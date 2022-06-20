using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class Staff : ModuleBase<SocketCommandContext>
    {
        [Command(".p Staff")]
        public async Task PingAsync()
        {

            await ReplyAsync("There are seven staffmembers you can find a little information in Staff info Want to know more about them just say who's (staff members name)");
        }
    }
}
