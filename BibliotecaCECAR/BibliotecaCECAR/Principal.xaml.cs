using BottomBar.XamarinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BibliotecaCECAR
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Principal : BottomBarPage
	{
		public Principal ()
		{
			InitializeComponent ();
		}

        private async void usuario(object sender, EventArgs e)
        {
			await Navigation.PushAsync(new NavigationPage(new DetalleUsuario()));

        }

        private async void notificaciones(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new Notificaciones()));

        }

        private async void cerrar(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new MainPage()));

        }
    }
}