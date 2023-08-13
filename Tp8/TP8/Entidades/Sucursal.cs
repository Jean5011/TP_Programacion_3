using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sucursal
    {
        private int Id_Sucursal;
        private string NombreSucursal;
        private string DescripcionSucursal;
        private int Id_ProvinciaSucursal; 
        private string Direccion;

        public int Id_Sucursal1 { get => Id_Sucursal; set => Id_Sucursal = value; }
        public string NombreSucursal1 { get => NombreSucursal; set => NombreSucursal = value; }
        public string DescripcionSucursal1 { get => DescripcionSucursal; set => DescripcionSucursal = value; }
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public int Id_ProvinciaSucursal1 { get => Id_ProvinciaSucursal; set => Id_ProvinciaSucursal = value; }
    }
}/*
  * public int Id_Sucursal() { get => Id_Sucursal; set => Id_Sucursal = value; }
        public string NombreSucursal() { get => NombreSucursal; set => NombreSucursal = value; }
        public string DescripcionSucursal() { get => DescripcionSucursal; set => DescripcionSucursal = value; }
        public int Id_ProvinciaSucursal() { get => Id_ProvinciaSucursal; set => Id_ProvinciaSucursal = value; }
        public int Id_Sucursal() { get => Id_Sucursal; set => Id_Sucursal = value; }
        public string NombreSucursal() { get => NombreSucursal; set => NombreSucursal = value; }
        public string DescripcionSucursal() { get => DescripcionSucursal; set => DescripcionSucursal = value; }
        public int Id_ProvinciaSucursal() { get => Id_ProvinciaSucursal; set => I*/
