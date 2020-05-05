using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Fish.Views
{
    public partial class MyFish1Page : ContentPage
    {
        public MyFish1Page()
        {
            InitializeComponent();
        }

        async void CommentButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Comment1Page());
        }
    }
}
