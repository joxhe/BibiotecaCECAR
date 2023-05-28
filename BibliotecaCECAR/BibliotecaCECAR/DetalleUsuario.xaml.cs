using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BibliotecaCECAR
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalleUsuario : ContentPage
    {
        public DetalleUsuario()
        {
            InitializeComponent();
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await  Launcher.OpenAsync(new Uri("https://youtu.be/AAbAw3sgeow?t=116"));
        }
    }
}