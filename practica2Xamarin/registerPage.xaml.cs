using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace practica2Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class registerPage : ContentPage
    {
        public registerPage()
        {
            InitializeComponent();
        }

        async private void Registrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Name.Text) | string.IsNullOrEmpty(Email.Text) | string.IsNullOrEmpty(Pass.Text) | string.IsNullOrEmpty(Pass_Confirm.Text))
            {
                await DisplayAlert("Error", "Campo Email y / o contraseña no puede estar vacío", "De acuerdo");
            }
            else if (Pass.Text != Pass_Confirm.Text)
            {
                await DisplayAlert("Error", "Verifique que las contraseñas son iguales", "De acuerdo");

            }
            else 
            {
                
                await Navigation.PushAsync(new MainPage());
                await DisplayAlert("Hola", $"Bienvenido {Name.Text}", "Gracias");
            }
        }
    }
}