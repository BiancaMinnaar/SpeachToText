using System.Collections.ObjectModel;
using System.ComponentModel;
using SpeechToText.Root.ViewModel;

namespace SpeechToText.Trunk.ViewModel
{
    public class FoodListFromSpeachViewModel : ProjectBaseViewModel, INotifyPropertyChanged
    {
        public new event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<FoodViewModel> foodList;
        public ObservableCollection<FoodViewModel> FoodList
        {
            get { return foodList; }
            set
            {
                foodList = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FoodList"));
            }
        }
 //#Bonsai Snippets - Properties
    }
}