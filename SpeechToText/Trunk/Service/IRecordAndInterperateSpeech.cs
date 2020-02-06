using System;
using SpeechToText.Trunk.ViewModel;

namespace SpeechToText.Trunk.Service
{
    public interface IRecordAndInterperateSpeech
    {
        void TranslateSpeachToText(FoodListFromSpeachViewModel model);
        void StopInterpreting();
        void CancelInterpretation();
    }
}
