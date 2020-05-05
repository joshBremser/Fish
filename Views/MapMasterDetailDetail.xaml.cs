using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fish.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapMasterDetailDetail : ContentPage
    {
        public MapMasterDetailDetail()
        {
            InitializeComponent();
            BackgroundImageSource = "sebagolake.png";

        }
        async void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MyFish1Page());
        }

        async void TapGestureRecognizer_Tapped1(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new NewItemPage());
        }


    }
}