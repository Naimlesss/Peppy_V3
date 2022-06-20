using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using BotPeppy.UserProfile;
using NodaTime.Serialization.JsonNet;

namespace BotPeppy
{
    public class SaveDataTest : ModuleBase<SocketCommandContext>
    {
        [Command(".p Level And XP Achievements")]
        public async Task MyXP()
        {
            var account = UserAccounts.GetAccount(Context.User);
            EmbedBuilder builder = new EmbedBuilder();

            builder.AddField("The level And XP Achievements", $"Status {account.Points} out of 24")
                .AddField("List Of Achievements", "https://docs.google.com/spreadsheets/d/1HPvxUT386WMBSPolLBsNUkScfHd3lnEleRXcM3qv1MU/edit?usp=sharing")
                .WithColor(Color.Blue);

            await Context.Channel.SendMessageAsync("", false, builder.Build());
        }

        [Command(".p Level And XP Achievements")]
        public async Task HisXP(IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            EmbedBuilder builder = new EmbedBuilder();

            builder.AddField("The level And XP Achievements", $"Status {account.Points} out of 24")
                .WithColor(Color.Blue);

            await Context.Channel.SendMessageAsync("", false, builder.Build());
        }





        [Command(".p Set Level And XP")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AddXP(uint LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Points = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"Achievements set at {account.Points}");
        }

        [Command(".p Set Level And XP")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AdXP(uint LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Points = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"Achievements of {user} set at {account.Points}");
        }





        [Command(".p Slow Farmer")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AddXP1()
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Points = 1;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"you have earned Getting started, and now you have {account.Points} of the 24 Achievements");
        }

        [Command(".p Slow Farmer")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AdXP1(IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Points = 1;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} has earned Getting started, and now has {account.Points} of the 24 Achievements");
        }





