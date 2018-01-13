using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;

namespace CodingDojo5.ViewModel
{
    public class ItemVM
    {
        public string Description { get; set; }
        public string AgeRecommendation { get; set; }
        public BitmapImage Image { get; set; }
        public ObservableCollection<ItemVM> ItemList { get; set; }

        public ItemVM(string description, string ageRecommendation, BitmapImage image)
        {
            Description = description;
            AgeRecommendation = ageRecommendation;
            Image = image;
        }

        public void addItem(ItemVM item)
        {
            if (ItemList == null) ItemList = new ObservableCollection<ItemVM>();
            ItemList.Add(item);
        }





    }
}