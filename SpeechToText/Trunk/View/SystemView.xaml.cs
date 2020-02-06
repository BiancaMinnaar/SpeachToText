using System;
using SpeechToText.Implementation.ViewController;
using SpeechToText.Trunk.ViewModel;
using SpeechToText.Root.View;
using Xamarin.Forms;

namespace SpeechToText.Implementation.View
{
    public partial class SystemView : ProjectBaseContentPage<SystemViewController, SystemViewModel>
    {
        public SystemView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = _ViewController.InputObject;
        }

        //#Bonsai Snippets - ViewControllerMethodCalls
    }
}