        [Command(".p Getting started")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AddXP2()
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Points = 2;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"you have earned Getting started, and now you have {account.Points} of the 24 Achievements");
        }

        [Command(".p Getting started")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AdXP2(IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Points = 2;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} has earned Getting started, and now has {account.Points} of the 24 Achievements");
        }





        [Command(".p XP For All")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AddXP3()
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Points = 4;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"you have earned XP For All, and now you have {account.Points} of the 24 Achievements");
        }

        [Command(".p XP For All")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AdXP3(IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Points = 4;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} has earned XP For All, and now has {account.Points} of the 24 Achievements");
        }





        [Command(".p Welcome to the Big Leagues")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AddXP4()
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Points = 5;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"you have earned Welcome to the Big Leagues, and now you have {account.Points} of the 24 Achievements");
        }

        [Command(".p Welcome to the Big Leagues")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AdXP4(IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Points = 5;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} has earned Welcome to the Big Leagues, and now has {account.Points} of the 24 Achievements");
        }





        [Command(".p double digits achieved")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AddXP5()
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Points = 3;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"you have earned Double digits achieved, and now you have {account.Points} of the 24 Achievements");
        }

        [Command(".p double digits achieved")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AdXP5(IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Points = 3;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} has earned Double digits achieved, and now has {account.Points} of the 24 Achievements");
        }





        [Command(".p XP doubler")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AddXP6()
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Points = 6;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"you have earned XP doubler, and now you have {account.Points} of the 24 Achievements");
        }

        [Command(".p XP doubler")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AdXP6(IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Points = 6;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} has earned XP doubler, and now has {account.Points} of the 24 Achievements");
        }





        [Command(".p One step down")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AddXP7()
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Points = 8;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"you have earned One step down, and now you have {account.Points} of the 24 Achievements");
        }

        [Command(".p One step down")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AdXP7(IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Points = 8;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} has earned One step down, and now has {account.Points} of the 24 Achievements");
        }






        [Command(".p Enter the Grinder")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AddXP8()
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Points = 7;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"you have earned Enter the Grinder, and now you have {account.Points} of the 24 Achievements");
        }

        [Command(".p Enter the Grinder")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AdXP8(IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Points = 7;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} has earned Enter the Grinder, and now has {account.Points} of the 24 Achievements");
        }





        [Command(".p High Tech Leveler")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AddXP10()
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Points = 10;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"you have earned High Tech Leveler, and now you have {account.Points} of the 24 Achievements");
        }

        [Command(".p High Tech Leveler")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AdXP10(IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Points = 10;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} has earned High Tech Leveler, and now has {account.Points} of the 24 Achievements");
        }





        [Command(".p You made it")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AddXP12()
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Points = 12;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"you have earned You made it, and now you have {account.Points} of the 24 Achievements");
        }

        [Command(".p You made it")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AdXP12(IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Points = 12;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} has earned You made it, and now has {account.Points} of the 24 Achievements");
        }





        [Command(".p Long time xp farmer")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AddXP9()
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Points = 9;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"you have earned Long time xp farmer, and now you have {account.Points} of the 24 Achievements");
        }

        [Command(".p Long time xp farmer")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AdXP9(IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Points = 9;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} has earned Long time xp farmer, and now has {account.Points} of the 24 Achievements");
        }





        [Command(".p The Big 5-0")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AddXP13()
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Points = 13;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"you have earned The Big 5-0, and now you have {account.Points} of the 24 Achievements");
        }

        [Command(".p The Big 5-0")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AdXP13(IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Points = 13;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} has earned The Big 5-0, and now has {account.Points} of the 24 Achievements");
        }





        [Command(".p Experience Master")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AddXP11()
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Points = 11;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"you have earned Experience Master, and now you have {account.Points} of the 24 Achievements");
        }

        [Command(".p Experience Master")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AdXP11(IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Points = 11;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} has earned Experience Master, and now has {account.Points} of the 24 Achievements");
        }





        [Command(".p Stepping up")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AddXP14()
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Points = 14;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"you have earned Stepping up, and now you have {account.Points} of the 24 Achievements");
        }

        [Command(".p Stepping up")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AdXP14(IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Points = 14;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} has earned Stepping up, and now has {account.Points} of the 24 Achievements");
        }





        [Command(".p A big jump")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AddXP15()
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Points = 15;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"you have earned A big jump, and now you have {account.Points} of the 24 Achievements");
        }

        [Command(".p Half way there")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AdXP15(IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Points = 15;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} has earned A big jump, and now has {account.Points} of the 24 Achievements");
        }





        [Command(".p A step in the right direction")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AddXP16()
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Points = 16;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"you have earned A step in the right direction, and now you have {account.Points} of the 24 Achievements");
        }

        [Command(".p A step in the right direction")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AdXP16(IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Points = 16;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} has earned A step in the right direction, and now has {account.Points} of the 24 Achievements");
        }





        [Command(".p Half way there")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AddXP17()
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Points = 17;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"you have earned Half way there, and now you have {account.Points} of the 24 Achievements");
        }

        [Command(".p Half way there")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AdXP17(IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Points = 17;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} has earned Half way there, and now has {account.Points} of the 24 Achievements");
        }





        [Command(".p A leap, A bound, and a skip")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AddXP18()
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Points = 18;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"you have earned A leap, A bound, and a skip, and now you have {account.Points} of the 24 Achievements");
        }

        [Command(".p A leap, A bound, and a skip")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AdXP18(IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Points = 18;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} has earned A leap, A bound, and a skip, and now has {account.Points} of the 24 Achievements");
        }





        [Command(".p Big earner")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AddXP19()
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Points = 20;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"you have earned Big earner, and now you have {account.Points} of the 24 Achievements");
        }

        [Command(".p Big earner")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AdXP19(IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Points = 20;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} has earned Big earner, and now has {account.Points} of the 24 Achievements");
        }





        [Command(".p Master grinder")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AddXP20()
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Points = 19;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"you have earned Master grinder, and now you have {account.Points} of the 24 Achievements");
        }

        [Command(".p Big earner")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AdXP20(IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Points = 19;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} has earned Master grinder, and now has {account.Points} of the 24 Achievements");
        }





        [Command(".p Extreme Leveler")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AddXP21()
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Points = 21;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"you have earned Extreme Leveler, and now you have {account.Points} of the 24 Achievements");
        }

        [Command(".p Extreme Leveler")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AdXP21(IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Points = 21;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} has earned Extreme Leveler, and now has {account.Points} of the 24 Achievements");
        }





        [Command(".p You’re the insane one")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AddXP22()
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Points = 22;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"you have earned You’re the insane one, and now you have {account.Points} of the 24 Achievements");
        }

        [Command(".p You’re the insane one")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AdXP22(IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Points = 22;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} has earned You’re the insane one, and now has {account.Points} of the 24 Achievements");
        }





        [Command(".p Top of the Tech tree")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AddXP23()
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Points = 23;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"you have earned Top of the Tech tree, and now you have {account.Points} of the 24 Achievements");
        }

        [Command(".p Top of the Tech tree")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AdXP23(IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Points = 23;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} has earned Top of the Tech tree, and now has {account.Points} of the 24 Achievements");
        }





        [Command(".p A Mad Lad")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AddXP24()
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Points = 24;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"you have earned A Mad Lad, and now you have {account.Points} of the 24 Achievements");
        }

        [Command(".p A Mad Lad")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task AdXP24(IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Points = 24;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} has earned A Mad Lad, and now has {account.Points} of the 24 Achievements");
        }





        [Command(".p One down many to go")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch1(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Ach1 = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned One down many to go");
        }

        [Command(".p One down many to go")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch1B(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Ach1 = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned One down many to go");
        }





        [Command(".p Colorinator")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch2(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Colorinator = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned Colorinator");
        }

        [Command(".p Colorinator")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch2(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Colorinator = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned Colorinator");
        }





        [Command(".p Two times the winner")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch3(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.TwoTimesTheWinner = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned Two times the winner");
        }

        [Command(".p Two times the winner")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch3(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.TwoTimesTheWinner = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned Two times the winner");
        }





        [Command(".p Third Times Charm")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch4(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.ThirdTimesCharm = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned Third Times Charm");
        }

        [Command(".p Third Times Charm")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch4(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.ThirdTimesCharm = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned Third Times Charm");
        }





        [Command(".p Team 10")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch5(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Team10 = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned Team 10");
        }

        [Command(".p Team 10")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch5(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Team10 = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned Team 10");
        }





        [Command(".p 3rd place inbound")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch6(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.ThirdPlaceInbound = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned 3rd place inbound");
        }

        [Command(".p 3rd place inbound")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch6(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.ThirdPlaceInbound = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned 3rd place inbound");
        }





        [Command(".p Top 5")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch7(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Top5 = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned Top 5");
        }

        [Command(".p Top 5")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch7(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Top5 = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned Top 5");
        }





        [Command(".p King of The Hill")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch8(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.KingOfTheHill = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned King of The Hill");
        }

        [Command(".p King of The Hill")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch8(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.KingOfTheHill = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned King of The Hill");
        }





        [Command(".p Roles and Rank")]
        public async Task MyAch1()
        {
            var account = UserAccounts.GetAccount(Context.User);

            EmbedBuilder builder = new EmbedBuilder();

            builder.AddField("One down many to go", $"Status {account.Ach1}")
                .AddField("Colorinator", $"Status {account.Colorinator}")
                .AddField("King of The Hill", $"Status {account.KingOfTheHill}")
                .AddField("Two Times The Winner", $"Status {account.TwoTimesTheWinner}")
                .AddField("Third Times Charm", $"Status {account.ThirdTimesCharm}")
                .AddField("3rd place inbound", $"Status {account.ThirdPlaceInbound}")
                .AddField("Top 5", $"Status {account.Top5}")
                .AddField("Team 10", $"Status {account.Team10}")
                .WithColor(Color.Blue);

            await Context.Channel.SendMessageAsync("", false, builder.Build());
        }

        [Command(".p Roles and Rank")]
        public async Task MyAch1b(IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);

            EmbedBuilder builder = new EmbedBuilder();

            builder.AddField("One down many to go", $"Status {account.Ach1}")
                .AddField("Colorinator", $"Status {account.Colorinator}")
                .AddField("King of The Hill", $"Status {account.KingOfTheHill}")
                .AddField("Two Times The Winner", $"Status {account.TwoTimesTheWinner}")
                .AddField("Third Times Charm", $"Status {account.ThirdTimesCharm}")
                .AddField("3rd place inbound", $"Status {account.ThirdPlaceInbound}")
                .AddField("Top 5", $"Status {account.Top5}")
                .AddField("Team 10", $"Status {account.Team10}")
                .WithColor(Color.Blue);

            await Context.Channel.SendMessageAsync("", false, builder.Build());
        }





        [Command(".p Power grinding")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAh1(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.PowerGrinding = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned Power grinding");
        }

        [Command(".p Power grinding")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAc1B(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.PowerGrinding = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned Power grinding");
        }





        [Command(".p Setting the bar high")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAc2(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.SettingTheBarHigh = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned Setting the bar high");
        }

        [Command(".p Setting the bar high")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAc2(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.SettingTheBarHigh = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned Setting the bar high");
        }





        [Command(".p Setting goals")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAc3(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.SettingGoals = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned Setting goals");
        }

        [Command(".p Setting goals")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAc3(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.SettingGoals = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned Setting goals");
        }





        [Command(".p Talkative")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAc4(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Talkative = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned Talkative");
        }

        [Command(".p Talkative")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAc4(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Talkative = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned Talkative");
        }





        [Command(".p Grind, Grind and Grind")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAc5(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.GrindGrindAndGrind = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned Grind, Grind and Grind");
        }

        [Command(".p Grind, Grind and Grind")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAc5(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.GrindGrindAndGrind = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned Grind, Grind and Grind");
        }




        [Command(".p XP Collecting Achievements")]
        public async Task MyAc1()
        {
            var account = UserAccounts.GetAccount(Context.User);

            EmbedBuilder builder = new EmbedBuilder();

            builder.AddField("Power grinding", $"Status {account.PowerGrinding}")
                .AddField("Setting the bar high", $"Status {account.SettingTheBarHigh}")
                .AddField("Setting goals", $"Status {account.SettingGoals}")
                .AddField("Talkative", $"Status {account.Talkative}")
                .WithColor(Color.Blue);

            await Context.Channel.SendMessageAsync("", false, builder.Build());
        }

        [Command(".p XP Collecting Achievements")]
        public async Task MyAc1b(IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);

            EmbedBuilder builder = new EmbedBuilder();

            builder.AddField("Power grinding", $"Status {account.PowerGrinding}")
                .AddField("Setting the bar high", $"Status {account.SettingTheBarHigh}")
                .AddField("Setting goals", $"Status {account.SettingGoals}")
                .AddField("Talkative", $"Status {account.Talkative}")
                .WithColor(Color.Blue);

            await Context.Channel.SendMessageAsync("", false, builder.Build());
        }





        [Command(".p Part of the inner circle")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch9(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.TheKnightOfTheRoundTable = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned Part of the inner circle");
        }

        [Command(".p Part of the inner circle")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch9(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.TheKnightOfTheRoundTable = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned Part of the inner circle");
        }





        [Command(".p Highest Of The Commoners")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch0(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.EarlGreyTea = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned Highest Of The Commoners");
        }

        [Command(".p Highest Of The Commoners")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch0(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.EarlGreyTea = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned Highest Of The Commoners");
        }





        [Command(".p Assigning The Peasentry")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch10(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.TheDukeOfDiscord = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned Assigning The Peasentry");
        }

        [Command(".p Assigning The Peasentry")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch10(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.TheDukeOfDiscord = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned Assigning The Peasentry");
        }





        [Command(".p Royalty Has Arrived")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch11(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.YourKingHasArrived = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned Royalty Has Arrived");
        }

        [Command(".p Royalty Has Arrived")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch11(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.YourKingHasArrived = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned Royalty Has Arrived");
        }





        [Command(".p All Shall Bow To You")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch12(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.EmperorAtYourService = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned All Shall Bow To You");
        }

        [Command(".p All Shall Bow To You")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch12(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.EmperorAtYourService = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned All Shall Bow To You");
        }





        [Command(".p Emperor at your service")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch13(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.EmperorAtYourService = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned Emperor at your service");
        }

        [Command(".p Emperor at your service")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch13(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.EmperorAtYourService = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned Emperor at your service");
        }





        [Command(".p Staff Achievements")]
        public async Task MyAch3()
        {
            var account = UserAccounts.GetAccount(Context.User);

            EmbedBuilder builder = new EmbedBuilder();

            builder.AddField("Part of the inner circle", $"Status {account.TheKnightOfTheRoundTable}")
                .AddField("Highest Of The Commoners", $"Status {account.EarlGreyTea}")
                .AddField("Assigning The Peasentry", $"Status {account.TheDukeOfDiscord}")
                .AddField("Royalty Has Arrived", $"Status {account.YourKingHasArrived}")
                .AddField("All Shall Bow To You", $"Status {account.EmperorAtYourService}")
                .WithColor(Color.Blue);

            await Context.Channel.SendMessageAsync("", false, builder.Build());
        }

        [Command(".p Staff Achievements")]
        public async Task MyAch3(IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);

            EmbedBuilder builder = new EmbedBuilder();

            builder.AddField("Part of the inner circle", $"Status {account.TheKnightOfTheRoundTable}")
                 .AddField("Highest Of The Commoners", $"Status {account.EarlGreyTea}")
                 .AddField("Assigning The Peasentry", $"Status {account.TheDukeOfDiscord}")
                 .AddField("Royalty Has Arrived", $"Status {account.YourKingHasArrived}")
                 .AddField("All Shall Bow To You", $"Status {account.EmperorAtYourService}")
                 .WithColor(Color.Blue);

            await Context.Channel.SendMessageAsync("", false, builder.Build());
        }





        [Command(".p Peppies Friend")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch14(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.PeppiesFriend = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned Peppies Friend");
        }

        [Command(".p Peppies Friend")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch14(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.PeppiesFriend = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned Peppies Friend");
        }





        [Command(".p Born to lead")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch15(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Borntolead = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned Born to lead");
        }

        [Command(".p Born to lead")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch15(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Borntolead = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned Born to lead");
        }





        [Command(".p A Refined Taste")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch16(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.ARefinedTaste = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned A Refined Taste");
        }

        [Command(".p A Refined Taste")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch16(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.ARefinedTaste = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned A Refined Taste");
        }





        [Command(".p Gotem.Dsa")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch17(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.gottemDsa = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned Gotem.Dsa");
        }

        [Command(".p Gotem.Dsa")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch17(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.gottemDsa = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned Gotem.Dsa");
        }





        [Command(".p Here comes the cavalry")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch18(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Herecomesthecavalry = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned Here comes the cavalry");
        }

        [Command(".p Here comes the cavalry")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch18(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Herecomesthecavalry = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned Here comes the cavalry");
        }





        [Command(".p A Fresh Start")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch19(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.AFreshStart = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned A Fresh Start");
        }

        [Command(".p A Fresh Start")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch19(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.AFreshStart = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned A Fresh Start");
        }





        [Command(".p You Get A Gold Star")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch20(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.YouGetAGoldStar = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned You Get A Gold Star");
        }

        [Command(".p You Get A Gold Star")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch20(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.YouGetAGoldStar = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned You Get A Gold Star");
        }







        [Command(".p Quotable")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch20B(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Quotable = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned Quotable");
        }

        [Command(".p Quotable")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch20B(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Quotable = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned Quotable");
        }





        [Command(".p Special Achievements")]
        public async Task MyAch4()
        {
            var account = UserAccounts.GetAccount(Context.User);

            EmbedBuilder builder = new EmbedBuilder();

            builder.AddField("Peppies Friend", $"Status {account.PeppiesFriend}")
                .AddField("Born To Lead", $"Status {account.Borntolead}")
                .AddField("A Refined Taste", $"Status {account.ARefinedTaste}")
                .AddField("Gotem.Dsa", $"Status {account.gottemDsa}")
                .AddField("Here Comes The Cavalry", $"Status {account.Herecomesthecavalry}")
                .AddField("A Fresh Start", $"Status {account.AFreshStart}")
                .AddField("You Get A Gold Star", $"Status {account.YouGetAGoldStar}")
                .AddField("Quotable", $"Status {account.Quotable}")
                .WithColor(Color.Blue);

            await Context.Channel.SendMessageAsync("", false, builder.Build());
        }

        [Command(".p Special Achievements")]
        public async Task MyAch4(IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);

            EmbedBuilder builder = new EmbedBuilder();

            builder.AddField("Peppies Friend", $"Status {account.PeppiesFriend}")
                .AddField("Born To Lead", $"Status {account.Borntolead}")
                .AddField("A Refined Taste", $"Status {account.ARefinedTaste}")
                .AddField("Gotem.Dsa", $"Status {account.gottemDsa}")
                .AddField("Here Comes The Cavalry", $"Status {account.Herecomesthecavalry}")
                .AddField("A Fresh Start", $"Status {account.AFreshStart}")
                .AddField("You Get A Gold Star", $"Status {account.YouGetAGoldStar}")
                .AddField("Quotable", $"Status {account.Quotable}")
                .WithColor(Color.Blue);

            await Context.Channel.SendMessageAsync("", false, builder.Build());
        }





        [Command(".p Anniversary")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch21(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Anniversary = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned Anniversary");
        }

        [Command(".p Anniversary")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch21(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Anniversary = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned Anniversary");
        }





        [Command(".p Party Time")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch22(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.PartyTime = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned Party Time");
        }

        [Command(".p Party Time")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch22(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.PartyTime = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned Party Time");
        }





        [Command(".p Goodboy")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch23(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Goodboy = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned Goodboy");
        }

        [Command(".p Goodboy")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch23(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Goodboy = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned Goodboy");
        }





        [Command(".p Kind Heart")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch24(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.KindHeart = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned Kind Heart");
        }

        [Command(".p Kind Heart")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch24(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.KindHeart = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned Kind Heart");
        }





        [Command(".p Kind Soul")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch25(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.KindSoul = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned Kind Soul");
        }

        [Command(".p Kind Soul")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch25(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.KindSoul = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned Kind Soul");
        }





        [Command(".p A True Angel")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch26(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Atrueangel = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned A True Angel");
        }

        [Command(".p A True Angel")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch26(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Atrueangel = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned A True Angel");
        }





        [Command(".p A tight squeeze")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch36(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.ATightSqueeze = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned A tight squeeze");
        }

        [Command(".p A tight squeeze")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch36(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.ATightSqueeze = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned A tight squeeze");
        }




        [Command(".p Timed Achievements")]
        public async Task MyAch5()
        {
            var account = UserAccounts.GetAccount(Context.User);

            EmbedBuilder builder = new EmbedBuilder();

            builder.AddField("Anniversary", $"Status {account.Anniversary}")
                .AddField("Party Time", $"Status {account.PartyTime}")
                .AddField("Goodboy", $"Status {account.Goodboy}")
                .AddField("Kind Heart", $"Status {account.KindHeart}")
                .AddField("Kind Soul", $"Status {account.KindSoul}")
                .AddField("A True Angel", $"Status {account.Atrueangel}")
                .AddField("Grind, Grind and Grind", $"Status {account.GrindGrindAndGrind}")
                .AddField("A tight squeeze", $"Status {account.ATightSqueeze}")
                .WithColor(Color.Blue);

            await Context.Channel.SendMessageAsync("", false, builder.Build());
        }

        [Command(".p Timed Achievements")]
        public async Task MyAch5(IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);

            EmbedBuilder builder = new EmbedBuilder();

            builder.AddField("Anniversary", $"Status {account.Anniversary}")
                .AddField("Party Time", $"Status {account.PartyTime}")
                .AddField("Goodboy", $"Status {account.Goodboy}")
                .AddField("Kind Heart", $"Status {account.KindHeart}")
                .AddField("Kind Soul", $"Status {account.KindSoul}")
                .AddField("A True Angel", $"Status {account.Atrueangel}")
                .AddField("Grind, Grind and Grind", $"Status {account.GrindGrindAndGrind}")
                .AddField("A tight squeeze", $"Status {account.ATightSqueeze}")
                .WithColor(Color.Blue);

            await Context.Channel.SendMessageAsync("", false, builder.Build());
        }





        [Command(".p You’re a wizard Harry")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch27(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.YoureawizardHarry = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned You’re a wizard Harry");
        }

        [Command(".p You’re a wizard Harry")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch27(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.YoureawizardHarry = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned You’re a wizard Harry");
        }
        





        [Command(".p 10 points for Griffindor")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch29(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Tenpointsforgriffindor = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned 10 points for Griffindor");
        }

        [Command(".p 10 points for Griffindor")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch29(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Tenpointsforgriffindor = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned 10 points for Griffindor");
        }





        [Command(".p Why are they all staring")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch30(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Whyaretheyallstaring = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned Why are they all staring");
        }

        [Command(".p Why are they all staring")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch30(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Whyaretheyallstaring = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned Why are they all staring");
        }





        [Command(".p Hogwarts will always be your home")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch31(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Hogwartswillalwaysbeyourhome = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned Hogwarts will always be your home");
        }

        [Command(".p Hogwarts will always be your home")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch31(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Hogwartswillalwaysbeyourhome = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned Hogwarts will always be your home");
        }





        [Command(".p July Achievements")]
        public async Task MyAch6()
        {
            var account = UserAccounts.GetAccount(Context.User);

            EmbedBuilder builder = new EmbedBuilder();

            builder.AddField("You’re a wizard Harry", $"Status {account.YoureawizardHarry}")
                .AddField("10 points for Griffindor", $"Status {account.Tenpointsforgriffindor}")
                .AddField("Why are they all staring", $"Status {account.Whyaretheyallstaring}")
                .AddField("Hogwarts will always be your home", $"Status {account.Hogwartswillalwaysbeyourhome}")
                .WithColor(Color.Blue);

            await Context.Channel.SendMessageAsync("", false, builder.Build());
        }

        [Command(".p July Achievements")]
        public async Task MyAch6(IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);

            EmbedBuilder builder = new EmbedBuilder();

            builder.AddField("You’re a wizard Harry", $"Status {account.YoureawizardHarry}")
                .AddField("10 points for Griffindor", $"Status {account.Tenpointsforgriffindor}")
                .AddField("Why are they all staring", $"Status {account.Whyaretheyallstaring}")
                .AddField("Hogwarts will always be your home", $"Status {account.Hogwartswillalwaysbeyourhome}")
                .WithColor(Color.Blue);

            await Context.Channel.SendMessageAsync("", false, builder.Build());
        }





        [Command(".p So you do have ears")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch32(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.soyoudohaveears = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned So you do have ears");
        }

        [Command(".p So you do have ears")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch32(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.soyoudohaveears = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned So you do have ears");
        }





        [Command(".p Spotify premium")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch33(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Spotifypremium = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned Spotify premium");
        }

        [Command(".p Spotify premiums")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch33(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Spotifypremium = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned Spotify premium");
        }





        [Command(".p Music Maniac")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch34(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.MusicManiac = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned Music Maniac");
        }

        [Command(".p Music Maniac")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch34(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.MusicManiac = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned Music Maniac");
        }





        [Command(".p  Your single went plat")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch35(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Yoursinglewentplat = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned Your single went plat");
        }

        [Command(".p Music Maniac")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch35(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Yoursinglewentplat = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned Your single went plat");
        }





        [Command(".p June Achievements")]
        public async Task MyAch7()
        {
            var account = UserAccounts.GetAccount(Context.User);

            EmbedBuilder builder = new EmbedBuilder();

            builder.AddField("So you do have ears", $"Status {account.soyoudohaveears}")
                .AddField("Spotify premium", $"Status {account.Spotifypremium}")
                .AddField("Music Maniac", $"Status {account.MusicManiac}")
                .AddField("Your single went plat", $"Status {account.Yoursinglewentplat}")
                .WithColor(Color.Blue);

            await Context.Channel.SendMessageAsync("", false, builder.Build());
        }

        [Command(".p June Achievements")]
        public async Task MyAch7(IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);

            EmbedBuilder builder = new EmbedBuilder();

            builder.AddField("So you do have ears", $"Status {account.soyoudohaveears}")
                .AddField("Spotify premium", $"Status {account.Spotifypremium}")
                .AddField("Music Maniac", $"Status {account.MusicManiac}")
                .AddField("Your single went plat", $"Status {account.Yoursinglewentplat}")
                .WithColor(Color.Blue);

            await Context.Channel.SendMessageAsync("", false, builder.Build());
        }





        [Command(".p Believer")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch39(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Believer = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned Believer");
        }

        [Command(".p Believer")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch39(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Believer = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned Believer");
        }





        [Command(".p Priest")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch40(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Priest = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned Priest");
        }

        [Command(".p Priest")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch40(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Priest = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned Priest");
        }





        [Command(".p Demi-God")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch41(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.DemiGod = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned Demi-god");
        }

        [Command(".p Demi-God")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch41(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.DemiGod = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned demi-god");
        }





        [Command(".p Divinity")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch42(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Divinity = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"You earned Divinity");
        }

        [Command(".p Divinity")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task SetAch42(string LevelAc, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Divinity = LevelAc;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} earned Divinity");
        }





        [Command(".p May Achievements")]
        public async Task MyAch8()
        {
            var account = UserAccounts.GetAccount(Context.User);

            EmbedBuilder builder = new EmbedBuilder();

            builder.AddField("Believer", $"Status {account.Believer}")
                .AddField("Priest", $"Status {account.Priest}")
                .AddField("Demi-God", $"Status {account.DemiGod}")
                .AddField("Divinity", $"Status {account.Divinity}")
                .WithColor(Color.Blue);

            await Context.Channel.SendMessageAsync("", false, builder.Build());
        }

        [Command(".p May Achievements")]
        public async Task MyAch8(IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);

            EmbedBuilder builder = new EmbedBuilder();

            builder.AddField("Believer", $"Status {account.Believer}")
               .AddField("Priest", $"Status {account.Priest}")
               .AddField("Demi-God", $"Status {account.DemiGod}")
               .AddField("Divinity", $"Status {account.Divinity}")
               .WithColor(Color.Blue);

            await Context.Channel.SendMessageAsync("", false, builder.Build());
        }





        [Command(".Money")]
        public async Task Count(IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            UserAccounts.SaveAccount();
            EmbedBuilder builder = new EmbedBuilder();
            builder.AddField($"Balance", $" {user.Mention} has {account.XP} {account.Currency}")
                .WithColor(Color.Blue);

            await Context.Channel.SendMessageAsync("", false, builder.Build());
        }


        [Command(".Money")]
        public async Task Count()
        {
            var account = UserAccounts.GetAccount(Context.User);
            UserAccounts.SaveAccount();
            EmbedBuilder builder = new EmbedBuilder();
            builder.AddField($"Balance", $" {Context.User.Mention} has {account.XP} {account.Currency}")
                .WithColor(Color.Blue);

            await Context.Channel.SendMessageAsync("", false, builder.Build());
        }

        [Command(".p Award")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task Count(uint Number, IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.XP += Number ; 
            UserAccounts.SaveAccount();
            EmbedBuilder builder = new EmbedBuilder();

            builder.AddField("Currency awarded", $"{user.Mention} has received {Number} {account.Currency} and now has {account.XP} {account.Currency} total")
                .WithColor(Color.Blue);

            await Context.Channel.SendMessageAsync("", false, builder.Build());
            
        }

        [Command(".p Points Reset")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task CountReset(IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.XP = 0;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} points have been reset to {account.XP}");
        }





        [Command(".p Give")]
        public async Task Payment(uint LevelAc, IGuildUser user)
        {
            {
            var account = UserAccounts.GetAccount(Context.User);
            account.XP -= LevelAc;
            UserAccounts.SaveAccount(); }

            var Receiver = UserAccounts.GetAccount((SocketUser)user);
            Receiver.XP += LevelAc;
            UserAccounts.SaveAccount();
            

            EmbedBuilder builder = new EmbedBuilder();

            builder.AddField("Transaction Complete", $" {Context.User.Mention} has paid {user.Mention} {LevelAc} {Receiver.Currency}")
                .WithColor(Color.Blue);

            await Context.Channel.SendMessageAsync("", false, builder.Build());
        }

        [Command("A new generation of music has been created for you,")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task Levels(IGuildUser user, string Boop, string a, string b, string c, string d, string e, string f, string g, string h, string i, string j, string k, string l, string m, string n, string o, string p )
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Level += 1;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync("");
        }

        [Command("Welcome to Hogwarts School of Witchcraft and Wizardry,")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task Levels2(IGuildUser user, string Boop, string a, string b, string c, string d, string e, string f, string g, string h, string i, string j, string k, string l, string m, string n, string o, string p, string aa, string bb, string cc, string dd, string ee, string ff, string gg, string hh, string ii, string jj, string kk, string mm, string nn, string oo)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Level += 1;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync("");
        }

        [Command(".p Level")]
        public async Task Coun(IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} is {account.Level}");
        }





        [Command(".p Level set")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task levelset(IGuildUser user, uint level)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.Level = level;
            UserAccounts.SaveAccount();
            await Context.Channel.SendMessageAsync($"{user} Level has been set to {account.Level}");
        }





        [Command(".p Set Currency")]        
        public async Task Currency(string LevelAc)
        {
            var account = UserAccounts.GetAccount(Context.User);
            account.Currency = LevelAc;
            UserAccounts.SaveAccount();
            EmbedBuilder builder = new EmbedBuilder();

            builder.AddField("Currency Minted", $" {Context.User.Mention} {LevelAc}")
                .WithColor(Color.Blue);

            await Context.Channel.SendMessageAsync("", false, builder.Build());
        }


        [Command(".p Save Time")]
        public async Task TimeSave(IGuildUser user)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.currentTime = System.DateTime.Now;
            account.savedTime = System.DateTime.Now;
            UserAccounts.SaveAccount();
            

            await Context.Channel.SendMessageAsync("Time saved");
        }






        [Command(".p CustomCommand")]
        [RequireUserPermission(GuildPermission.CreateInstantInvite)]
        public async Task Costume(IGuildUser user, uint lvl)
        {
            var account = UserAccounts.GetAccount((SocketUser)user);
            account.CustomCommandLvL = lvl;
            UserAccounts.SaveAccount();
            EmbedBuilder builder = new EmbedBuilder();

            builder.AddField("Succesfull", $" {user.Mention} is number {lvl}")
                .WithColor(Color.Blue);

            await Context.Channel.SendMessageAsync("", false, builder.Build());
        }
    }
}