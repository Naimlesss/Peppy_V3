using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotPeppy
{
    public class Pun : ModuleBase<SocketCommandContext>
    {
        public static string[] array = { "You are so sweet, it gives me happyfeet", "I flippin' love you", "http://www.kappit.com/img/pics/201605_2201_cfghb_sm.png", "Don't trust atoms, they make up everything.", "What does one ocean say to another? Nothing they just wave", "My girlfriend said, You act like a detective too much.I want to split up. Good idea,  I replied. We can cover more ground that way.", " What do you call the security outside of a Samsung Store? Guardians of the Galaxy.", "I'm reading a book about anti-gravity. It's impossible to put down.", "I got a new pair of gloves today, but they're both 'lefts' which, on the one hand, is great, but on the other, it's just not right.", "My pengchiatrist said I was pre-occupied with the vengeance I told him: Oh yeah? We'll see about that!", "A courtroom artist was arrested today details are sketchy.", "Why do the French eat snails? They don't like fast food.", "How does Moses make his tea? Hebrews it.", "Did you hear about the 2 silk worms in a race? It ended in a tie!", "I hate peer pressure and you should too.", "To write with a broken pencil is pointless.", "How did I escape Iraq? Iran.", "I've just written a song about tortillas. Actually, it's more of a rap.", "I have a few jokes about unemployed people but it doesn't matter none of them work.", "What do you call a laughing motorcycle? A Yamahahaha.", "I sat next to a man on the park bench. He had 9 watches on one wrist and 5 in the other. I said 'man you sure do have a lot of time on your hands'", "This morning some clown opened the door for me. I thought to myself that's a nice Jester.", "Most people are shocked when they find out how bad I am as an electrician", "Thieves had broken into my house and stolen everything except my soap, shower gel, towels and deodorant. Dirty Bastards.", "I was born to be a pessimist. My blood type is B Negative.", "My new girlfriend works at the Zoo. I think she is a keeper.", "I'm trying to date a philosophy professor, but she doesn't even know if I exist or not.", "I am on a seafood diet. Every time I see food, I eat it.", "What was Forrest Gump's email password? '1forrest1'", "I used to work at a fire hydrant factory couldn't park nowhere near the place." };

        List<string> option = new List<string>(array);



        [Command(".p Pun")]
        public async Task PingAsync()
        {
            Random r = new Random();
            int rnd = r.Next(array.Length);
            await ReplyAsync(option[rnd]);
        }
    }
}