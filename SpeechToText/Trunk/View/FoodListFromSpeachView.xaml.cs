using System;
using SpeechToText.Implementation.ViewController;
using SpeechToText.Trunk.ViewModel;
using SpeechToText.Root.View;
using Xamarin.Forms;

namespace SpeechToText.Implementation.View
{
    public partial class FoodListFromSpeachView : ProjectBaseContentPage<FoodListFromSpeachViewController, FoodListFromSpeachViewModel>
    {
        public FoodListFromSpeachView()
        {
            InitializeComponent();
            BindingContext = _ViewController.InputObject;
        }

        //#Bonsai Snippets - ViewControllerMethodCalls
    }
}


