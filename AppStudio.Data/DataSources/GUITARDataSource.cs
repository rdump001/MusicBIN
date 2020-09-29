using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStudio.Data
{
    public class GUITARDataSource : DataSourceBase<GUITARSchema>
    {
        protected override string CacheKey
        {
            get { return "GUITARDataSource"; }
        }

        public override bool HasStaticData
        {
            get { return true; }
        }

        private readonly IEnumerable<GUITARSchema> _data = new GUITARSchema[]
		{
            new GUITARSchema
            {
                Title = "1",
                Subtitle = "Identify the parts of the guitar",
                ImageUrl = "/Assets/DataImages/parts_of_guitar.jpg",
                Description = @" Whether you're playing an electric or an acoustic guitar, the instrument is essentially wood and metal. Copper-wound strings vibrate to create sound. The wooden body resonates that sound to create the warm tones we associate with a guitar.
The strings run between the headstock of the guitar, where they are affixed to tuning pegs that can be rotated to tighten and slacken them, and the bridge, where they're fixed to the guitar's body. On an acoustic guitar, the strings are fixed to the bridge with removable pegs, and on an electric guitar the strings are generally strung through a eyelet.
The neck of the guitar is the long wooden piece of wood, flat on one side (this is called the fretboard) and curved on the other. The fretboard is inlaid with metal frets that demarcate the different notes.
An acoustic guitar will have a sound hole in the body where the sound will resonate, while an electric guitar will have as many as three magnetic pickups which will channel the sound through an amplifier.",
            },
            new GUITARSchema
            {
                Title = "2",
                Subtitle = "Hold the guitar correctly",
                ImageUrl = "/Assets/DataImages/sittingposition.jpg",
                Description = @"Before you start wailing like Hendrix, make sure you're holding your guitar right. If you're right handed, you'll play the guitar by strumming about halfway between the sound hole and the bridge with your right hand and fretting the strings on the neck with your left hand.
To play your guitar, sit up in a straight-backed chair or stool. When you orient the guitar to your body, the smallest string should be pointed toward the ground and the thickest string should be pointed up at the ceiling. Hold the back of the guitar so it touches your stomach and chest and rests on the leg of your strumming/picking hand.
The guitar should be held mostly with your leg and by cradling it in your body. Your left hand is used to stabilize the neck and fret the strings. Hold the neck in the V created by your thumb and forefinger. You should be able to smoothly move your left hand up and down the neck without having to hold it up.
Even if you hold the guitar correctly, you may experience some discomfort while getting used to playing. Do not become discouraged if your shoulder hurts in addition to your neck, arms and hands. You will eventually get used to it.",
            },
            new GUITARSchema
            {
                Title = "3",
                Subtitle = "Tune the guitar",
                ImageUrl = "/Assets/DataImages/how-to-tune-a-guitar.jpg",
                Description = @"It's no fun to play a guitar that's not in tune and can lead to some bad habits when you're first starting out. Tuning regularly will also familiarize you with which string and fret combinations correspond with which notes.
First learn the name of each string. From the lowest to highest pitch (thickest to thinnest strings) the strings are named E, A, D, G, B, and E (after the note played when the string is plucked with no fingers touching it). Use a mnemonic to remember this order, such as Eddie Ate Dynamite Good Bye Eddie.
Electric tuners are easy to use and very accurate. Hold it to the guitar and pluck the high E. The tuner will tell you if the guitar is ""sharp"" (too high) or ""flat"" (too low). Pick each note and tighten the string to make it go higher, or give it some slack to lower it. Make sure the room is quiet when using a tuner because the microphone on the tuner can pick up other sounds.
If you cannot afford a tuner, you can also tune your guitar without one by matching each note to the corresponding note on the piano.",
            },
            new GUITARSchema
            {
                Title = "4",
                Subtitle = "Practice fretting the strings",
                ImageUrl = "/Assets/DataImages/beginner-lessons-finger-thumb-positions-800X800.jpg",
                Description = @"he frets are the metal strips that run perpendicular to the strings that mark each note. To play a note, press your finger down between the metal strips, not on them. To say that you're playing the third fret means that you place your finger on the string in the gap between the second and third fret. Hold the string down firmly so that it only vibrates between your finger and your strumming hand, with the tip of your finger doing the pressing.
Every time you move from one fret to another, the resulting pitch will be half a step higher as you move toward the body and a half step lower as you move toward the headstock. Practice moving up and down the fretboard, pressing the frets and getting a feel for the pressure you need to use to play a note.",
            },
            new GUITARSchema
            {
                Title = "5",
                Subtitle = "Learn first position chords",
                ImageUrl = "/Assets/DataImages/Gbarre1.jpg",
                Description = @"A chord is a harmonic group of at least three notes. For beginning guitar, there are two basic chord types: first position chords, and barre chords. First position chords can be played with a combination of open strings and pressed strings in the first three frets of the guitar.
Commonly major chords are C Major, A Major, G Major, E Major, D Major.
When you've got the shapes down, practice switching between them as quickly as you can. Write out more or less random arrangements of the chords you want to play and switch between them, strumming once.
Make sure you play the appropriate notes. In A Major, for example, the low E string is not strummed. They'll be marked on the tablature with an ""X"". Develop good habits now for success in the long run.",
            },
            new GUITARSchema
            {
                Title = "6",
                Subtitle = "Practice getting a clean sound",
                ImageUrl = "/Assets/DataImages/blackbarre.jpg",
                Description = @"After you had placed all your fingers on the fretboard, play through each of the strings of the chords. Make sure that the strings that are supposed to ring are not muffled or muted.
If the notes are not ringing out properly, chances are that you are not pressing hard enough or parts of your fingers are touching that string which prevents it from sounding out clearly. Are any unused fingers touching strings?[1]
Keep the fretting fingers curled at all times they're touching the strings, as if you had your fingers resting over an imaginary glass ball, or a marble in the knuckle of each finger.",
            },
            new GUITARSchema
            {
                Title = "7",
                Subtitle = "Learn barre chords",
                ImageUrl = "/Assets/DataImages/e-barre-chord.jpg",
                Description = @"Barre chords, or movable chords, are extremely useful for starting to play songs. In a barre chord (sometimes shortened to ""bar chord""), the index finger of your fretting hand ""bars"" all the notes at a single fret. To play an F, which is the barre chord in first position, you bar all the notes on the first fret with your index finger and play what is essentially the shape of the E chord moved one step up the neck, with your middle, index, and pinkie.
That same claw-like finger positioning on the second fret is a B chord. On the third fret, a G chord. It's a difficult and sometimes painful finger positioning, to learn, but you can start playing the chords to any punk song relatively quickly when you learn to strum and play barre chords. The Ramones used nothing but barre chords to great effect.",
            },
            new GUITARSchema
            {
                Title = "8",
                Subtitle = "Manage the finger pain",
                ImageUrl = "/Assets/DataImages/classical-guitar.jpg",
                Description = @"There'll be a point at which things will seem bleak: you can't quite get to each chord as fast as you want, your fingers are killing you, and it seems easier to put the thing back in its case. The reason most guitar players stop playing a few weeks in is that it hurts. After a couple of months and years of playing, callouses will build up on the fingers of your fretting hand that will greatly reduce the pain of pushing down the strings for long periods of time. Learning to get past this barrier though, makes all the difference in the world. Everyone who learns to play the guitar has to deal with sore fingers at the beginning. It's worth it. Just keep playing regularly, follow these tips, and you'll get past this stage in no time at all. Learn to love the pain and associate it with everything that you love about music and the guitar.
Ice your fingers after playing or soak them in some apple cider vinegar to alleviate some of the pain.
It's mostly mental. Try picturing your favorite guitar player encouraging you along like a weightlifting coach when your fingertips are sore. ""One more! One more!""
Dipping your fingers in rubbing alcohol after playing can speed up callus build up. Just don't do it before you play.",
            },
            new GUITARSchema
            {
                Title = "9",
                Subtitle = "Learn to play some songs",
                ImageUrl = "/Assets/DataImages/04083-1.jpg",
                Description = @"It's a whole lot more fun to play when you're playing a song that you can recognize and not just a set of chords or notes, and there has been a whole world of music written with the chords G, C, and D. Some old folk and country songs like ""Tom Dooley"" or ""Folsom Prison Blues"" by Johnny Cash can be great ways to start. It's just three chords and the truth, as songwriter Harlan Howard once famously put it.
Start off slow and speed up gradually, singing along (if you want to, and if it helps) and pay particular attention to the rhythm. It can be kind of frustrating how mechanical it will sound at first, but don't worry. The more comfortable you get switching between the chords, the closer you'll be to rocking out on stage.
As you master easier songs, move on to more complex pieces. ""Sweet Home Alabama"" by Lynyrd Skynyrd is basically a repetition of D, C, and G in that order, but it sounds much more complex on the record, because of the cool-sounding lead guitar licks the guitar player throws in.",
            },
            new GUITARSchema
            {
                Title = "10",
                Subtitle = "Learn how to read guitar tabs",
                ImageUrl = "/Assets/DataImages/670px-Play-Acoustic-Guitar-Tab-Step-3.jpg",
                Description = @"Guitarists have their own system of music notation called guitar tablature, or guitar tabs for short. The basic idea is to look at each line in the ""staff"" of the tab in the same way you look at your guitar; each line really corresponds to a string, and each number tells you which fret to hold down when plucking that string.
E|-------------------------------------------------||
B|-------3---------3----------3--------------------||
G|---------2---------0--------0---------------2p0--||
D|-0-0------------------------0--0----0h2p0--------||
A|------------3-3-------------2---0p2-------0------||
E|-----------------------3-3--3--------------------||

To play this tab-notated lick from the Lynyrd Skynyrd song ""Sweet Home Alabama,"" you would play two notes on the open D string, the B string at the third fret, the G string at the second fret, etc.
Switching between lead-style licks and chords is exciting. You'll feel like you're really making music and not just ""learning guitar."" But don't rush it, make sure you've got your chord shapes down correctly and that you're not losing the rhythm entirely when you play a quick lick.",
            },
		};

        public async override Task<IEnumerable<GUITARSchema>> LoadDataAsync()
        {
            return await Task.Run(() =>
            {
                return _data;
            });
        }
    }
}
