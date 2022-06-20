using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotPeppy.UserProfile;
using Discord;
using Discord.WebSocket;
using PeppyV3.Core;
using Discord.Commands;
using System.Windows;
// did deel van de code houd tijd bij, sinds het eerste bericht dat peppy van iemand heeft waargenomen. En veranderd de hoeveelheid "XP" ze krijgen voor berichten posten.
namespace PeppyV3.Core.Economy
{
    internal static class Economy
    {


        internal static void UserSendMessage(SocketUser user)
        {

            var userAccount = UserAccounts.GetAccount(user);
            uint oldLevel = userAccount.Level;

            var Milestonelevel = 0;
            var milestone = userAccount.Milestonetime;
            var currentTime = System.DateTime.Now;
            var savedTime = userAccount.savedTime;
            var Points = userAccount.Level * 2;
            var PointTime = userAccount.currentTime;

            TimeSpan Pointdifference = currentTime.Subtract(PointTime);
            if (Pointdifference.TotalSeconds <= 59) return;
            userAccount.currentTime = currentTime;
            TimeSpan Milestones = currentTime.Subtract(milestone);
            if (Milestones.TotalDays <= 120) Milestonelevel = 1;
            if (Milestones.TotalDays <= 180) Milestonelevel = 2;
            if (Milestones.TotalDays <= 240) Milestonelevel = 3;
            if (Milestones.TotalDays <= 365) Milestonelevel = 4;
            if (Milestones.TotalDays <= 730) Milestonelevel = 5;
            if (Milestones.TotalDays <= 1460) Milestonelevel = 6;
            if (Milestones.TotalDays <= 2190) Milestonelevel = 7;
            if (Milestones.TotalDays <= 3650) Milestonelevel = 8;

            if (Milestonelevel == 0) userAccount.XP += 21;
            if (Milestonelevel == 1) userAccount.XP += 33;
            if (Milestonelevel == 2) userAccount.XP += 41;
            if (Milestonelevel == 3) userAccount.XP += 51;
            if (Milestonelevel == 4) userAccount.XP += 61;
            if (Milestonelevel == 5) userAccount.XP += 71;
            if (Milestonelevel == 6) userAccount.XP += 81;
            if (Milestonelevel == 7) userAccount.XP += 91;
            if (Milestonelevel == 8) userAccount.XP += 101;
            

            UserAccounts.SaveAccount();

            TimeSpan difference = currentTime.Subtract(savedTime);
            
            if (difference.TotalHours <= 149) return;
            if (difference.TotalHours >= 150) userAccount.savedTime = currentTime;
            userAccount.XP += 40;
            UserAccounts.SaveAccount();
            var XP = userAccount.XP;
            userAccount.XP = XP * 1010 / 1000 ;
            UserAccounts.SaveAccount();
        }

       
    }
}
