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
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
            BackgroundImageSource = "welcome.jpg";
        }

        async void OnFacebookGoogleTap(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GooglePage());
        }

        async void Loginbutton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }

        async void Registerbutton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());
        }
    }
}