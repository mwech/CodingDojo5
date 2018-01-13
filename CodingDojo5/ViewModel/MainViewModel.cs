using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System.Collections.ObjectModel;
using System;

namespace CodingDojo5.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<ItemVM> Items { get; set; }
        public ObservableCollection<ItemVM> Cart { get; set; }
        private ItemVM selectedItem;
        private RelayCommand<ItemVM> buyBtnClicked;

        public RelayCommand<ItemVM> BuyBtnClicked
        {
            get { return buyBtnClicked; }
            set { buyBtnClicked = value; RaisePropertyChanged(); }
        }


        public ItemVM SelectedItem
        {
            get { return selectedItem; }
            set { selectedItem = value; RaisePropertyChanged("SelectedItem"); }
        }


        public MainViewModel()
        {
            Items = new ObservableCollection<ItemVM>();
            Cart = new ObservableCollection<ItemVM>();
            BuyBtnClicked = new RelayCommand<ItemVM>(BuyBtnClick, BuyBtnEnabled);
            GenerateDemoData();

        }

        private bool BuyBtnEnabled(ItemVM arg)
        {
            return arg != null;
        }

        private void BuyBtnClick(ItemVM obj)
        {
            if(obj != null) Cart.Add(obj);
        }

        private void GenerateDemoData()
        {
           // Items.Add(new ItemVM("Playmobil", "3+", );
        }
    }
}