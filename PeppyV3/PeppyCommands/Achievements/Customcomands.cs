using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using BotPeppy.UserProfile;
using NodaTime.Serialization.JsonNet;

namespace PeppyV3.PeppyCommands.Achievements
{
    public class Customcomands : ModuleBase<SocketCommandContext>
    {
        [Command("Don't judge me")]
        public async Task Oceanic()
        {
            var account = UserAccounts.GetAccount(Context.User);
            if (account.CustomCommandLvL <= 6) return;
            if (account.CustomCommandLvL >= 8) return;
            await Context.Channel.SendMessageAsync("https://cdn.discordapp.com/attachments/264803766350381057/490260016864165890/unknown.png");
        }


        [Command("Heil luxray")]
        public async Task Deven()
        {
            var account = UserAccounts.GetAccount(Context.User);
            if (account.CustomCommandLvL == 0) return;
            if (account.CustomCommandLvL >= 2) return;
            await Context.Channel.SendMessageAsync("AL HEIL DIE FÜRHER");
        }
    }
}
