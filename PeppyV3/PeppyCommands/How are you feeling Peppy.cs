using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class How_are_you_feeling_peppy : ModuleBase<SocketCommandContext>
    {
        public static string[] array = { "Hungry, cold and tired. Yet still all worth it cause I get to talk to you", "Tired...               of not talking with you more :D", "A bit lonely, do you know the cure ;p", "In love...                 with sushi", "Fantastic, cause i have a friend that cares about me :3" };

        List<string> option = new List<string>(array);



        [Command("How are you feeling Peppy")]
        public async Task PingAsync()
        {
            Random r = new Random();
            int rnd = r.Next(5);
            await ReplyAsync(option[rnd]);
        }
    }
}
