using practica2Xamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace practica2Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class registerPage : ContentPage
    {
        public registerPage()
        {
            InitializeComponent();
            BindingContext = new RegisterViewModel();
        }

    }
}