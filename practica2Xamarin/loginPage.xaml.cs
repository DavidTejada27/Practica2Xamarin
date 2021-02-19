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
    public partial class loginPage : TabbedPage
    {
        public loginPage()
        {
            InitializeComponent();
        }

     
        async void Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Email.Text) | string.IsNullOrEmpty(Pass.Text))
            {
                await DisplayAlert("Error", "Campo Email y/o contraseña no puede estar vacío", "De acuerdo");
            }
            else { await Navigation.PushAsync(new MainPage()); }
            
        }


       
       async void Registro_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new registerPage());
        }
    }
}