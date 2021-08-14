using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaDeRopa.Controller;
using TiendaDeRopa.Model;

namespace TiendaDeRopa
{
    public partial class Form2 : Form
    {
        TiendaRopa tien = new TiendaRopa();
        ControllerLabels con = new ControllerLabels();
        public Form2()
        {
            InitializeComponent();
        }
        //Metodo que carga lista stock
        public void cargarLista()
        {
            con.cargarLista(listStock);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cargarLista();//Llamo al metodo cargar lista para cargar la lista stock apenas inicia formulario
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*tien.modificarLista();*///Metodo que modifica la lista y le resta 1 a cantidad
            listStock.DataSource = null;//Borro ListBox
            listStock.Items.Clear();
            cargarLista();//Cargo lista actualizada con la cantidad restada en 1
        }

    }
}
