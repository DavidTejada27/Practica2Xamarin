using practica2Xamarin.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace practica2Xamarin.ViewModels
{
    public class RegisterViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public string PassConfirm { get; set; }
        public ICommand RegisterdCommand { get; }
        public RegisterViewModel() 
        {
            RegisterdCommand = new Command(OnRegisterd);
        }

        private async void OnRegisterd()
        {
            if (string.IsNullOrEmpty(Name) | string.IsNullOrEmpty(Email) | string.IsNullOrEmpty(Pass) | string.IsNullOrEmpty(PassConfirm))
            {
                await App.Current.MainPage.DisplayAlert("Error", "Campo Email y / o contraseña no puede estar vacío", "De acuerdo");
            }
            else if (Pass != PassConfirm)
            {
                await App.Current.MainPage.DisplayAlert("Error", "Verifique que las contraseñas son iguales", "De acuerdo");

            }
            else
            {
                await App.Current.MainPage.Navigation.PushAsync(new MainPage());
                await App.Current.MainPage.DisplayAlert("Hola", $"Bienvenido {Name}", "Gracias");
            }
        }
    }   
}
