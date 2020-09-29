using System;
using System.Windows;
using System.Windows.Input;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

using AppStudio.Services;
using AppStudio.Data;

namespace AppStudio.ViewModels
{
    public class MuSiCViewModel : ViewModelBase<HtmlSchema>
    {
        private RelayCommandEx<HtmlSchema> itemClickCommand;
        public RelayCommandEx<HtmlSchema> ItemClickCommand
        {
            get
            {
                if (itemClickCommand == null)
                {
                    itemClickCommand = new RelayCommandEx<HtmlSchema>(
                        (item) =>
                        {

                            NavigationServices.NavigateToPage("", item);
                        });
                }

                return itemClickCommand;
            }
        }

        override protected DataSourceBase<HtmlSchema> CreateDataSource()
        {
            return new MuSiCDataSource(); // HtmlDataSource
        }


        override public ViewTypes ViewType
        {
            get { return ViewTypes.Detail; }
        }

        override public Visibility ShareItemVisibility
        {
            get { return ViewType == ViewTypes.Detail ? Visibility.Visible : Visibility.Collapsed; }
        }

        override public Visibility TextToSpeechVisibility
        {
            get { return ViewType == ViewTypes.Detail ? Visibility.Visible : Visibility.Collapsed; }
        }

        override protected async void TextToSpeech()
        {
            await base.SpeakText("Content");
        }
    }
}
