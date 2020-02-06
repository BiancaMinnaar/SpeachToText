using System.Threading.Tasks;
using SpeechToText.Root.Repository;
using SpeechToText.Trunk.ViewModel;
using SpeechToText.Interface.Repository;
using SpeechToText.Interface.Service;

namespace SpeechToText.Implementation.Repository
{
    public class FoodListFromSpeachRepository<T> : ProjectBaseRepository, IFoodListFromSpeachRepository<T>
    {
        IFoodListFromSpeachService<T> _Service;
        
        public FoodListFromSpeachRepository(IMasterRepository masterRepository, IFoodListFromSpeachService<T> service)
            : base(masterRepository)
        {
            _Service = service;
        }

        public void AddFood(FoodListFromSpeachViewModel model)
        {
            model.FoodList.Add(new FoodViewModel
            {
                Name = model.FoodItemToAdd,
                Category = "Test"
            });
        }

        //#Bonsai Snippets - MethodDefinitions
    }
}