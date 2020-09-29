using System;
using System.Windows;
using System.Windows.Input;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

using AppStudio.Services;
using AppStudio.Data;

namespace AppStudio.ViewModels
{
    public class KEYBOARDViewModel : ViewModelBase<KEYBOARDSchema>
    {
        private RelayCommandEx<KEYBOARDSchema> itemClickCommand;
        public RelayCommandEx<KEYBOARDSchema> ItemClickCommand
        {
            get
            {
                if (itemClickCommand == null)
                {
                    itemClickCommand = new RelayCommandEx<KEYBOARDSchema>(
                        (item) =>
                        {

                            NavigationServices.NavigateToPage("KEYBOARDDetail", item);
                        });
                }

                return itemClickCommand;
            }
        }

        override protected DataSourceBase<KEYBOARDSchema> CreateDataSource()
        {
            return new KEYBOARDDataSource(); // CollectionDataSource
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
            await base.SpeakText("Description");
        }

        override public void NavigateToSectionList()
        {
            NavigationServices.NavigateToPage("KEYBOARDList");
        }

        override protected void NavigateToSelectedItem()
        {
            NavigationServices.NavigateToPage("KEYBOARDDetail");
        }
    }
}
