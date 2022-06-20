using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class Staff2 : ModuleBase<SocketCommandContext>
    {
        [Command(".p 2")]
        public async Task PingAsync()
        {
            EmbedBuilder builder = new EmbedBuilder();

            builder.AddField("How are you Peppy", "I'll tell how I'm doing, obviously")
                .AddField(".p Weather", "Your most reliable scource of weather information")
                .AddField(".p Staff", "I'll explain a little about the staff on this server")
                .AddField(".p Pun", "some bad one liners are always fun")
                .AddField("Party time", "Whoop Whoop")
                .AddField(".p 3", "For even more")
                .WithColor(Color.Blue);

            await ReplyAsync("", false, builder.Build());
        }
    }
}
