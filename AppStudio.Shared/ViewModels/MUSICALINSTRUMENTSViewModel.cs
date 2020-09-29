using System;
using System.Windows;
using System.Windows.Input;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

using AppStudio.Services;
using AppStudio.Data;

namespace AppStudio.ViewModels
{
    public class MUSICALINSTRUMENTSViewModel : ViewModelBase<MUSICALINSTRUMENTSSchema>
    {
        private RelayCommandEx<MUSICALINSTRUMENTSSchema> itemClickCommand;
        public RelayCommandEx<MUSICALINSTRUMENTSSchema> ItemClickCommand
        {
            get
            {
                if (itemClickCommand == null)
                {
                    itemClickCommand = new RelayCommandEx<MUSICALINSTRUMENTSSchema>(
                        (item) =>
                        {

                            NavigationServices.NavigateToPage("MUSICALINSTRUMENTSDetail", item);
                        });
                }

                return itemClickCommand;
            }
        }

        override protected DataSourceBase<MUSICALINSTRUMENTSSchema> CreateDataSource()
        {
            return new MUSICALINSTRUMENTSDataSource(); // CollectionDataSource
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
            NavigationServices.NavigateToPage("MUSICALINSTRUMENTSList");
        }

        override protected void NavigateToSelectedItem()
        {
            NavigationServices.NavigateToPage("MUSICALINSTRUMENTSDetail");
        }
    }
}
