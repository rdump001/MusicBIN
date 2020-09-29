using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStudio.Data
{
    public class HOWTOPLAYDataSource : DataSourceBase<MenuSchema>
    {
        private readonly IEnumerable<MenuSchema> _data = new MenuSchema[]
		{
            new MenuSchema
            {
                Type = "Section",
                Title = "GUITAR",
                Icon = "/Assets/DataImages/bto-photo-gallery-taylor-guitars.png",
                Target = "GUITARPage",
            },
            new MenuSchema
            {
                Type = "Section",
                Title = "VIOLIN",
                Icon = "/Assets/DataImages/Stradivari-violin-008.png",
                Target = "VIOLINPage",
            },
            new MenuSchema
            {
                Type = "Section",
                Title = "KEYBOARD",
                Icon = "/Assets/DataImages/index.png",
                Target = "KEYBOARDPage",
            },
            new MenuSchema
            {
                Type = "Section",
                Title = "DRUMS",
                Icon = "/Assets/DataImages/11954457081755467152TheresaKnott_Drum_Kit.svg.hi.png",
                Target = "DRUMSPage",
            },
		};

        protected override string CacheKey
        {
            get { return "HOWTOPLAYDataSource"; }
        }

        public override bool HasStaticData
        {
            get { return true; }
        }

        public async override Task<IEnumerable<MenuSchema>> LoadDataAsync()
        {
            return await Task.Run(() =>
            {
                return _data;
            });
        }
    }
}
