using System;
using System.Windows;
using System.Windows.Input;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

using AppStudio.Services;
using AppStudio.Data;

namespace AppStudio.ViewModels
{
    public class VIOLINViewModel : ViewModelBase<VIOLINSchema>
    {
        private RelayCommandEx<VIOLINSchema> itemClickCommand;
        public RelayCommandEx<VIOLINSchema> ItemClickCommand
        {
            get
            {
                if (itemClickCommand == null)
                {
                    itemClickCommand = new RelayCommandEx<VIOLINSchema>(
                        (item) =>
                        {

                            NavigationServices.NavigateToPage("VIOLINDetail", item);
                        });
                }

                return itemClickCommand;
            }
        }

        override protected DataSourceBase<VIOLINSchema> CreateDataSource()
        {
            return new VIOLINDataSource(); // CollectionDataSource
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
            NavigationServices.NavigateToPage("VIOLINList");
        }

        override protected void NavigateToSelectedItem()
        {
            NavigationServices.NavigateToPage("VIOLINDetail");
        }
    }
}
