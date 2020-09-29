using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStudio.Data
{
    public class VIOLINDataSource : DataSourceBase<VIOLINSchema>
    {
        protected override string CacheKey
        {
            get { return "VIOLINDataSource"; }
        }

        public override bool HasStaticData
        {
            get { return true; }
        }

        private readonly IEnumerable<VIOLINSchema> _data = new VIOLINSchema[]
		{
            new VIOLINSchema
            {
                Title = "1",
                Subtitle = "Purchase a violin",
                ImageUrl = "/Assets/DataImages/images.jpg",
                Description = @" If you're just starting out with the instrument, there's no need to spend an excessive amount of money on a violin, but like most instruments, the quality of the violin generally rises as the price goes up. Expect to spend a few hundred dollars on a decent beginner's violin.
Buy full size or 4/4, if you're an adult. The violin is a small instrument, but there are specially designed smaller sizes available. These are generally only intended for very young children, so be sure the violin you're buying is full size unless you're very small. You can ask the shop for a recommendation if you aren't sure. You can also ask the shop to measure your arm length to see what size violin you need.
Buy from a reputable seller. Music stores stake their reputations on selling solid instruments that are free of obvious flaws and damage. As a beginner, you won't be able to coax a very pleasant sound from your instrument for some time, so flaws in privately sold violins might not be apparent to you until it is far too late to complain. Only buy from a store or individual you can trust.",
            },
            new VIOLINSchema
            {
                Title = "2",
                Subtitle = "Purchase other items",
                ImageUrl = "/Assets/DataImages/download.jpg",
                Description = @"Nearly all violinists use a chin rest, which is a cheap, ergonomic piece of (usually black) plastic that clamps near the base of the violin and allows it to be held securely by your chin. Aside from that, be sure you have some rosin (coagulated sap) for your bow, a music stand, and a book of beginner lessons or songs, preferably in a format that will open flat.
Some violinists, especially beginners, also purchase a shoulder rest, which is a violin-width pad that sits on your shoulder underneath the violin and makes it easier to hold. Many people start with a shoulder rest and eventually remove it after a few years. If the violin seems to dig into your shoulder when you play, consider purchasing one.
Fiddlers often hold the violin in the crook of an arm while playing, with the butt resting against their shoulder. For them, chin rests and shoulder rests are generally pointless.",
            },
            new VIOLINSchema
            {
                Title = "3",
                Subtitle = "Tighten the bow",
                ImageUrl = "/Assets/DataImages/bow.jpg",
                Description = @"Once you've set up your music stand and sheet music, open the hard case and remove the bow. The hair of the bow should be limp. Tighten the bow hair by turning the end screw clockwise until the space between the hair and the stick is big enough to pass a pencil through cleanly from tip to tip.
Don't use your pinky finger as a gauge because the oil from your skin will transfer to the the hair, which needs to remain oil-free to get the best sound from the strings.",
            },
            new VIOLINSchema
            {
                Title = "4",
                Subtitle = "Rosin the bow",
                ImageUrl = "/Assets/DataImages/670px-Use-New-Rosin-on-a-New-Violin-Bow-Step-2.jpg",
                Description = @"Rosin comes in two types, dark and light; either is fine to use, and neither is expensive. It's usually a rectangle of hard, translucent material in a paper or cardboard casing that's open on two sides. Grip the rosin by the papered sides and gently but vigorously rub it up and down along the length of the bow hair three or four times. The goal is to transfer some of the rosin “dust” onto the hair, making it stickier.
Too much rosin will cause the bow to grip too well, producing a scratchy sound. If you over-rosin your bow, it's fine; it'll just take a few hours of playing to bring it back down to the correct level.
If this is a newly haired bow, it may need more rosin than normal. Draw the flat side of the bow hair across a string to see if it makes a clear sound after three or four strokes of rosin. If it doesn't, add a couple more.",
            },
            new VIOLINSchema
            {
                Title = "5",
                Subtitle = "Tune the violin",
                ImageUrl = "/Assets/DataImages/670px-Tune-a-Violin-Step-10.jpg",
                Description = @"Set the bow aside for a moment and take the violin out of the case. The strings, in order from lowest tone to highest, should be tuned to G, D, A, and E. You can usually purchase a electric tuner from $15 to $20 dollars depending on the quality and brand. Major adjustments can be made with the tuning pegs in the scroll of the violin, but if the tone seems only a little bit off, use the tiny metal dials near the bottom, called fine tuners, to make your adjustments instead. Once you're satisfied, return the violin to the open case for a moment.
Rely on a tone whistle to find the correct notes, or simply look sound files up on the Internet.
Not all violins have fine tuners, but they can be installed by a shop.",
            },
            new VIOLINSchema
            {
                Title = "6",
                Subtitle = "Grip the bow",
                ImageUrl = "/Assets/DataImages/BowHold02.jpg",
                Description = @"Start by gently laying the middle part of your index finger on the grip (the slightly padded part of the stick, usually a few inches above the tightening knob). Place the tip of your pinky on the flat part of the stick near the base, keeping it slightly curved. The ring and middle fingers should rest with their middle parts in line with the tip of your pinky, and their tips on the side of the frog (the black piece that connects the tightening knob to the the hair). Your thumb should rest underneath the stick, at the front of the frog, near or on the bow hair.
Your hand should be relaxed and loose, and somewhat rounded as if holding a small ball. Don't let your palm close or rest on the bow. This reduces the control you have over the movement of the bow, which becomes increasingly important as your skill increases.",
            },
            new VIOLINSchema
            {
                Title = "7",
                Subtitle = "Hold the violin",
                ImageUrl = "/Assets/DataImages/Violinist-002_large.jpg",
                Description = @"Stand or sit with a straight back. Pick it up by its neck with your left hand and bring the butt of the instrument up to your neck. Rest the lower back of the violin on your collar bone and hold it in place with your jaw.
Your jaw, just under the earlobe (not your chin), is supposed to be resting on the chin rest. This helps prevent the instrument from sliding off your shoulder. (This is also why violinists on TV always seem to be looking down and to the right.",
            },
            new VIOLINSchema
            {
                Title = "8",
                Subtitle = "Perfect your hand position",
                ImageUrl = "/Assets/DataImages/6_violin-player-girl-13.jpg",
                Description = @"Place your hand under the top part of the neck and support the violin so that the scroll is pointing out away from you. Hold it steady by resting the side of your thumb on the neck, and allow your four fingers to arch over the fingerboard, which is the black plate covering the front of the neck.
As a beginner, your hand should be as far up the neck as possible while still allowing your pointer finger to come down on the fingerboard. Eventually you'll learn to slide your hand up and down to reach higher notes quickly.",
            },
            new VIOLINSchema
            {
                Title = "9",
                Subtitle = "Play the strings",
                ImageUrl = "/Assets/DataImages/stock-footage-play-the-violin-movement-of-the-bow-on-the-strin" +
    "gs-violin.jpg",
                Description = @" Place the flat side of the bow hair approximately halfway between the bridge (the flimsy-looking wooden stand 3/4 of the way down the strings that keeps them tented) and the fingerboard, so that it's directly over the belly (front body) of the violin. Pull the bow along the string as straight as you can, parallel to the bridge, applying a small amount of pressure. A sound should emanate from the violin. Also tilt the bow hair towards bridge at a 45 degree angle.
More pressure equals louder sound, but too much pressure makes it scratchy. Light pressure should produce a continuous tone from end to end of the bow; if there are gaps, the bow needs more rosin.
Tilt the bow slightly toward the scroll and your tone will be more focused, producing a more professional sound.",
            },
            new VIOLINSchema
            {
                Title = "10",
                Subtitle = "Practice playing open strings(G,D,A and E in order from top to bottom string)",
                ImageUrl = "/Assets/DataImages/strings.jpg",
                Description = @"Open strings are simply strings played without fingertips on them. Rest the neck of the violin in the space between the left thumb and first finger. Hold the bow with your wrist, elbow, shoulder and contact point on the string within one plane. Change strings by raising or lowering the elbow to bring the bow to the proper height. Try short strokes of 6 inches or so in the middle of the bow at first, then try half strokes from the frog to the middle and back again. Work your way up to full-length strokes.
Short and long strokes are both important techniques for playing the violin, so don't feel as though you're wasting time practicing with short strokes.
Continue practicing until you can play one string at a time without touching the other strings. It's important to develop control so you don't accidentally play a note you didn't want to play.",
            },
            new VIOLINSchema
            {
                Title = "11",
                Subtitle = "Practice playing other notes",
                ImageUrl = "/Assets/DataImages/15418r2Nce819a12e2458523048b8c715c068797.jpg",
                Description = @"It takes a lot of practice to master the pressure and positioning required to get your fingers to produce clear notes on the fingerboard. Start with your strongest finger, the pointer finger. Using the tip only, press down firmly on the highest string (the E string). You don't need to use as much pressure as you do with guitar strings; a modest but firm amount is enough. Draw the bow across the E string to produce a slightly higher note. If you are holding the violin properly, your finger should naturally come down about half an inch below the nut (the top of the fingerboard), producing an F note.
Add notes. Once you're able to produce a clear note, try putting the tip of your middle finger down a little ways below the pointer finger on the fingerboard. Keep both fingers down and play another, higher note. Finally, set the ring finger ahead of the middle finger and repeat the process. The pinkie is also used, but takes considerably more practice to master. For now, just worry about the other three fingers.
Add strings. Try playing four notes (open, pointer, middle, and ring) on all four strings. Pay attention to the amount of pressure you need to produce a clear note on each one.",
            },
            new VIOLINSchema
            {
                Title = "12",
                Subtitle = "Practice scales",
                ImageUrl = "/Assets/DataImages/Violin-Scales.jpg",
                Description = @"A scale is a series of notes that ascend and descend in a pattern of steps (usually 8, sometimes 5) that starts at one note and ends at a higher or lower version of the same note. An easy (and useful) scale for beginners is the D Major scale, which starts on the open D string. From there, place your fingers down in order (as described above) and play each note: D (open), E, F sharp, G (which should be produced by your third, or ring, finger). To complete the scale, play the next highest open string, A, and then repeat the pattern on the A string to play B, C sharp, and finally D with your third finger.
When properly played, the D Major scale (and in fact, every major scale) should match the sound of the famous “Do, Re, Mi, Fa, So, La, Ti, Do” singing scale. If you don't know what that is, look it up online or watch the musical film “The Sound of Music,” which features a memorable and well-known song called “Do Re Mi” that explains it.
If you can't seem to get the sound right, remember: place the first finger a finger's width from the nut, the second finger a finger's width from the first, and the third finger touching the second. If you prefer, ask your music shop or teacher to tape the finger positions for you with white tape, so you have a visual guide.
Other scales, such as minor, harmonic, and even pentatonic (5-note) scales exist, but those can be studied, practiced, and internalized later.",
            },
            new VIOLINSchema
            {
                Title = "13",
                Subtitle = "Practice every day",
                ImageUrl = "/Assets/DataImages/boy_with_violin.jpg",
                Description = @"Start with a short time (15 or 20 minutes) and work a little longer every day until you reach an hour, or you can't find any more time to play. Serious violinists often practice for 3 or more hours per day; then again, many violinists at that level get money for playing. Practice as much as you reasonably can, and keep at it. Even sounding good enough to play a few simple songs can take months, but eventually, things will begin to come together.",
            },
		};

        public async override Task<IEnumerable<VIOLINSchema>> LoadDataAsync()
        {
            return await Task.Run(() =>
            {
                return _data;
            });
        }
    }
}
