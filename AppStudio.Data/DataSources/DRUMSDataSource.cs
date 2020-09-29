using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStudio.Data
{
    public class DRUMSDataSource : DataSourceBase<DRUMSSchema>
    {
        protected override string CacheKey
        {
            get { return "DRUMSDataSource"; }
        }

        public override bool HasStaticData
        {
            get { return true; }
        }

        private readonly IEnumerable<DRUMSSchema> _data = new DRUMSSchema[]
		{
            new DRUMSSchema
            {
                Title = "1",
                Subtitle = "Start learning to drum with your hands",
                ImageUrl = "/Assets/DataImages/092110-conga-opener.jpg",
                Description = @"You don't have to have a monstrous kit with a gong like Neil Peart from Rush to get started drumming. You don't even have to have a kit at all. To get started on the basics, use your hands and tops of your thighs in a seated position to learn basic drum-kit rhythms.
Many beginners can get frustrated upon plopping down behind a kit and not being able to play a simple rhythm yet. It's a good idea to start getting some sense of rhythm before dropping the cash on a big drum kit to practice on, or before giving yourself an opportunity to get frustrated.",
            },
            new DRUMSSchema
            {
                Title = "2",
                Subtitle = "Get familiar with the basic drum kit",
                ImageUrl = "/Assets/DataImages/YamaharecordingCustom.png",
                Description = @"Each kit is different, using different kinds of drums that make up a set. There are different brands, sizes, sticks used, and different tunings among other slighter modifications that will affect the overall sound of each instrument. Still, many drum kits employ basically the same fundamental pieces. Most basic kits include:
A bass drum, which makes the low-pitched booming sound when struck by a weighted mallet operated by a foot pedal.
A snare drum, usually located to the non-dominant side of the drummer and played with the drummer's non-dominant stick. The snare is a tight, bright drum with a band of rattling metal beads under the drum head. Typically, the snare is known for its crisp ""click"" sound followed by the ""resonating shuffle"" of the beads.
There are many types of tom-tom drums, but the most common three are the Floor Tom (the deepest of the three), the Mid-Tom (the medium of the three), and the High-Tom (the most high-pitched of the three). A very basic kit may only have the floor tom, while others may have many. They're tuned differently to create an array of different deeper noises for fills.",
            },
            new DRUMSSchema
            {
                Title = "3",
                Subtitle = "Get comfortable holding the drum sticks",
                ImageUrl = "/Assets/DataImages/rock-band-game-drumsticks.jpg",
                Description = @"There are two main ways to hold drum sticks, called the matched grip and the traditional grip.
In the matched grip, you hold the sticks between your thumb and index finger a few inches from the bottom of the sticks. Wrap your remaining fingers around the sticks. This method is the most common way of holding sticks, allowing you plenty of wrist control and comfort.
In the traditional grip, you'll hold the stick in your non-dominant hand by resting the stick in the cradle between your thumb and index finger and on top of your ring finger. Wrap your thumb, index and middle fingers around the stick. Hold the other stick using a matched grip. Some jazz drummers use a traditional grip to offer a different kind of control on the snare drum, playing intricate rhythms on it as part of fills.",
            },
            new DRUMSSchema
            {
                Title = "4",
                Subtitle = "Learn to sit at the kit with the proper posture",
                ImageUrl = "/Assets/DataImages/Standard-Male-Posture-Side-View.jpg",
                Description = @"Good posture will make you more comfortable during practice and help you reach the drums more easily. You'll sound better and enjoy playing more by improving your posture.
Sit up straight and keep your elbows in. Stay in tight to the kit, keeping the floor pedals at a comfortable distance from you.",
            },
            new DRUMSSchema
            {
                Title = "5",
                Subtitle = "Play your simple hand beat on the kit",
                ImageUrl = "/Assets/DataImages/download__1_.jpg",
                Description = @"Play the 8th notes on the hi-hat, hitting the snare drum on 2 and 4, and pressing the bass drum pedal with your foot on the 1 and 3.
Make sure you count out loud when you are playing. Eventually you won't have to, but do it while you are learning and when you are practicing.
To mix it up and get familiar with the kit, hit something else on the ""Two"" and on the ""Four"" instead of the snare drum, hit everywhere else.
Try to develop a groove and get used to playing evenly, while counting out loud and while playing with the click.",
            },
            new DRUMSSchema
            {
                Title = "6",
                Subtitle = "Develop your footwork",
                ImageUrl = "/Assets/DataImages/phat-foot-drums-harness.jpg",
                Description = @"At the same time you hit the hi-hat, learn to work in bass drum rhythms to help develop the muscles.
Try to play with the right hand and foot at the same time, left hand free styling, or with all limbs at the same time to really get your muscles used to moving.",
            },
            new DRUMSSchema
            {
                Title = "7",
                Subtitle = "Use fills to add to the song you\'re playing",
                ImageUrl = "/Assets/DataImages/how-to-read-drum-music-fills.WidePlayer.jpg",
                Description = @"The purpose of a drum fill is to add a little flair to a song. A guitar player plays a hot little lick and a singer might shout and dance about, and the drummer plays fills. These happen in time between the beats, usually on the toms and the cymbals. Listen to John Bonham to hear the master of drum fills.",
            },
            new DRUMSSchema
            {
                Title = "8",
                Subtitle = "Start with the basic beat",
                ImageUrl = "/Assets/DataImages/images__1_.jpg",
                Description = @"Play ""1 + 2 + 3 + 4 +"" and play as you did before with right hand on the hi-hat and left on the snare. Use the right foot on the kick. Repeat as you warm up. Now continue counting out loud and just play ""1 + 2 +"" and then stop playing with your limbs and just finish counting out loud ""3 + 4 +""repeat.
It should sound like ""Boom tic Pap tic"" now on the ""3 + 4 +"" do anything else for example start with moving every limb at the same time on the ""3 + 4 +"" you can hit the crash (if you have one) on the one on the following bar and you will have pulled off your first fill.",
            },
            new DRUMSSchema
            {
                Title = "9",
                Subtitle = "Use your fills wisely",
                ImageUrl = "/Assets/DataImages/Copy_of_drummer.jpg",
                Description = @"Learn to hold back on fills, even if you're a killer drummer. AC/DC songs feature extremely simple fills or no fills at all, which fits in perfectly with their no-frills reputation as a band. It would sound ridiculous if ""Back in Black"" featured a drum solo.
You don't have to start a fill at the beginning of a beat. Count "" One and Two"" and play it like you did before with the right hand on the hi-hat and the left on the snare but when you get to the ""and three and four and"" play the fill starting on that and instead of waiting for the ""three"" beat.",
            },
		};

        public async override Task<IEnumerable<DRUMSSchema>> LoadDataAsync()
        {
            return await Task.Run(() =>
            {
                return _data;
            });
        }
    }
}
