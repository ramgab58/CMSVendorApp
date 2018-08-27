using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestApplication
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        //void Handle_Clicked(object sender, System.EventArgs e)
        //{
        //    DisplayAlert("Awesome Title", "Displaying awesome alert!", "Cancel");
        //}

        private async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            var user = new User{
                Username = UserIdText.Text,
                Password = PasswordText.Text
            };

            if(CheckCredentials(user))
            {
                Navigation.InsertPageBefore(new MasterPage(), this);
                await Navigation.PopAsync();
            }
            else {
                await DisplayAlert("Error", 
                             "The User ID or Password you entered is incorrect. Please click 'OK' to reenter your User ID and Password",
                            "OK");
            }
        }

        bool CheckCredentials(User obj)
        {
            return obj.Username.Equals(Constants.UsernameHC) && obj.Password.Equals(Constants.PasswordHC);
        }
    }
}
