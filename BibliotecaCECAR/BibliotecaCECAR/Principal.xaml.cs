using BibliotecaCECAR.Models;
using BottomBar.XamarinForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public ObservableCollection<Libros> listaLibros { get; set; }
        public Principal ()
		{
            
            listaLibros = new ObservableCollection<Libros> ();
            InitializeComponent();

            listaLibros.Add(new Libros
            {
                id = 1,
                nombreLibro = "El principito",
                autor = "Feid",
                fechaLanzamiento = DateTime.Now,
                edicion = "Primera",
                editorial = "Santillana",
                categoría = "Fantasía",
                ISBN = "69",
                imagen = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1c/El_principito.jpg/220px-El_principito.jpg"

            });

            listaLibros.Add(new Libros
            {
                id = 2,
                nombreLibro = "La metamorfosis",
                autor = "Franz Kafka",
                fechaLanzamiento = DateTime.Now,
                edicion = "Primera",
                editorial = "Santillana",
                categoría = "Ciencia ficción",
                ISBN = "10",
                imagen = "https://p.calameoassets.com/201111085935-d217219e90e384e2fb2f934bb048bb46/p1.jpg"

            });

            listaLibros.Add(new Libros
            {
                id = 3,
                nombreLibro = "La riqueza de las naciones",
                autor = "Adam Smith",
                fechaLanzamiento = DateTime.Now,
                edicion = "Primera",
                editorial = "Valencia",
                categoría = "Economía",
                ISBN = "22",
                imagen = "https://images.cdn3.buscalibre.com/fit-in/360x360/6a/59/6a59cde2b0ff1db63d569b15d48a172c.jpg"

            });

            listaLibros.Add(new Libros
            {
                id = 4,
                nombreLibro = "Crimen y castigo",
                autor = "Mora",
                fechaLanzamiento = DateTime.Now,
                edicion = "Primera",
                editorial = "popayan",
                categoría = "Misterio, drama",
                ISBN = "18",
                imagen = "https://images.cdn1.buscalibre.com/fit-in/360x360/a8/4c/a84cba5cd91dab13d0e443ae41dedebc.jpg"

            });

            listaLibros.Add(new Libros
            {
                id = 5,
                nombreLibro = "El quinto infierno",
                autor = "Karl max",
                fechaLanzamiento = DateTime.Now,
                edicion = "Primera",
                editorial = "malibú",
                categoría = "Economía",
                ISBN = "10",
                imagen = "https://marketplace.canva.com/EAEgYMq6FA8/1/0/1024w/canva-monocromo-suspenso-bosque-foto-portada-de-libro-f6Km98p3HIo.jpg"

            });

            this.BindingContext = this;
            
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

        private async void lista_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Libros libroEscogido = (Libros)e.CurrentSelection.FirstOrDefault();

            if (libroEscogido != null)
            {
                await Navigation.PushAsync(new VistaLibro(libroEscogido));
                Lista.SelectedItem = null;
            }

        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}