using System;
using SpeechToText.Implementation.ViewController;
using SpeechToText.Trunk.ViewModel;
using SpeechToText.Root.View;
using Xamarin.Forms;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace SpeechToText.Implementation.View
{
    public partial class FoodListFromSpeachView : ProjectBaseContentPage<FoodListFromSpeachViewController, FoodListFromSpeachViewModel>
    {
        public FoodListFromSpeachView()
        {
            InitializeComponent();
            BindingContext = _ViewController.InputObject;
        }

        public void AddFood(object sender, EventArgs e)
        {
            _ViewController.AddFood();
        }

        public void RecordAudio(object sender, EventArgs e)
        {
            _ViewController.SetAudioRecording();
        }

        void Speak(System.Object sender, System.EventArgs e)
        {
            _ViewController.EngageVoice()();
        }
        //#Bonsai Snippets - ViewControllerMethodCalls
    }
}


