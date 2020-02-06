using System;
using System.Collections.Generic;
using SpeechToText.Implementation.View;
using Xamarin.Forms;

namespace SpeechToText.Trunk.View
{
    public partial class AppShell : Shell
    {
        public Dictionary<string, Type> Routes { get; } = new Dictionary<string, Type>();

        public AppShell()
        {
            InitializeComponent();
            
           Routing.RegisterRoute("system", typeof(SystemView)); //#Bonsai Snippets - Routes
        }
    }
}