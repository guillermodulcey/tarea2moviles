using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libro.Models
{
    public class libros
    {
        ObservableCollection<Libro> data;

        public ObservableCollection<Libro> Data{
            get{
                if(data == null){
                    data = new ObservableCollection<Libro>();
                    Libro libro1 = new Libro(){Nombre="MacSwag", Codigo="M10", Autor="SwagMeister", Genero="Swag", Paginas=200};
                    Libro libro2 = new Libro() { Nombre = "420BlazeIt", Codigo = "M42", Autor = "360NoScope", Genero = "Swag", Paginas = 200 };
                    Libro libro3 = new Libro() { Nombre = "Swag for dummies", Codigo = "MS4", Autor = "S.Dog", Genero = "Swag", Paginas = 200 };
                    data.Add(libro1);
                    data.Add(libro2);
                    data.Add(libro3);
                }
                return data;
            }
            set{
                data = value;
            }
        }
    }
}
