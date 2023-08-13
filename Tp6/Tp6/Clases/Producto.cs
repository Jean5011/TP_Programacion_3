using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tp6.Clases
{
    public class Producto
    {
        private int i_IdProducto;
        private string i_NombreProducto;
        private string i_CantidadPorUnidad;
        private decimal i_PrecioUnidad;

        public Producto() { }

        public Producto(int i_IdProducto, string i_NombreProducto, string i_CantidadPorUnidad, decimal i_PrecioUnidad)
        {
            this.i_IdProducto = i_IdProducto;
            this.i_NombreProducto = i_NombreProducto;
            this.i_CantidadPorUnidad = i_CantidadPorUnidad;
            this.i_PrecioUnidad = i_PrecioUnidad;
        }

        public int IdProducto
        {
            get { return i_IdProducto; }
            set { i_IdProducto = value; }
        }

        public string NombreProducto
        {
            get { return i_NombreProducto; }
            set { i_NombreProducto = value; }
        }

        public string CantidadPorUnidad
        {
            get { return i_CantidadPorUnidad; }
            set { i_CantidadPorUnidad = value; }
        }
        public decimal PrecioUnidad
        {
            get { return i_PrecioUnidad; }
            set { i_PrecioUnidad = value; }
        }


    }

}