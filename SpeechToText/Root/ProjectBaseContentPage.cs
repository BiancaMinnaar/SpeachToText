using System;
using System.Reflection;
using SpeechToText.Root.ViewController;
using SpeechToText.Root.ViewModel;
using SpeechToText.Trunk.Repository.Implementation;
using Xamarin.Forms;

namespace SpeechToText.Root.View
{
    public abstract class ProjectBaseContentPage<T, M> : ContentPage
        where T: ProjectBaseViewController<M>, new()
        where M: ProjectBaseViewModel, new()
    {
        protected T _ViewController;

        protected ProjectBaseContentPage()
        {
            try
            {
                _ViewController = new T();
            }
            catch(TargetInvocationException excp)
            {
                throw new Exception("Bonsai Licence Failure");
            }
            _ViewController.InputObject = new M();
            _ViewController._MasterRepo = MasterRepository.MasterRepo;
            _ViewController.SetRepositories();
        }
    }
}