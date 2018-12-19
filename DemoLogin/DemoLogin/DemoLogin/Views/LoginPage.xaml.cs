using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DemoLogin.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoLogin.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
            Init();
		}

        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            Lbl_Username.TextColor = Constants.MainTextColor;
            Lbl_Password.TextColor = Constants.MainTextColor;
            ActivitySpinner.IsVisible = false;
            LoginIcon.HeightRequest = Constants.LoginIconHeight;

            Entry_Username.Completed += (s, e) => Entry_Password.Focus();
            Entry_Password.Completed += (s, e) => signInProcedure(s, e);
        }
        void signInProcedure(object sender, EventArgs e)
        {
            if (validate(Entry_Username.Text, Entry_Password.Text))
            {
                DisplayAlert("Login", "Login successful", "OK");
            }
            else
            {
                DisplayAlert("Login", "Login errors : empty Username or Password", "OK");
            }
        }

        bool validate(string username, string password)
        {bool res= false;
            if(!username.Equals("") && !password.Equals("")) { res = true; }

            return res;
        }
	}


}