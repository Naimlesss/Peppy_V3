using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class Send_Noots : ModuleBase<SocketCommandContext>
    {
        public static string[] array = { "http://funpeep.com/wp-content/uploads/2014/04/baby-penguin.jpg", "https://baby-animals.net/wp-content/gallery/Baby-penguin-wallpapers/Baby-penguin.jpg", "https://i.pinimg.com/736x/72/51/35/725135616a68b971ea39df984dbb6f1d.jpg", "http://i.dailymail.co.uk/i/pix/2015/12/13/08/2F477C6E00000578-3358025-image-a-2_1449997159358.jpg", "http://3.bp.blogspot.com/-uVYoqv4lvx0/VhuqykmI_yI/AAAAAAAAYek/aDZzvy0HUrE/s1600/funmozar-baby-penguin.jpg", "http://i.dailymail.co.uk/i/pix/2016/01/28/15/30A8DD4E00000578-0-image-a-3_1453994469179.jpg", "https://images2.onionstatic.com/clickhole/2075/16x9/1200.jpg" };

        List<string> option = new List<string>(array);



        [Command("Send noots")]
        public async Task PingAsync()
        {
            Random r = new Random();
            int rnd = r.Next(7);
            await ReplyAsync(option[rnd]);
        }
    }
}