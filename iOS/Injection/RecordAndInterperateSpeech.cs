using System;
using AVFoundation;
using Foundation;
using Speech;
using SpeechToText.iOS.Injection;
using SpeechToText.Trunk.Service;

[assembly: Xamarin.Forms.Dependency(typeof(RecordAndInterperateSpeech))]
namespace SpeechToText.iOS.Injection
{
    public class RecordAndInterperateSpeech : IRecordAndInterperateSpeech
    {
        private AVAudioEngine AudioEngine = new AVAudioEngine();
        private SFSpeechRecognizer SpeechRecognizer = new SFSpeechRecognizer();
        private SFSpeechAudioBufferRecognitionRequest LiveSpeechRequest = new SFSpeechAudioBufferRecognitionRequest();
        private SFSpeechRecognitionTask RecognitionTask;

        public RecordAndInterperateSpeech()
        {
            
        }

        public void CancelInterpretation()
        {
            AudioEngine.Stop();
            RecognitionTask.Cancel();
        }

        public void StopInterpreting()
        {
            AudioEngine.Stop();
            LiveSpeechRequest.EndAudio();
        }

        public string TranslateSpeachToText()
        {
            // Setup audio session
            var node = AudioEngine.InputNode;
            var recordingFormat = node.GetBusOutputFormat(0);
            node.InstallTapOnBus(0, 1024, recordingFormat, (AVAudioPcmBuffer buffer, AVAudioTime when) => {
                // Append buffer to recognition request
                LiveSpeechRequest.Append(buffer);
            });

            // Start recording
            AudioEngine.Prepare();
            NSError error;
            AudioEngine.StartAndReturnError(out error);

            // Did recording start?
            if (error != null)
            {
                // Handle error and return
                return "Error";
            }

            // Start recognition
            string returnString = "";
            RecognitionTask = SpeechRecognizer.GetRecognitionTask(LiveSpeechRequest,
                (SFSpeechRecognitionResult result, NSError err) =>
                {
                // Was there an error?
                if (err != null)
                {
                    // Handle error
                }
                else
                {
                    // Is this the final translation?
                    if (result.Final)
                    {
                            returnString = result.BestTranscription.FormattedString;
                    }
                }
            });
            return returnString;
        }
    }
}
