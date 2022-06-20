using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Discord.WebSocket;
using BotPeppy.UserProfile;
using BotPeppy.Core;
//dit word gebruikt als peppy een interactie heeft met iemand die hij niet kent, hier maakt hij een nieuw 'UserAccount' aan, met de standaard waardes voor hun persoonlijk profiel.
namespace BotPeppy.UserProfile
{
    public static class UserAccounts
    {
        private static List<UserAccount> accounts;

        private static string accountFile = "Resources/accounts.json";

        static UserAccounts()
        {
            if(DataStorage.SaveExists(accountFile))
            {
                accounts = DataStorage.LoadUserAccount(accountFile).ToList();
            }
            else
            {
                accounts = new List<UserAccount>();
                SaveAccount();
            }
        }

        public static void SaveAccount()
        {
            DataStorage.SaveUserAccounts(accounts, accountFile);
        }

        public static UserAccount GetAccount(SocketUser user)
        {
            return GetOrCreateAcount(user.Id);
        }

        private static UserAccount GetOrCreateAcount(ulong id)
        {
            var result = from a in accounts
                         where a.ID == id
                         select a;

            var account = result.FirstOrDefault();
            if (account == null) account = CreateUserAccount(id);
            return account;
        }

        private static UserAccount CreateUserAccount(ulong id)
        {
            var newAccount = new UserAccount()
            {
                Milestonetime = System.DateTime.Now,
                currentTime = System.DateTime.Now,
                savedTime = System.DateTime.Now,
                Currency = "<:mcatdab:311925731095609344>",
                ID = id,
                Points = 0,
                XP = 0,
                Level = 0,
                CustomCommandLvL = 0,
                Ach1 = "X",
                OneDownManyToGo = "X",
                Colorinator = "X",
                TwoTimesTheWinner = "X",
                ThirdTimesCharm = "X",
                Team10 = "X",
                ThirdPlaceInbound = "X",
                Top5 = "X",
                KingOfTheHill = "X",
                PowerGrinding = "X",
                SettingTheBarHigh = "X",
                SettingGoals = "X",
                Talkative = "X",
                GrindGrindAndGrind = "X",
                TheKnightOfTheRoundTable = "X",
                EarlGreyTea = "X",
                TheDukeOfDiscord = "X",
                YourKingHasArrived = "X",
                EmperorAtYourService = "X",
                PeppiesFriend = "X",
                Borntolead = "X",
                ARefinedTaste = "X",
                gottemDsa = "X",
                Herecomesthecavalry = "X",
                AFreshStart = "X",
                YouGetAGoldStar = "X",
                Quotable = "X",
                Anniversary = "X",
                PartyTime = "X",
                Goodboy = "X",
                KindHeart = "X",
                KindSoul = "X",
                Atrueangel = "X",
                YoureawizardHarry = "X",
                Tenpointsforgriffindor = "X",
                Whyaretheyallstaring = "X",
                Hogwartswillalwaysbeyourhome = "X",
                soyoudohaveears = "X",
                Spotifypremium = "X",
                MusicManiac = "X",
                Yoursinglewentplat = "X",
                ATightSqueeze = "X",
                Believer = "X",
                Priest = "X",
                DemiGod = "X",
                Divinity = "X"
            };

            accounts.Add(newAccount);
            SaveAccount();
            return newAccount;
        }
    }
}
