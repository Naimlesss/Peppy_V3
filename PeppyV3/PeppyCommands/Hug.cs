using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class Hug : ModuleBase<SocketCommandContext>
    {
        public static string[] array = { "*pat pat*                                                                                                                                                                                                                                                  http://img.dailymail.co.uk/i/pix/2007/04_02/09penguinDM_468x638.jpg", "*pat pat*                                                                                                                                                                                                                                                  http://images2.fanpop.com/images/photos/7500000/hugs-anyone-penguins-7507650-1024-768.jpg", "*pat pat*                                                                                                                                                                                                                                                  http://img15.deviantart.net/a29f/i/2010/286/9/1/chancho___penguin_hug_by_neofox462-d30p2ft.jpg", "*pat pat*                                                                                                                                                                                                                                                                              https://cdn.discordapp.com/attachments/435509921031651340/436854049753661450/Hug.jpg", "*pat pat*                                                                                                                                                                                                                                    https://giphy.com/gifs/love-kawaii-hug-jMGxhWR7rtTNu", "*pat pat*                                                                                                                                                                                                                                                             https://giphy.com/gifs/penguin-emotional-grieving-8cFvoz1MBZLO0" };

        List<string> option = new List<string>(array);



        [Command(".p Hug")]
        public async Task PingAsync()
        {
            Random r = new Random();
            int rnd = r.Next(6);
            await ReplyAsync(option[rnd]);
        }
    }
}
