using System;
using System.Windows;
using System.Windows.Input;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

using AppStudio.Services;
using AppStudio.Data;

namespace AppStudio.ViewModels
{
    public class TYPESOFINSTRUMENTSViewModel : ViewModelBase<TYPESOFINSTRUMENTSSchema>
    {
        private RelayCommandEx<TYPESOFINSTRUMENTSSchema> itemClickCommand;
        public RelayCommandEx<TYPESOFINSTRUMENTSSchema> ItemClickCommand
        {
            get
            {
                if (itemClickCommand == null)
                {
                    itemClickCommand = new RelayCommandEx<TYPESOFINSTRUMENTSSchema>(
                        (item) =>
                        {

                            NavigationServices.NavigateToPage("TYPESOFINSTRUMENTSDetail", item);
                        });
                }

                return itemClickCommand;
            }
        }

        override protected DataSourceBase<TYPESOFINSTRUMENTSSchema> CreateDataSource()
        {
            return new TYPESOFINSTRUMENTSDataSource(); // CollectionDataSource
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
            NavigationServices.NavigateToPage("TYPESOFINSTRUMENTSList");
        }

        override protected void NavigateToSelectedItem()
        {
            NavigationServices.NavigateToPage("TYPESOFINSTRUMENTSDetail");
        }
    }
}
