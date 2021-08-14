using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeRopa.Model
{
    class Pantalon : Prenda
    {
        //Atributo
        private String tipoPantalon;//Guarda tipo de pantalon-> Comun o Chupin
        //GetterSetter
        public string TipoPantalon { get => tipoPantalon; set => tipoPantalon = value; }
        //Constructores
        public Pantalon()
        {
        }

        public Pantalon(string tipoPantalon, String calidadPrenda, long stock)
        {
            this.tipoPantalon = tipoPantalon;
            this.CalidadPrenda = calidadPrenda;
            cantidad = stock;
            precioUnitario = 0;
        }

        public override string ToString()
        {
            return $"Pantalon: || Tipo de Pantalon-> [{this.tipoPantalon}] || Calidad-> [{CalidadPrenda}] || Cantidad-> [{cantidad}] || Precio-> {precioUnitario} \n";
        }
    }
}
