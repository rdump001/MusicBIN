using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStudio.Data
{
    public class KEYBOARDDataSource : DataSourceBase<KEYBOARDSchema>
    {
        protected override string CacheKey
        {
            get { return "KEYBOARDDataSource"; }
        }

        public override bool HasStaticData
        {
            get { return true; }
        }

        private readonly IEnumerable<KEYBOARDSchema> _data = new KEYBOARDSchema[]
		{
            new KEYBOARDSchema
            {
                Title = "1",
                Subtitle = "Get familiar with your instrument",
                ImageUrl = "/Assets/DataImages/200802_104_span9.jpg",
                Description = "Whether you want to be a concert pianist or the keyboard whiz in a rock band, the" +
    " basics are the same.",
            },
            new KEYBOARDSchema
            {
                Title = "2",
                Subtitle = "Learn the terminology",
                ImageUrl = "/Assets/DataImages/xk2_keydtl.jpg",
                Description = @" The instrument has many names and variations that all use the same interface. Let’s take a non-comprehensive look at the history of the keyboard.
Harpsichord. These were some of the earliest keyboards, and made their sounds by plucking the string like a guitarist would do, only the pick was attached to a key. It didn’t matter if you played hard or soft. The resulting sound had no dynamic range—it was always the same loudness.
Piano. This refined the process of making sounds, using a hard-felt hammer rather than a pick. The hammer was activated by the keyboard, and the pianist was given control of full range of dynamics, from very soft to very loud.
Electric Piano. While a piano sounds incredibly rich and beautiful, it’s really hard to carry around to a gig. When musicians started plugging in back in the 50s, they wanted something at least as portable as a drum kit. The electric piano (and organ) were born.
Synthesizer. After 300 years of harpsichords and pianos, musicians were very familiar and comfortable with the layout of the keyboard. When electronic sound synthesizers came along, it made sense to use the same key layout, but there was a subtle shift in terminology. Until then, people who played the keyboard were generally called “pianists” or “organists.” However, for an instrument that has a keyboard like a piano, but can sound like anything from a symphony orchestra to singing kittens, the word “pianist” just didn’t fit any longer, and the keyboard player was born.",
            },
            new KEYBOARDSchema
            {
                Title = "3",
                Subtitle = "Look at the keyboard",
                ImageUrl = "/Assets/DataImages/11_14_21---Grand-Piano-Keyboard_web.jpg",
                Description = "Whether you’re playing an iPad recreation of a vintage synth, a monster digital w" +
    "orkstation keyboard, or a full-fledged concert grand piano, they all have exactl" +
    "y the same key layout, and may differ only in the number of keys.",
            },
            new KEYBOARDSchema
            {
                Title = "4",
                Subtitle = "Notice there are 2 different kinds of keys",
                ImageUrl = "/Assets/DataImages/629px-Play-the-Keyboard-Step-5-Version-2.jpg",
                Description = @"Black keys, and white keys. It may look confusing at first but here are a couple things that will make it easier.
There are only 12 basic notes. Every set of 12 notes is the same as every other set of 12 notes, only higher in pitch, or lower in pitch.
Every single white key is part of the C Major scale.
Every single black key is either called a “sharp” (#) or a “flat”(b).",
            },
            new KEYBOARDSchema
            {
                Title = "5",
                Subtitle = "Look at the keyboard again",
                ImageUrl = "/Assets/DataImages/670px-Play-the-Keyboard-Step-6-Version-2.jpg",
                Description = @"Notice the pattern, starting from the C on the left side of the picture. It has a tab pointing to the right. The next note, D, has little tabs on each side, and the next note, E, has a tab to the left.
Notice the pattern of 2 white keys bracketing 2 black keys and a white key in the middle.
Notice the next group up has the same type of grouping, only with 3 black keys and 2 white keys in the middle, between the notes F and B.",
            },
            new KEYBOARDSchema
            {
                Title = "6",
                Subtitle = "Find the C closet to the middle of the keyboard",
                ImageUrl = "/Assets/DataImages/Piano-labeled-white-keys-only.jpg",
                Description = "This is Middle C, or C3. The C notes above it are C4, C5, C6, etc. The C notes be" +
    "low it are known as C2, C1, C0.",
            },
            new KEYBOARDSchema
            {
                Title = "7",
                Subtitle = "Play a song",
                ImageUrl = "/Assets/DataImages/how-to-play-piano-songs.jpg",
                Description = @" Yes, that’s right. It’s that easy! Start on C3, imagine yourself walking normally, and for every step you imagine, play the next white key up, until you reach C4—then stop. Okay, it’s not much of a song, but all the basics were there—playing specific notes in a specific order for a specific amount of time. This is what you played looks like on sheet music:
Play it again. Just like before, imagine yourself walking, and for each step, play the next note up the keyboard. This time, look at each note, reading from left to right, before you play it on the keyboard. Now you're not only playing a song, you're reading music!",
            },
            new KEYBOARDSchema
            {
                Title = "8",
                Subtitle = "The digital keyboard is easier to play",
                ImageUrl = "/Assets/DataImages/Yamaha-E233-600x250.jpg",
                Description = @"Next time you're near a piano, press down on the lowest note. Then press down on the highest note. Feel the difference? It's heavy and firm on the lower end, and light and easy on the higher end.
Now try the same thing on most keyboards. Unless they're made to emulate a piano keyboard, the keys on a synthesizer or workstation all feel the same. The ""action,"" as it's called, is very light and fast, and much easier on the hands to play for long hours.
Many keyboard players do not need the full range of the piano. The notes you're playing can be moved up and down the keyboard electronically. For example, the note that is currently at middle C—C3, can become C4, or C1, or any other octave at the touch of a button.",
            },
            new KEYBOARDSchema
            {
                Title = "9",
                Subtitle = "Work through the song until it sounds the way you like it.",
                ImageUrl = "/Assets/DataImages/590Girl_Playing_the_Piano_in_Wheat_Field_3.jpg",
                Description = "When you\'re done, learn another song. Don\'t stop until Kanye is your opening act!" +
    ".",
            },
		};

        public async override Task<IEnumerable<KEYBOARDSchema>> LoadDataAsync()
        {
            return await Task.Run(() =>
            {
                return _data;
            });
        }
    }
}
