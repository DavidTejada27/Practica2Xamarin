using practica2Xamarin.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;


namespace practica2Xamarin.ViewModels
{
    public class LoginViewModel
    {
        public ICommand LoginCommand { get; }
        public ICommand RegisterCommand { get; }
        public string Email { get; set; }
        public string Password { get; set; }

        public LoginViewModel() 
        {
            LoginCommand = new Command(Onlogin);
            RegisterCommand = new Command(OnRegister);
        }

        private async void OnRegister()
        {
            await App.Current.MainPage.Navigation.PushAsync(new registerPage());
        }

        private async void Onlogin()
        {
            if (string.IsNullOrEmpty(Email) | string.IsNullOrEmpty(Password))
            {
                await App.Current.MainPage.DisplayAlert("Error", "Campo Email y/o contraseña no puede estar vacío", "De acuerdo");
            }
            else { await App.Current.MainPage.Navigation.PushAsync(new MainPage()); }

        }
    }
}
