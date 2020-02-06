using SpeechToText.Root.ViewModel;
using Xamarin.Forms;

namespace SpeechToText.Root
{
    public abstract class ControlBase<V, M> : ContentView
        where V : ContentView
        where M : ProjectBaseViewModel
    {
        public static BindableProperty ViewModelProperty = BindableProperty.Create(
            "ViewModel", typeof(M), typeof(V), null, BindingMode.TwoWay,
            propertyChanged: HandleViewModelPropertyChanged);

        public M ViewModel
        {
            get { return (M)GetValue(ViewModelProperty); }
            set
            {
                if (value != ViewModel)
                    SetValue(ViewModelProperty, value);
            }
        }

        protected static void HandleViewModelPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ControlBase<V, M> targetView && newValue is M input)
            {
                targetView.ViewModel = input;
                targetView.AddNavigationCommands(input);                
                targetView.BindingContext = targetView.ViewModel;
            }
        }

        protected virtual void AddNavigationCommands(M list) { }
    }
}

