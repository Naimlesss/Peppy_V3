using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class Fun_fact : ModuleBase<SocketCommandContext>
    {
        public static string[] array = {"Did you know that penguins choose life partners", "Did you know that penguins also hug out of love and support", "Did you know that Pternophobia is the fear of being tickled by feathers", "Did you know that a flock of crows is known as a murder", "Did you know that polar bears could eat 86 penguins in one sitting? *i'm glad they are on the otherside of the planet*", "Did you know that heart attacks are more likely to happen on a monday", "Did you know that in 2015 more people died from attempting to take a selfie then from sharks?", "Did you know that May the 29th is the official *Put A Pillow In Your Fridge* Day", "Did you know that Cherophobia is the fear of fun", "Did you know that an earthquake on December 16, 1811 caused parts of the Mississippi River to flow backwards", "Did you know that the blue whale is the loudest animal in the world at 188DB", "Did you know that avocados are poisonous to birds", "Did you know that Barbie's full name is Barbara Millicent Roberts", "Did you know that cats cannot taste sweet things", "Did you know that Clinophobia is the fear of beds", "Did you know that Coca-Cola was the first soft drink to be consumed in outer space", "Did you know that the Bible is the most-shoplifted book in the world", "Did you know that the largest diamond ever found was an astounding 3,106 carats", "Did you know that Oceanic is born on the same day as Felix Arvid Ulf Kjellberg", "Did you know that when young and impoverished, Pablo Picasso kept warm by burning his own paintings", "Did you know that 92 nuclear bombs where lost on sea and never recovered", "Did you know that the average American/Canadian drinks about 600 sodas a year", "Did you know that you can start a fire with ice", "Did you know that The word 'News' is actually an acronym standing for the 4 cardinal compass points North, East, West and South", "Did you know that the energy of a discharge of an electric eel could start 50 cars" };

        List<string> option = new List<string>(array);



        [Command("Fun Fact")]
        public async Task PingAsync()
        {
            Random r = new Random();
            int rnd = r.Next(array.Length);
            await ReplyAsync(option[rnd]);
        }
    }
}
