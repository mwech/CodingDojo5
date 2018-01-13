using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;

namespace CodingDojo5.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<ItemVM> Items { get; set; }
        public ObservableCollection<ItemVM> Cart { get; set; }
        private ItemVM selectedItem;

        public ItemVM SelectedItem
        {
            get { return selectedItem; }
            set { selectedItem = value; RaisePropertyChanged("SelectedItem"); }
        }


        public MainViewModel()
        {
            Items = new ObservableCollection<ItemVM>();
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
        }
    }
}