using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System.Collections.ObjectModel;
using System;
using System.Windows.Media.Imaging;

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
            Items.Add(new ItemVM("Lego", "", new BitmapImage(new Uri("img/lego1.jpg",UriKind.Relative))));
            Items.Add(new ItemVM("Playmobil", "", new BitmapImage(new Uri("img/playmobil1.jpg", UriKind.Relative))));
            Items[Items.Count - 1].addItem(new ItemVM("Playmobil1", "3+", new BitmapImage(new Uri("img/playmobil1.jpg", UriKind.Relative))));
            Items[Items.Count - 1].addItem(new ItemVM("Playmobil2", "3+", new BitmapImage(new Uri("img/playmobil2.jpg", UriKind.Relative))));
            Items[Items.Count - 1].addItem(new ItemVM("Playmobil3", "3+", new BitmapImage(new Uri("img/playmobil3.jpg", UriKind.Relative))));
            Items[Items.Count - 2].addItem(new ItemVM("Lego1", "5+", new BitmapImage(new Uri("img/lego1.jpg", UriKind.Relative))));
            Items[Items.Count - 2].addItem(new ItemVM("Lego2", "5+", new BitmapImage(new Uri("img/lego2.jpg", UriKind.Relative))));
            Items[Items.Count - 2].addItem(new ItemVM("Lego3", "5+", new BitmapImage(new Uri("img/lego3.jpg", UriKind.Relative))));
            Items[Items.Count - 2].addItem(new ItemVM("Lego4", "5+", new BitmapImage(new Uri("img/lego4.jpg", UriKind.Relative))));
        }
    }
}