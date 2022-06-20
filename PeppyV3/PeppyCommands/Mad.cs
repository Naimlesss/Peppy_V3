using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class Mad : ModuleBase<SocketCommandContext>
    {
        public static string[] array = { "You anger the peng                                                                                                                                                                                                                                                   https://static.businessinsider.com/image/4ffcb8f8ecad04273c000019/image.jpg", "You anger the peng                                                                                                                                                                                                                                                   https://giphy.com/gifs/penguin-angry-adventure-time-LrXAkOxhUT1S0", "You anger the pep                                                                                                                                                                                                                                                https://giphy.com/gifs/slap-penguins-ewHSMEx2TtEo8", "You anger the pep                                                                                                                                                                                                                                                                  https://giphy.com/gifs/angry-animals-being-jerks-penguin-xMSBZQMHPKJRm", "You anger the pep                                                                                                                                                                                                                                                                                      http://fromthepoint.com/wp-content/uploads/2010/12/Angry-Penguin.png" };

        List<string> option = new List<string>(array);



        [Command(".p Mad")]
        public async Task PingAsync()
        {
            Random r = new Random();
            int rnd = r.Next(5);
            await ReplyAsync(option[rnd]);
        }
    }
}
