using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fish.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapMasterDetailMaster : ContentPage
    {
        public ListView ListView;

        public MapMasterDetailMaster()
        {
            InitializeComponent();

            BindingContext = new MapMasterDetailMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MapMasterDetailMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MapMasterDetailMasterMenuItem> MenuItems { get; set; }

            public MapMasterDetailMasterViewModel()
            {
                MenuItems = new ObservableCollection<MapMasterDetailMasterMenuItem>(new[]
                {
                    new MapMasterDetailMasterMenuItem { Id = 0, Title = "Settings" },
                    new MapMasterDetailMasterMenuItem { Id = 1, Title = "Edit Catches" },
                    new MapMasterDetailMasterMenuItem { Id = 2, Title = "Version Information"},
                    new MapMasterDetailMasterMenuItem { Id = 3, Title = "Sign Out" },
                   
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}