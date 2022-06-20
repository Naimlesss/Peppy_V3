using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class Cute : ModuleBase<SocketCommandContext>
    {
        public static string[] array = { "https://giphy.com/gifs/baby-penguin-penguins-l3cAg07WMsXD2", "https://giphy.com/gifs/penguin-ice-RJL3WB6GLuNqM", "https://giphy.com/gifs/penguin-motivational-cute-funny-h59iqXVAai6DC", "https://giphy.com/gifs/funny-cute-BZmjcSFSNWPio", "https://giphy.com/gifs/cute-bunny-penguin-3o751Sq3f0eeLjQB0Y", "https://giphy.com/gifs/kkmm0GTOKFc2Y", "https://giphy.com/gifs/JygdeYZ8JiIs8", "https://giphy.com/gifs/penguins-critters-bYA4gjjr8QKqY", "https://giphy.com/gifs/penguin-b4OdBIqThh9Qs" };

        List<string> option = new List<string>(array);



        [Command(".p Cute")]
        public async Task PingAsync()
        {
            Random r = new Random();
            int rnd = r.Next(9);
            await ReplyAsync(option[rnd]);
        }
    }
}
