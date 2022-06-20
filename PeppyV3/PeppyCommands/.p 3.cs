using Discord.Commands;
using Discord;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class p3 : ModuleBase<SocketCommandContext>
    {
        [Command(".p 3")]
        public async Task PingAsync()
        {
            EmbedBuilder builder = new EmbedBuilder();

            builder.AddField("What are you thinking Peppy", "I'll tell what i'm thinking, obviously")
                .AddField("Send noots", "I'll send noots. Everyone loves noots")
                .AddField(".p Cute", "Adorable gifs, of me and my friends mostly :3")
                .AddField("How are you feeling Peppy", "I'll answer the question :3")
                .AddField("Fun fact", "A fun fact just for you")
                .AddField(".p Achievements", "I will list the achievement commands")
                .WithColor(Color.Blue);

            await ReplyAsync("", false, builder.Build());
        }
    }
}
