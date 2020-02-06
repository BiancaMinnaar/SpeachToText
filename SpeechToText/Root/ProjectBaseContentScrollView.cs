using SpeechToText.Root.ViewController;
using SpeechToText.Root.ViewModel;
using SpeechToText.Trunk.Repository.Implementation;
using Xamarin.Forms;

namespace SpeechToText.Root.View
{
    public abstract class ProjectBaseContentScrollView<T, M> : ScrollView
        where T : ProjectBaseViewController<M>, new()
        where M : ProjectBaseViewModel
    {
        protected T _ViewController;

        protected ProjectBaseContentScrollView()
        {
            _ViewController = new T();
            SetSVGCollection();
            _ViewController._MasterRepo = MasterRepository.MasterRepo;
            _ViewController.SetRepositories();
        }

        protected abstract void SetSVGCollection();
    }
}