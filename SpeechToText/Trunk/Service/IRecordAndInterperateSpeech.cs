using System;
namespace SpeechToText.Trunk.Service
{
    public interface IRecordAndInterperateSpeech
    {
        string TranslateSpeachToText();
        void StopInterpreting();
        void CancelInterpretation();
    }
}
