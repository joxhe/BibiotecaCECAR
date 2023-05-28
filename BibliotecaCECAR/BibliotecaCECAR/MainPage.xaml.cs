using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BibliotecaCECAR
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Ingresar(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new Principal()));
        }
    }
}
