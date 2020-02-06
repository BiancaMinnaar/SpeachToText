using System.Collections.Generic;
using System.Threading.Tasks;
using SpeechToText.Trunk.ViewModel;

namespace SpeechToText.Interface.Repository
{
    public interface IFoodListFromSpeachRepository<T>
    {
        void AddFood(FoodListFromSpeachViewModel model);
        //#Bonsai Snippets - MethodInterfaces
    }
}
