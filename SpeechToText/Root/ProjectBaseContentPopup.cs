using Rg.Plugins.Popup.Pages;
using SpeechToText.Root.ViewController;
using SpeechToText.Root.ViewModel;
using SpeechToText.Trunk.Repository.Implementation;

namespace SpeechToText.Root.View
{
    public abstract class ProjectBaseContentPopup<T, M> : PopupPage
        where T : ProjectBaseViewController<M>, new()
        where M : ProjectBaseViewModel, new()
    {
        protected T _ViewController;

        protected ProjectBaseContentPopup()
        {
            _ViewController = new T
            {
                InputObject = new M(),
                _MasterRepo = MasterRepository.MasterRepo
            };
            _ViewController.SetRepositories();
        }
    }
}
