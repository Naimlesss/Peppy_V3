using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class Samantha : ModuleBase<SocketCommandContext>
    {
        public static string[] array = { "Hey Vaporeon ^^", "A fair day to you, Queen Vaporeon", "It's the Queen! YAY~", "Hi Vaporeon, how are you today!", "Oh Your majesty *bows*", "Hi vaporeon, I finished the drawing https://cdn.discordapp.com/attachments/471898295778934786/495611400341946379/image0.jpg", "https://cdn.discordapp.com/attachments/471898295778934786/510452276587003906/image0.jpg" };

        List<string> option = new List<string>(array);



        [Command("Hi Vaporeon")]
        public async Task PingAsync()
        {
            Random r = new Random();
            int rnd = r.Next(array.Length);
            await ReplyAsync(option[rnd]);
        }



        [Command("goodnight vaporeon")]
        public async Task Async()
        {

            await ReplyAsync("Goodnight Vaporeon, I hope you have a great sleep. https://cdn.discordapp.com/attachments/471898295778934786/495220179890995209/image0.jpg");
        }
    }
}