using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using libro.Models;

namespace libro
{
    public partial class ListBox : PhoneApplicationPage
    {
        public ListBox()
        {
            InitializeComponent();
        }

        private void goToPage(object sender, SelectionChangedEventArgs e)
        {
            var selectedIndex = list.SelectedIndex;
            var selectedLibro = list.SelectedItem as Libro;
            var libroNombre = selectedLibro.Nombre;
            var libroCodigo = selectedLibro.Codigo;
            var libroAutor = selectedLibro.Autor;
            var libroGenero = selectedLibro.Genero;
            var libroPaginas = selectedLibro.Paginas;
            
            NavigationService.Navigate(new Uri("/detalles.xaml?nombre="+libroNombre+
                                                "&codigo="+libroCodigo+
                                                "&autor="+libroAutor+
                                                "&genero="+libroGenero+
                                                "&paginas=" + libroPaginas +
                                                ""
                                                , UriKind.Relative));
        }
    }
}