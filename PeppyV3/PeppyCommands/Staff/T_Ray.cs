using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class T_Ray : ModuleBase<SocketCommandContext>
    {
        [Command("Who's T_Ray")]
        public async Task PingAsync()
        {

            await ReplyAsync("A Baron, Always up for a joke and a fantastic musician very good for a short armed tyrannosaur.");
        }
    }
}
