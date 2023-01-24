using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRevista.Clases
{
    class Autor : ObservableObject
    {
        private string nombre;
        private string nickname;
        private string image;
        private ObservableCollection<Articulo> articulos;
        private ObservableCollection<Articulo> articulosPublicados;
        private ObservableCollection<Articulo> articulosSinPublicar;

        public string Nombre
        {
            get { return nombre; }
            set { SetProperty(ref nombre, value); }
        }
    }
}
