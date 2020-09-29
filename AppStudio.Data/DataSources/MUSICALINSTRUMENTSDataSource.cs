using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStudio.Data
{
    public class MUSICALINSTRUMENTSDataSource : DataSourceBase<MUSICALINSTRUMENTSSchema>
    {
        protected override string CacheKey
        {
            get { return "MUSICALINSTRUMENTSDataSource"; }
        }

        public override bool HasStaticData
        {
            get { return true; }
        }

        private readonly IEnumerable<MUSICALINSTRUMENTSSchema> _data = new MUSICALINSTRUMENTSSchema[]
		{
            new MUSICALINSTRUMENTSSchema
            {
                Title = "INSTRUMENTS",
                Subtitle = "A musical instrument is an instrument created or adapted to make musical sounds. " +
    "In principle, any object that produces sound can be a musical instrument—it is t" +
    "hrough purpose that the object becomes a musical instrument.",
                Image = "/Assets/DataImages/3d-musical-instruments-1280x800.jpg",
                Description = @"The date and origin of the first device considered a musical instrument is disputed. The oldest object that some scholars refer to as a musical instrument, a simple flute, dates back as far as 67,000 years. Some consensus dates early flutes to about 37,000 years ago. However, most historians believe that determining a specific time of musical instrument invention is impossible due to the subjectivity of the definition and the relative instability of materials used to make them. Many early musical instruments were made from animal skins, bone, wood, and other non-durable materials.

Musical instruments developed independently in many populated regions of the world. However, contact among civilizations caused rapid spread and adaptation of most instruments in places far from their origin. By the Middle Ages, instruments from Mesopotamia were in Maritime Southeast Asia, and Europeans played instruments from North Africa. Development in the Americas occurred at a slower pace, but cultures of North, Central, and South America shared musical instruments. By 1400, musical instrument development slowed in many areas and was dominated by the Occident.",
            },
            new MUSICALINSTRUMENTSSchema
            {
                Title = "STUDY OF INSTRUMENTS",
                Subtitle = "Musical instruments are constructed in a broad array of styles and shapes, using " +
    "many different materials. Early musical instruments were made from \"found object" +
    "s\" such a shells and plant parts",
                Image = "/Assets/DataImages/image1.jpg",
                Description = @"Musical instrument classification is a discipline in its own right, and many systems of classification have been used over the years. Instruments can be classified by their effective range, their material composition, their size, etc. However, the most common academic method, Hornbostel-Sachs, uses the means by which they produce sound. The academic study of musical instruments is called organology.

",
            },
		};

        public async override Task<IEnumerable<MUSICALINSTRUMENTSSchema>> LoadDataAsync()
        {
            return await Task.Run(() =>
            {
                return _data;
            });
        }
    }
}
