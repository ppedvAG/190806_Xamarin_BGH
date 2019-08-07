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

namespace Navigation_Demo.MD
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPage_RootMaster : ContentPage
    {
        public ListView ListView;

        public MasterDetailPage_RootMaster()
        {
            InitializeComponent();

            BindingContext = new MasterDetailPage_RootMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterDetailPage_RootMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterDetailPage_RootMasterMenuItem> MenuItems { get; set; }

            public MasterDetailPage_RootMasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterDetailPage_RootMasterMenuItem>(new[]
                {
                    new MasterDetailPage_RootMasterMenuItem { Id = 0, Title = "Page 1" },
                    new MasterDetailPage_RootMasterMenuItem { Id = 1, Title = "Page 2" },
                    new MasterDetailPage_RootMasterMenuItem { Id = 2, Title = "Page 3" },
                    new MasterDetailPage_RootMasterMenuItem { Id = 3, Title = "Page 4" },
                    new MasterDetailPage_RootMasterMenuItem { Id = 4, Title = "Page 5" },
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