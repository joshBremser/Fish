using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fish.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BackgroundImageSource = "welcome.jpg";
        }

        void email_TextChanged(object sender, TextChangedEventArgs e)
        {
            string oldText = e.OldTextValue;
            string newText = e.NewTextValue;
        }

        void email_Completed(object sender, EventArgs e)
        {
            string login_email = ((Entry)sender).Text;
        }

        void password_TextChanged(object sender, TextChangedEventArgs e)
        {
            string oldText = e.OldTextValue;
            string newText = e.NewTextValue;
        }

        void password_Completed(object sender, EventArgs e)
        {
            string login_password = ((Entry)sender).Text;
        }

        
    }
}
