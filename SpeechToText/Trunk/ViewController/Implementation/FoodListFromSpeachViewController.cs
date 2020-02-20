using System.Threading.Tasks;
using SpeechToText.Interface.ViewController;
using SpeechToText.Trunk.ViewModel;
using SpeechToText.Root.ViewController;
using System;
using SpeechToText.Implementation.Repository;
using SpeechToText.Implementation.Service;
using SpeechToText.Interface.Repository;
using SpeechToText.Interface.Service;
using Speech;
using Xamarin.Essentials;
//#Bonsai Snippets - Usings

namespace SpeechToText.Implementation.ViewController
{
    public class FoodListFromSpeachViewController : ProjectBaseViewController<FoodListFromSpeachViewModel>, IFoodListFromSpeachViewController
    {
        IFoodListFromSpeachRepository<FoodListFromSpeachViewModel> _Repository;
        IFoodListFromSpeachService<FoodListFromSpeachViewModel> _Service;

        //#Bonsai Snippets - Declarations
        public override void SetRepositories()
        {
            _Service = new FoodListFromSpeachService<FoodListFromSpeachViewModel>((U, C, A) => 
                ExecuteQueryWithReturnTypeAndNetworkAccessAsync<FoodListFromSpeachViewModel>(U, C, A));
            _Repository = new FoodListFromSpeachRepository<FoodListFromSpeachViewModel>(_MasterRepo, _Service);
            //#Bonsai Snippets - ServicedRepos
            SFSpeechRecognizer.RequestAuthorization((SFSpeechRecognizerAuthorizationStatus status) => {
                // Take action based on status
                switch (status)
                {
                    case SFSpeechRecognizerAuthorizationStatus.Authorized:
                        
                    break;
                    case SFSpeechRecognizerAuthorizationStatus.Denied:
                        
                    break;
                    case SFSpeechRecognizerAuthorizationStatus.NotDetermined:
                        
                    break;
                    case SFSpeechRecognizerAuthorizationStatus.Restricted:
                       
                    break;
                }
            });
        }

        public Func<Task> EngageVoice()
        {
            return async () =>
            {
                await TextToSpeech.SpeakAsync("Please say Apple into the microphone while holding record.");
            };
        }

        internal void AddFood()
        {
            _Repository.AddFood(InputObject);
        }

        internal void SetAudioRecording()
        {
            _Repository.GetTextForRecording(InputObject);
        }

        //#Bonsai Snippets - Methods
    }
}