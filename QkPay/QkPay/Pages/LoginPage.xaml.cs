using System;
using System.Collections.Generic;
using System.Linq;

using Xamarin.Forms;

namespace QkPay.Pages
{
    public partial class LoginPage : ContentPage
    {
        string _phone;
        string _pin;

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; OnPropertyChanged(); }
        }

        public string Pin
        {
            get { return _pin; }
            set { _pin = value; OnPropertyChanged(); }
        }

        public LoginPage()
        {
            InitializeComponent();

            BindingContext = this;

            var users = App.Database.GetUsers();

            if (users.Count() == 0)
                App.Current.Navigation.Navigation.PushModalAsync(new NavigationPage(new SignUpPage()));
        }

        public void LoginClicked(object sender, EventArgs e)
        {

            var user = App.Database.GetUser(Phone);
            if (user != null && user.Pin == Pin)
                App.Current.GotoMain(user);
            else
                DisplayAlert("Incorrect login", "Incorrect phone or pin number. Please try again.", "OK");
        }
    }
}