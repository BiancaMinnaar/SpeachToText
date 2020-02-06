using System.Threading.Tasks;
using SpeechToText.Interface.ViewController;
using SpeechToText.Trunk.ViewModel;
using SpeechToText.Root.ViewController;
//#Bonsai Snippets - Usings

namespace SpeechToText.Implementation.ViewController
{
    public class SystemViewController : ProjectBaseViewController<SystemViewModel>, ISystemViewController
    {
        //#Bonsai Snippets - Declarations
        public override void SetRepositories()
        {
            //#Bonsai Snippets - ServicedRepos
        }
        
        //#Bonsai Snippets - Methods
    }
}