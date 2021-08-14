using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeRopa.Model
{
    abstract class Prenda
    {
        //Propiedades
        protected String calidadPrenda;// La calidad de prenda se clasificara en (Standar o Premium)
        protected double precioUnitario;// Precio de la prenda
        protected long cantidad; //Cantidad de unidades que hay en stock de dicha prenda

        public string CalidadPrenda { get => calidadPrenda; set => calidadPrenda = value; }
        public double PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
        public long Cantidad { get => cantidad; set => cantidad = value; }
    }
}
