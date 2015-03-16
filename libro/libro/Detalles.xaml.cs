using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace libro
{
    public partial class Detalles : PhoneApplicationPage
    {
        private String nombre;
        private String codigo;
        private String autor;
        private String genero;
        private long paginas;

        public Detalles()
        {
            InitializeComponent();                        
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            String paginasN = NavigationContext.QueryString["paginas"];
            paginas = Convert.ToInt64(paginasN);
            nombre = NavigationContext.QueryString["nombre"];            
            autor = NavigationContext.QueryString["autor"];
            genero = NavigationContext.QueryString["genero"];
            codigo = NavigationContext.QueryString["codigo"];

            StackPanel panel = new StackPanel();

            TextBlock txtNombre = new TextBlock();
            txtNombre.Text = "Titulo: "+nombre;
            txtNombre.FontSize = 75;
            TextBlock txtCodigo = new TextBlock();
            txtCodigo.Text = "Codigo: " + codigo;
            txtCodigo.FontSize = 50;
            TextBlock txtAutor = new TextBlock();
            txtAutor.Text = "Autor: " + autor;
            txtAutor.FontSize = 50;
            TextBlock txtGenero = new TextBlock();
            txtGenero.Text = "Genero: " + genero;
            txtGenero.FontSize = 50;
            TextBlock txtPaginas = new TextBlock();
            txtPaginas.Text = "Paginas: " + paginas;
            txtPaginas.FontSize = 50;

            LayoutRoot.Children.Add(panel);
            
            panel.Children.Add(txtNombre);
            panel.Children.Add(txtCodigo);
            panel.Children.Add(txtAutor);
            panel.Children.Add(txtGenero);
            panel.Children.Add(txtPaginas);
        }
    }
}