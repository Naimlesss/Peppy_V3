using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class Hi_Leafeon : ModuleBase<SocketCommandContext>
    {
        public static string[] array = { "Hey leafeon ^^", "A fair day to you, Princess Leafeon", "It's the Grand Princess! YAY~", "Hi Leafeon, how are you today!" };

        List<string> option = new List<string>(array);



        [Command("Hi Leafeon")]
        public async Task PingAsync()
        {
            Random r = new Random();
            int rnd = r.Next(array.Length);
            await ReplyAsync(option[rnd]);
        }
    }
}