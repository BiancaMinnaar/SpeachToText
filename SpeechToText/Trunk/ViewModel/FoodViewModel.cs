using System.ComponentModel;
using SpeechToText.Root.ViewModel;

namespace SpeechToText.Trunk.ViewModel
{
    public class FoodViewModel : ProjectBaseViewModel, INotifyPropertyChanged
    {
        public new event PropertyChangedEventHandler PropertyChanged;

       private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }
private string category;
        public string Category
        {
            get { return category; }
            set
            {
                category = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Category"));
            }
        }
 //#Bonsai Snippets - Properties
    }
}