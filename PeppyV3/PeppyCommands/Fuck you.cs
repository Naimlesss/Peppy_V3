using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class Fuck_you : ModuleBase<SocketCommandContext>
    {
        [Command(".p Fuck you")]
        public async Task PingAsync()
        {

            await ReplyAsync("oh *hangs his head in sadness*                                                                                                                                                                                                                                                                                                                                                                                                        http://www.lynnlevinephotography.com/wp-content/gallery/animals/l1030833.jpg");
        }
    }
}
