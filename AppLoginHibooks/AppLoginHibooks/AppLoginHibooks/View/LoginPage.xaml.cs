using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppLoginHibooks.Model;
using AppLoginHibooks.Data;
using AppLoginHibooks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Diagnostics;

namespace AppLoginHibooks.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {

        public LoginPage()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            Lbl_Username.TextColor = Constants.MainTextColor;
            Lbl_Password.TextColor = Constants.MainTextColor;
            ActivitySpinner.IsVisible = false;
           // LoginIcon.HeightRequest = Constants.LoginIconHeight;

            Entry_Username.Completed += (s, e) => Entry_Password.Focus();
            Entry_Password.Completed += (s, e) => signInProcedure(s, e);
        }
        async void signInProcedure(object sender, EventArgs e)
        {
            int i = await validate(Entry_Username.Text, Entry_Password.Text);
            if (i == 1)
            {
                
                await DisplayAlert("login", "login successful : " + App.user.Email + " is connected !", "ok");
            }
            else
            {
                await DisplayAlert("login", "login errors : wrong username or password", "ok");
            }
        }

        async Task<int> validate(string username, string password)
        {
            int res = 0;
            if (!username.Equals("") && !username.Equals(null)  && !password.Equals("") && !password.Equals(null))
            {
                LoginConsumer lc = new LoginConsumer();
                int i = await lc.loginAsync(new Login(username, password));
                if (i == 1) res = 1;
            }
            return res;
        }
        async void signOutProcedure(Object sender, EventArgs e)
        {
            LoginConsumer lc = new LoginConsumer();
            await lc.logoutAsync();
            await DisplayAlert("logout", "logout successful", "ok");

        }
    }


}