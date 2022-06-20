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

namespace BotPeppy
{
    public class Bad_oceanic : ModuleBase<SocketCommandContext>
    {
        public static string[] array = { "Bad moon moon", "Bad dog, bad", "I'm disappointed Oceanic", "Oceanic! Behave!" };

        List<string> option = new List<string>(array);



        [Command("Sleep is for the weak")]
        public async Task PingAsync()
        {
            var account = UserAccounts.GetAccount(Context.User);
            if (account.CustomCommandLvL <= 6) return;
            if (account.CustomCommandLvL >= 8) return;
            Random r = new Random();
            int rnd = r.Next(array.Length);
            await ReplyAsync(option[rnd]);
        }
    }
}