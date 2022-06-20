using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeppyV3.PeppyCommands.Staff
{
    public class Vaporeon : ModuleBase<SocketCommandContext>
    {
            [Command("Who's Queen Vaporeon")]
            public async Task PingAsync()
            {

                await ReplyAsync("A Viscountess, Queen Samantha is a sweet person who just happens to rule the oceans");
            }
        }
    }
