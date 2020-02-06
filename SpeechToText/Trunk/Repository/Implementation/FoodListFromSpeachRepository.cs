using System.Threading.Tasks;
using SpeechToText.Root.Repository;
using SpeechToText.Trunk.ViewModel;
using SpeechToText.Interface.Repository;
using SpeechToText.Interface.Service;
using SpeechToText.Trunk.Service;
using Xamarin.Forms;

namespace SpeechToText.Implementation.Repository
{
    public class FoodListFromSpeachRepository<T> : ProjectBaseRepository, IFoodListFromSpeachRepository<T>
    {
        IFoodListFromSpeachService<T> _Service;
        IRecordAndInterperateSpeech speechService;
        
        public FoodListFromSpeachRepository(IMasterRepository masterRepository, IFoodListFromSpeachService<T> service)
            : base(masterRepository)
        {
            _Service = service;
            speechService = DependencyService.Get<IRecordAndInterperateSpeech>();
        }

        public void AddFood(FoodListFromSpeachViewModel model)
        {
            model.FoodList.Add(new FoodViewModel
            {
                Name = model.FoodItemToAdd,
                Category = "Test"
            });
        }

        public void GetTextForRecording(FoodListFromSpeachViewModel model)
        {
            if (!model.IsRecording)
            {
                model.IsRecording = true;
                speechService.TranslateSpeachToText(model);
            }
            else
            {
                model.IsRecording = false;
                speechService.StopInterpreting();
                
            }
        }

        //#Bonsai Snippets - MethodDefinitions
    }
}