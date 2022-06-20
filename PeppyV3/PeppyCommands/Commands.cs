using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command(".p")]
        public async Task PingAsync()
        {
            EmbedBuilder builder = new EmbedBuilder();

            builder.AddField("Hi my name is peppy", "These are some things I respond to")
                .AddField(".p introduction", "i'll give you a short description of who I am")
                .AddField("Hi peppy", "I'll greet you back cause thats social")
                .AddField(".p Hug", "I give hugs :D")
                .AddField(".p Mad", "For when someone angers the pep")
                .AddField(".p 2", "Use .p 2 for more things i respond to")
                .WithColor(Color.Blue);

            await ReplyAsync("", false, builder.Build());
        }
    }
}
