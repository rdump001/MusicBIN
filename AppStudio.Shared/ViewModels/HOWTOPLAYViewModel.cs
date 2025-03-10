using System;
using System.Windows;
using System.Windows.Input;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

using AppStudio.Services;
using AppStudio.Data;

namespace AppStudio.ViewModels
{
    public class HOWTOPLAYViewModel : ViewModelBase<MenuSchema>
    {
        private RelayCommandEx<MenuSchema> itemClickCommand;
        public RelayCommandEx<MenuSchema> ItemClickCommand
        {
            get
            {
                if (itemClickCommand == null)
                {
                    itemClickCommand = new RelayCommandEx<MenuSchema>(
                        (item) =>
                        {

                            if (item.GetValue("Type").EqualNoCase("Section"))
                            {
                                NavigationServices.NavigateToPage(item.GetValue("Target"));
                                }
                                else
                                {
                                    var targetUri = TryCreateUri(item.GetValue("Target"));
                                    if (targetUri != null)
                                    {
                                        NavigationServices.NavigateTo(targetUri);
                                    }
                                }
                        });
                }

                return itemClickCommand;
            }
        }

        override protected DataSourceBase<MenuSchema> CreateDataSource()
        {
            return new HOWTOPLAYDataSource(); // MenuDataSource
        }


        override public bool HasMoreItems
        {
            get { return false; }
        }

        override protected void NavigateToSelectedItem()
        {
            var currentItem = GetCurrentItem();
            if (currentItem != null)
            {
                if (currentItem.GetValue("Type").EqualNoCase("Section"))
                {
                    NavigationServices.NavigateToPage(currentItem.GetValue("Target"));
                }
                else
                {
                    NavigationServices.NavigateTo(new Uri(currentItem.GetValue("Target"), UriKind.Absolute));
                }
            }
        }
    }
}
