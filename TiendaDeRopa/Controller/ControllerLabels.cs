using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaDeRopa.Model;
using System.Windows.Forms;

namespace TiendaDeRopa.Controller
{
    class ControllerLabels
    {
        private TiendaRopa tienda = new TiendaRopa();
        private Vendedor vende = new Vendedor();
        public ControllerLabels()
        {
        }
        //Metodo label completo que cambia los datos de label de la cabecera
        public void cambiarDatoLabel(Label nomTienda, Label dirTienda, Label nomVendedor, Label codVendedor)
        {
            nomTienda.Text = $"Nombre tienda: {tienda.Nombre}";
            dirTienda.Text = $"Dir: {tienda.Direccion}";
            nomVendedor.Text = $"Nombre: {vende.Nombre} {vende.Apellido}";
            codVendedor.Text = $"Codigo vendedor: {vende.CodigoVendedor}";
        }
        //MEtodo que carga la lista stock esto no esta incluido en la practica
        //Lo hice para verificar funcionamientos
        public void cargarLista(ListBox listStock)
        {
            foreach (var item in tienda.ListaCamisetas)
            {
                listStock.Items.Add(item);

            }
            foreach (var item in tienda.ListaPantalon)
            {
                listStock.Items.Add(item);
            }
        }
    }
}
