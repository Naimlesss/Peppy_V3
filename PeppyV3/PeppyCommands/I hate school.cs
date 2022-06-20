using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class I_hate_school : ModuleBase<SocketCommandContext>
    {
        public static string[] array = { "Don't eduhate, but educate", "No school is for fools", "If your illiterate how could you make your argumant legitemate", "Poor education is a bad foundation" };

        List<string> option = new List<string>(array);



        [Command("I hate school")]
        public async Task PingAsync()
        {
            Random r = new Random();
            int rnd = r.Next(array.Length);
            await ReplyAsync(option[rnd]);
        }
    }
}