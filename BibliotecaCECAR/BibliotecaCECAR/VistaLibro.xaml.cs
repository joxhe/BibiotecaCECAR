using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaCECAR.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BibliotecaCECAR
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VistaLibro : ContentPage
    {
        public Libros libros { get; set; }
        public VistaLibro(Models.Libros libroEscogido)
        {
            InitializeComponent();
            this.libros = libroEscogido;
            this.BindingContext = this;
            
        }
    }
}