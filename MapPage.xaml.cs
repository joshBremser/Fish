using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Fish.Views
{
    public partial class MapPage : ContentPage
    {
        public MapPage()
        {
            InitializeComponent();
            BackgroundImageSource = "sebagolake.png";
        }

        async void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MyFish1Page());
        }

        async void TapGestureRecognizer_Tapped_1(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MyFish6Page());
        }
    }
}
