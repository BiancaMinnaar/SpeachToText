using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BaseBonsai.DataContracts;
using BaseBonsai.Networking;
using SpeechToText.Trunk.ViewModel;
using SpeechToText.Interface.Service;

namespace SpeechToText.Implementation.Service
{
    public class FoodListFromSpeachService<T> : BaseService<T>, IFoodListFromSpeachService<T>
    {
        public FoodListFromSpeachService(Func<string, Dictionary<string, ParameterTypedValue>, BaseNetworkAccessEnum, Task<T>> networkInterface)
            :base(networkInterface)
        {
            //#Bonsai Snippets - MethodDefinitions
        }
    }
}