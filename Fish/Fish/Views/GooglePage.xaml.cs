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
    public partial class GooglePage : ContentPage
    {
        public GooglePage()
        {
            InitializeComponent();
            BackgroundImage = "google.png";
        }
    }
}