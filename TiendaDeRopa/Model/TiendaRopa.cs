using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaDeRopa.Model
{
    class TiendaRopa
    {
        //Attributos
        private String nombre = "Lib[2+2]";//Nombre de la tienda
        private String direccion = "Paso de los andes 687, Mendoza";//Direccion que tiene la tienda
        private static List<Pantalon> listaPantalon = new List<Pantalon>();//Guarda una lista de las prendas
        private static List<Camiseta> listaCamiseta = new List<Camiseta>();
        //GetterSetters
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public List<Pantalon> ListaPantalon { get => listaPantalon; set => listaPantalon = value; }
        public List<Camiseta> ListaCamisetas { get => listaCamiseta; set => listaCamiseta = value; }

        public TiendaRopa()
        {
        }
        //Metodo que se encarga de cargar las listas con stock al comienzo del programa
        //1000 remeras
        //2000 pantalones
        public void cargarPrendas()
        {
            this.ListaCamisetas.Add(new Camiseta("Larga", "Común", "Standard", 175));
            this.ListaCamisetas.Add(new Camiseta("Larga", "Común", "Premium", 175));
            this.ListaCamisetas.Add(new Camiseta("Larga", "Mao", "Standard", 75));
            this.ListaCamisetas.Add(new Camiseta("Larga", "Mao", "Premium", 75));
            this.ListaCamisetas.Add(new Camiseta("Corta", "Común", "Standard", 150));
            this.ListaCamisetas.Add(new Camiseta("Corta", "Común", "Premium", 150));
            this.ListaCamisetas.Add(new Camiseta("Corta", "Mao", "Standard", 100));
            this.ListaCamisetas.Add(new Camiseta("Corta", "Mao", "Premium", 100));
            this.ListaPantalon.Add(new Pantalon("Chupin", "Standard", 750));
            this.ListaPantalon.Add(new Pantalon("Chupin", "Premium", 750));
            this.ListaPantalon.Add(new Pantalon("Común", "Standard", 250));
            this.ListaPantalon.Add(new Pantalon("Común", "Premium", 250));

        }
        //Metodo que modificara el Stock metodo de prueba no existe en la practica
        public void modificarLista()
        {
            for (int i = 0; i < this.ListaCamisetas.Count; i++)
            {
                if (this.ListaCamisetas[i].CalidadPrenda.Equals("Standard") && this.ListaCamisetas[i].Cuello.Equals("Común") && this.ListaCamisetas[i].Manga.Equals("Larga"))
                {
                    long cant = this.ListaCamisetas[i].Cantidad;

                    this.ListaCamisetas[i].Cantidad = cant - 1;
                }
            }
        }
        //Metodo que mostrara las unidades en stock Camisa
        public void mostrarUnidadesStockCamisa(String manga, String cuello, String calidadPrenda, Label unidadesStock, TextBox preUnit)
        {

            for (int i = 0; i < this.ListaCamisetas.Count; i++)
            {
                if (this.ListaCamisetas[i].Manga.Equals(manga) && this.ListaCamisetas[i].Cuello.Equals(cuello) && this.ListaCamisetas[i].CalidadPrenda.Equals(calidadPrenda))
                {
                    long can = this.ListaCamisetas[i].Cantidad;
                    double pre = this.ListaCamisetas[i].PrecioUnitario;
                    preUnit.Text = pre.ToString();
                    unidadesStock.Text = "" + can;
                }
            }

        }
        //Metodo que mostrara las unidades en stock Pantalon
        public void mostrarUnidadesStockPantalon(String tipoPantalon, String calidadPrenda, Label unidadesStock, TextBox preUnit)
        {
            for (int i = 0; i < this.ListaPantalon.Count; i++)
            {
                if (this.ListaPantalon[i].TipoPantalon.Equals(tipoPantalon) && this.ListaPantalon[i].CalidadPrenda.Equals(calidadPrenda))
                {
                    long can = this.ListaPantalon[i].Cantidad;
                    double pre = this.ListaPantalon[i].PrecioUnitario;
                    preUnit.Text = pre.ToString();
                    unidadesStock.Text = "" + can;
                }
            }
        }
        //Metodo que cambia el precio unitario, camisa
        public void pCamisa(String manga, String cuello, String calidadPrenda, Label unidadesStock, TextBox preUnit)
        {
            for (int i = 0; i < this.ListaCamisetas.Count; i++)
            {
                if (this.ListaCamisetas[i].Manga.Equals(manga) && this.ListaCamisetas[i].Cuello.Equals(cuello) && this.ListaCamisetas[i].CalidadPrenda.Equals(calidadPrenda))
                {
                    this.ListaCamisetas[i].PrecioUnitario = double.Parse(preUnit.Text);
                }
            }
        }
        //Metodo que cambia el precio unitario pantalon
        public void pPantalon(String tipoPantalon, String calidadPrenda, Label unidadesStock, TextBox preUnit)
        {
            for (int i = 0; i < this.ListaPantalon.Count; i++)
            {
                if (this.ListaPantalon[i].TipoPantalon.Equals(tipoPantalon) && this.ListaPantalon[i].CalidadPrenda.Equals(calidadPrenda))
                {
                    this.ListaPantalon[i].PrecioUnitario = double.Parse(preUnit.Text);
                }
            }
        }
        //Metodo que verifica que la cantidad de camisas ingresada no sea mayor al stock
        public Boolean cantPrendaCamisa(String manga, String cuello, String calidadPrenda, TextBox cantPrenda)
        {
            for (int i = 0; i < this.ListaCamisetas.Count; i++)
            {
                if (this.ListaCamisetas[i].Manga.Equals(manga) && this.ListaCamisetas[i].Cuello.Equals(cuello) && this.ListaCamisetas[i].CalidadPrenda.Equals(calidadPrenda))
                {
                    long cant = this.ListaCamisetas[i].Cantidad;
                    long cantP = Int32.Parse(cantPrenda.Text);
                    if (cant < cantP)//Si cantidad es mayor que cantidad ingresada error
                        return true;
                }
            }
            return false;

        }
        //Metodo que verifica que la cantidad de pantalon ingresada no sea mayor al stock
        public Boolean cantPrendaPantalon(String tipoPantalon, String calidadPrenda, TextBox cantPrenda)
        {
            for (int i = 0; i < this.ListaPantalon.Count; i++)
            {
                if (this.ListaPantalon[i].TipoPantalon.Equals(tipoPantalon) && this.ListaPantalon[i].CalidadPrenda.Equals(calidadPrenda))
                {
                    long cant = this.ListaPantalon[i].Cantidad;
                    long cantP = Int32.Parse(cantPrenda.Text);
                    if (cant < cantP)//Si cantidad es mayor que cantidad ingresada error
                        return true;
                }
            }
            return false;
        }
    }
}
