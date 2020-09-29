using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStudio.Data
{
    public class TYPESOFINSTRUMENTSDataSource : DataSourceBase<TYPESOFINSTRUMENTSSchema>
    {
        protected override string CacheKey
        {
            get { return "TYPESOFINSTRUMENTSDataSource"; }
        }

        public override bool HasStaticData
        {
            get { return true; }
        }

        private readonly IEnumerable<TYPESOFINSTRUMENTSSchema> _data = new TYPESOFINSTRUMENTSSchema[]
		{
            new TYPESOFINSTRUMENTSSchema
            {
                Title = "Wind Instruments",
                Subtitle = "Air blown instruments ",
                ImageUrl = "/Assets/DataImages/woodwind-instruments-300x297-1.jpg",
                Description = @"Wind instruments require a person to blow into the instrument in order to produce the desired sound. They work on the principle of sound waves, frequencies, harmonics, resonance and acoustics. When you blow into the instrument, the pitch of the sound note produced, varies depending on the length of the internal air column in which the sound waves vibrate. The shorter the air column, the higher is the pitch of the note produced, and vice versa. Some of the popular wind instruments are:

♪Flute
♪Piccolo
♪Shakuhachi
♪Clarinet
♪Bassoon
♪English horn
♪Oboe
♪Accordion
♪Saxophone
♪Shehnai
♪Bagpipe
♪Pianica
♪Harmonica",
            },
            new TYPESOFINSTRUMENTSSchema
            {
                Title = "Percussion Instruments",
                Subtitle = "Striking instruments",
                ImageUrl = "/Assets/DataImages/percussion-1.gif",
                Description = @"Percussion instruments require a person to strike or beat the instrument surface in order to generate vibrations, which then produce the desired sound note. Depending on the type of surface, one can use one's hands, sticks, or other similar objects for striking the instrument surface. A characteristic feature of percussion instruments is that the type of sound produced varies depending on the spot that is struck on the instrument surface. For example: in case of the djembe, striking it at the center produces a deep and muffled sort of thump, whereas striking it at the edges produces a sharp and crisp sound, which is totally different from the earlier one. Some of the well-known percussion instruments are:

♫Drum
♫Congo
♫Djembe
♫Duff
♫Tabla
♫Dhol
♫Nagara
♫Cymbals
♫Bells
♫Xylophone
♫Marimba
♫Triangle
♫Tambourine",
            },
            new TYPESOFINSTRUMENTSSchema
            {
                Title = "Brass Instruments",
                Subtitle = "Shiny trumpets and trombones",
                ImageUrl = "/Assets/DataImages/brass-instruments-1.jpg",
                Description = @"All those shiny trumpets and trombones that feature so prominently in jazz and blues' music are classic examples of brass instruments. Brass instruments are named so, not because all of them are made from brass, but due to the nature and texture of the sound that they produce. They work on pretty much the same principle as wind instruments, with a few modifications here and there. In case of brass instruments, the length of the air column can be changed using press valves or through a slide mechanism. Some of the popular ones are:

♪Trumpet
♪Trombone
♪Bugle
♪French horn
♪Conch
♪Tuba
♪Alto Horn
♪Bazooka
♪Cimbasso
♪Flatt trumpet",
            },
            new TYPESOFINSTRUMENTSSchema
            {
                Title = "String Instruments",
                Subtitle = "Instruments with strings ",
                ImageUrl = "/Assets/DataImages/stringed-instruments-flute-587-1.jpg",
                Description = @"All your guitars, violins and pianos fall under the category of string instruments. String instruments work on the basis of sound wave vibrations that are created with the help of strings. The pitch of the sound note produced depends on the length of the air column as well as the type and thickness of the string involved. Some of the famous string instruments are:

♫Guitar
♫Piano
♫Violin
♫Viola
♫Sitar
♫Cello
♫Double Bass
♫Mandolin
♫Banjo
♫Harp
♫Sarod
♫Santoor",
            },
            new TYPESOFINSTRUMENTSSchema
            {
                Title = "Electronic Instruments",
                Subtitle = "Modern instruments ",
                ImageUrl = "/Assets/DataImages/mag-1295264913-1.png",
                Description = @"These are some of the newer musical instruments that have been produced in recent years with the advent of technology. Most of them are designed to reproduce the sounds of existing musical instruments in a simple and user-friendly way. Some of the common electronic instruments include: 

♪Piano keyboards
♪Octopads
♪Rhythm machines
♪Samplers
♪Synthesizers
♪Synclavier
♪Theremin
♪Eigenharp
♪Mellotron
♪Omnichord
",
            },
		};

        public async override Task<IEnumerable<TYPESOFINSTRUMENTSSchema>> LoadDataAsync()
        {
            return await Task.Run(() =>
            {
                return _data;
            });
        }
    }
}
