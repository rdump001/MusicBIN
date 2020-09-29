using System;
using System.Windows;
using System.Windows.Input;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

using AppStudio.Services;
using AppStudio.Data;

namespace AppStudio.ViewModels
{
    public class GUITARViewModel : ViewModelBase<GUITARSchema>
    {
        private RelayCommandEx<GUITARSchema> itemClickCommand;
        public RelayCommandEx<GUITARSchema> ItemClickCommand
        {
            get
            {
                if (itemClickCommand == null)
                {
                    itemClickCommand = new RelayCommandEx<GUITARSchema>(
                        (item) =>
                        {

                            NavigationServices.NavigateToPage("GUITARDetail", item);
                        });
                }

                return itemClickCommand;
            }
        }

        override protected DataSourceBase<GUITARSchema> CreateDataSource()
        {
            return new GUITARDataSource(); // CollectionDataSource
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
            NavigationServices.NavigateToPage("GUITARList");
        }

        override protected void NavigateToSelectedItem()
        {
            NavigationServices.NavigateToPage("GUITARDetail");
        }
    }
}
