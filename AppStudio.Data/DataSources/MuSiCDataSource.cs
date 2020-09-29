using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStudio.Data
{
    public class MuSiCDataSource : DataSourceBase<HtmlSchema>
    {
        private IEnumerable<HtmlSchema> _data = new HtmlSchema[]
        {
            new HtmlSchema
            {
                Id = "{67ddfe7e-6114-4c84-9620-925e6ea06a62}",
                Content = "<span class=\"wysiwyg-font-size-medium\">\n\n</span><p>\nMusic is an art form whose me" +
    "dium is sound and silence. Its common elements are pitch (which governs melody a" +
    "nd harmony), rhythm (and its associated concepts tempo, meter, and articulation)" +
    ", dynamics, and the sonic qualities of timbre and texture. The word derives from" +
    " Greek μουσική (mousike; \"art of the Muses\").\n</p>\n\nThe creation, performance, s" +
    "ignificance, and even the definition of music vary according to culture and soci" +
    "al context. Music ranges from strictly organized compositions (and their recreat" +
    "ion in performance), through improvisational music to aleatoric forms. Music can" +
    " be divided into genres and subgenres, although the dividing lines and relations" +
    "hips between music genres are often subtle, sometimes open to personal interpret" +
    "ation, and occasionally controversial. Within the arts, music may be classified " +
    "as a performing art, a fine art, and auditory art. It may also be divided among " +
    "art music and folk music. There is also a strong connection between music and ma" +
    "thematics. Music may be played and heard live, may be part of a dramatic work or" +
    " film, or may be recorded.\n\nTo many people in many cultures, music is an importa" +
    "nt part of their way of life. Ancient Greek and Indian philosophers defined musi" +
    "c as tones ordered horizontally as melodies and vertically as harmonies. Common " +
    "sayings such as \"the harmony of the spheres\" and \"it is music to my ears\" point " +
    "to the notion that music is often ordered and pleasant to listen to. However, 20" +
    "th-century composer John Cage thought that any sound can be music, saying, for e" +
    "xample, \"There is no noise, only sound.\" Musicologist Jean-Jacques Nattiez summa" +
    "rizes the relativist, post-modern viewpoint: \"The border between music and noise" +
    " is always culturally defined—which implies that, even within a single society, " +
    "this border does not always pass through the same place; in short, there is rare" +
    "ly a consensus ... By all accounts there is no single and intercultural universa" +
    "l concept defining what music might be.\"&nbsp;"
            }
        };

        protected override string CacheKey
        {
            get { return "MuSiCDataSource"; }
        }

        public override bool HasStaticData
        {
            get { return true; }
        }

        public async override Task<IEnumerable<HtmlSchema>> LoadDataAsync()
        {
            return await Task.Run(() =>
            {
                return _data;
            });
        }
    }
}
