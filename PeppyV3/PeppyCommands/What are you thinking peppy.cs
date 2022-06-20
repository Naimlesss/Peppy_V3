using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class What_are_you_thinking_peppy : ModuleBase<SocketCommandContext>
    {
        public static string[] array = { "I would really like some sushi right now", "The wifi here is terrible, anartic networks should up their game", "I wish I had hands, makes chatting online a whole lot easier", "So I heard some people choose to go swim in icey water, honestly i would choose a heated pool anyday", "If I'm a penguin, how did I learn english :thinking:", "What would a vegatarian penguin eat? There is only ice and water around here", "If you don't let thieves rob your house, then why do people let thoughts steal their joy?", "I wish i could fly, then no one would make fun of me anymore", "Why would god be human? I bet he's a majestic penguin." };

        List<string> option = new List<string>(array);



        [Command("What are you thinking Peppy")]
        public async Task PingAsync()
        {
            Random r = new Random();
            int rnd = r.Next(9);
            await ReplyAsync(option[rnd]);
        }
    }
}