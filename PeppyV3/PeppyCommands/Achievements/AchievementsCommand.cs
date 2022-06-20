using Discord.Commands;
using Discord;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class AchievementCommands : ModuleBase<SocketCommandContext>
    {
        [Command(".p Achievements")]
        public async Task PingAsync()
        {
            EmbedBuilder builder = new EmbedBuilder();

            builder.AddField(".p Level And XP Achievements", "Tag someone with @ behind the command to see their list")
                .AddField(".p Roles and Rank ", "Tag someone with @ behind the command to see their list")
                .AddField(".p XP Collecting Achievements", "Tag someone with @ behind the command to see their list")
                .AddField(".p Staff Achievements", "Tag someone with @ behind the command to see their list")
                .AddField(".p Special Achievements", "Tag someone with @ behind the command to see their list")
                .AddField(".p Timed Achievements", "Tag someone with @ behind the command to see their list")
                .AddField(".p (EnterCurrentMonth) Achievements", "Tag someone with @ behind the command to see their list")
                .WithColor(Color.Blue);

            await ReplyAsync("", false, builder.Build());
        }
    }
}
