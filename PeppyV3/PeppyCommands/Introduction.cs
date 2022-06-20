using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class Intoduction : ModuleBase<SocketCommandContext>
    {
        [Command(".p Introduction")]
        public async Task PingAsync()
        {

            await ReplyAsync("**Name:** Peppy                                                                                                                                                                                                                                                                                                                                                                                                                                                           **Species:** Emperor penguin                                                                                                                                                                                                                                                                                                                                                                                                                                                            **Introduction:** Hi! i'm Peppy, the happy curious little penguin that may be a bit goofy but loves a little attention. Hope we'll become friends :D . You can summon me with .p ");
        }
    }
}
