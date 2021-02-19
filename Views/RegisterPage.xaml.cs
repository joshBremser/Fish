using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Fish.Views
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            BackgroundImageSource = "welcome.jpg";
        }

        async void RegisterPageButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MapPage());
        }
    }
}
