using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Acr.UserDialogs;
using BaseBonsai.DataContracts;
using BaseBonsai.Networking;
using Newtonsoft.Json;
using SpeechToText.Implementation.View;
using SpeechToText.Interface.Repository;
using SpeechToText.Root.Repository;
using SpeechToText.Root.ViewModel;
using SpeechToText.Trunk.View;
using Xamarin.Forms;

namespace SpeechToText.Trunk.Repository.Implementation
{
    public class MasterRepository : ProjectBaseRepository, IMasterRepository
    {
        private static MasterRepository _Reposetory = new MasterRepository();
        private static readonly object syncronisationLock = new object();
        public MasterModel DataSource { get; set; }
        public Func<string, Dictionary<string, object>, BaseNetworkAccessEnum, Task> NetworkInterface { get; set; }
        public Func<string, Dictionary<string, ParameterTypedValue>, BaseNetworkAccessEnum, Task> NetworkInterfaceWithTypedParameters { get; set; }

        MasterRepository()
            : base(null)
        {
            DataSource = new MasterModel();
        }

        public static MasterRepository MasterRepo
        {
            get { return _Reposetory; }
        }
        
        public void DumpJson<T>(string heading, T objectToDump)
        {
            Debug.WriteLine(heading);
            Debug.WriteLine(JsonConvert.SerializeObject(objectToDump));
        }
        
        public void ShowLoading()
        {
            UserDialogs.Instance.ShowLoading();
        }

        public void HideLoading()
        {
            UserDialogs.Instance.HideLoading();
        }
        //#Bonsai Snippets - Methods
    }
}