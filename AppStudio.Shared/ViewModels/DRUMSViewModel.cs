using System;
using System.Windows;
using System.Windows.Input;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

using AppStudio.Services;
using AppStudio.Data;

namespace AppStudio.ViewModels
{
    public class DRUMSViewModel : ViewModelBase<DRUMSSchema>
    {
        private RelayCommandEx<DRUMSSchema> itemClickCommand;
        public RelayCommandEx<DRUMSSchema> ItemClickCommand
        {
            get
            {
                if (itemClickCommand == null)
                {
                    itemClickCommand = new RelayCommandEx<DRUMSSchema>(
                        (item) =>
                        {

                            NavigationServices.NavigateToPage("DRUMSDetail", item);
                        });
                }

                return itemClickCommand;
            }
        }

        override protected DataSourceBase<DRUMSSchema> CreateDataSource()
        {
            return new DRUMSDataSource(); // CollectionDataSource
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
            NavigationServices.NavigateToPage("DRUMSList");
        }

        override protected void NavigateToSelectedItem()
        {
            NavigationServices.NavigateToPage("DRUMSDetail");
        }
    }
}
