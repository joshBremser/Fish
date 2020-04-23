﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fish.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
            BackgroundImage = "welcome.jpg";
        }

        async void OnFacebookGoogleTap(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GooglePage());
        }
    }
}