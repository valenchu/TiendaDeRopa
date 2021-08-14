using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeRopa.Model
{
    class Camiseta : Prenda
    {
        private String manga;//Guardara el tipo de manga-> Manga corta, Manga larga
        private String cuello;//Guardara el tipo de cuello->Cuello mao, Cuello común

        //GetterSetters
        public string Manga { get => manga; set => manga = value; }
        public string Cuello { get => cuello; set => cuello = value; }
        //Constructores
        public Camiseta()
        {
        }

        public Camiseta(string manga, string cuello, String calidad, long cant)
        {
            this.manga = manga;
            this.cuello = cuello;
            CalidadPrenda = calidad;
            precioUnitario = 0;
            cantidad = cant;
        }

        public override string ToString()
        {
            return $"Camiseta: || Manga-> [{this.manga}] || Cuello-> [{this.cuello}] || Calidad-> [{CalidadPrenda}] || Cantidad-> [{cantidad}] || Precio-> [{precioUnitario}] \n";
        }
    }
}
