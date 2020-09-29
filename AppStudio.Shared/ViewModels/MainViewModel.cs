using System;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Net.NetworkInformation;

using Windows.UI.Xaml;

using AppStudio.Services;
using AppStudio.Data;

namespace AppStudio.ViewModels
{
    public class MainViewModel : BindableBase
    {
       private MuSiCViewModel _muSiCModel;
       private MUSICALINSTRUMENTSViewModel _mUSICALINSTRUMENTSModel;
       private TYPESOFINSTRUMENTSViewModel _tYPESOFINSTRUMENTSModel;
       private HOWTOPLAYViewModel _hOWTOPLAYModel;
       private MUsIcNEWSViewModel _mUsIcNEWSModel;
       private ViSuAlSViewModel _viSuAlSModel;
        private PrivacyViewModel _privacyModel;

        private ViewModelBase _selectedItem = null;

        public MainViewModel()
        {
            _selectedItem = MuSiCModel;
            _privacyModel = new PrivacyViewModel();

        }
 
        public MuSiCViewModel MuSiCModel
        {
            get { return _muSiCModel ?? (_muSiCModel = new MuSiCViewModel()); }
        }
 
        public MUSICALINSTRUMENTSViewModel MUSICALINSTRUMENTSModel
        {
            get { return _mUSICALINSTRUMENTSModel ?? (_mUSICALINSTRUMENTSModel = new MUSICALINSTRUMENTSViewModel()); }
        }
 
        public TYPESOFINSTRUMENTSViewModel TYPESOFINSTRUMENTSModel
        {
            get { return _tYPESOFINSTRUMENTSModel ?? (_tYPESOFINSTRUMENTSModel = new TYPESOFINSTRUMENTSViewModel()); }
        }
 
        public HOWTOPLAYViewModel HOWTOPLAYModel
        {
            get { return _hOWTOPLAYModel ?? (_hOWTOPLAYModel = new HOWTOPLAYViewModel()); }
        }
 
        public MUsIcNEWSViewModel MUsIcNEWSModel
        {
            get { return _mUsIcNEWSModel ?? (_mUsIcNEWSModel = new MUsIcNEWSViewModel()); }
        }
 
        public ViSuAlSViewModel ViSuAlSModel
        {
            get { return _viSuAlSModel ?? (_viSuAlSModel = new ViSuAlSViewModel()); }
        }

        public void SetViewType(ViewTypes viewType)
        {
            MuSiCModel.ViewType = viewType;
            MUSICALINSTRUMENTSModel.ViewType = viewType;
            TYPESOFINSTRUMENTSModel.ViewType = viewType;
            HOWTOPLAYModel.ViewType = viewType;
            MUsIcNEWSModel.ViewType = viewType;
            ViSuAlSModel.ViewType = viewType;
        }

        public ViewModelBase SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                SetProperty(ref _selectedItem, value);
                UpdateAppBar();
            }
        }

        public Visibility AppBarVisibility
        {
            get
            {
                return SelectedItem == null ? AboutVisibility : SelectedItem.AppBarVisibility;
            }
        }

        public Visibility AboutVisibility
        {

         get { return Visibility.Visible; }
        }

        public void UpdateAppBar()
        {
            OnPropertyChanged("AppBarVisibility");
            OnPropertyChanged("AboutVisibility");
        }

        /// <summary>
        /// Load ViewModel items asynchronous
        /// </summary>
        public async Task LoadDataAsync(bool forceRefresh = false)
        {
            var loadTasks = new Task[]
            { 
                MuSiCModel.LoadItemsAsync(forceRefresh),
                MUSICALINSTRUMENTSModel.LoadItemsAsync(forceRefresh),
                TYPESOFINSTRUMENTSModel.LoadItemsAsync(forceRefresh),
                HOWTOPLAYModel.LoadItemsAsync(forceRefresh),
                MUsIcNEWSModel.LoadItemsAsync(forceRefresh),
                ViSuAlSModel.LoadItemsAsync(forceRefresh),
            };
            await Task.WhenAll(loadTasks);
        }

        //
        //  ViewModel command implementation
        //
        public ICommand RefreshCommand
        {
            get
            {
                return new DelegateCommand(async () =>
                {
                    await LoadDataAsync(true);
                });
            }
        }

        public ICommand AboutCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    NavigationServices.NavigateToPage("AboutThisAppPage");
                });
            }
        }

        public ICommand PrivacyCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    NavigationServices.NavigateTo(_privacyModel.Url);
                });
            }
        }
    }
}
