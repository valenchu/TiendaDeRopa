using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaDeRopa.Controller;
using TiendaDeRopa.Model;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace TiendaDeRopa
{
    public partial class formStock : Form
    {
        TiendaRopa ti = new TiendaRopa();
        ControllerCotizacion con = new ControllerCotizacion();
        Cotizacion cotiza = new Cotizacion();
        ControllerLabels labelel = new ControllerLabels();
        HistoriaCotizaciones historia = new HistoriaCotizaciones();//MAnejo el segundo form
        public formStock()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Metodo que inserta precio unitario desp de la primer vuelta
            con.precioUni(rdPantalon, rdPantChupin, rdPantComun, lblResultado, rdPrendaStandard, rdPrendaPremium, txtPrecioUnitario,
                rdCamisa, rdMangaLarga, rdMangaCorta, rdCamMao, rdCamComun);
            //Cargo datos de cabecera
            labelel.cambiarDatoLabel(lblNomTienda, lblDireciionTienda, lblNombreApellido, lblCodeVendedor);
            //Verifico la seleccion de buttons para ocultar grup
            con.verificacionRdPrenda(rdCamisa, rdPantalon, rdMangaLarga, rdMangaCorta,
               rdCamMao, rdCamComun, rdPantChupin, rdPantComun,
               grupPantalon, grupManga, grupCuello);
            //Cargo la listas de stock de pantalones y camisetas de la tienda de ropa
            ti.cargarPrendas();
            //Cargo undidades de stock disponibles apenas abro el form
            con.verificacionCamisa(rdCamisa, rdMangaLarga, rdMangaCorta, rdCamMao, rdCamComun, lblResultado, rdPrendaStandard, rdPrendaPremium, txtPrecioUnitario);
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {

            bool verificador = false;
            //Metodo que revisa los textbox de calculo y hace la accion dependiendo lo que suceda
            verificador = con.analizarCotizacion(txtPrecioUnitario, txtCantidadPrenda);
            if (verificador == true) return;//Devuelve true corto metodo
            //Metodo que inserta precio unitario desp de la primer vuelta
            con.precioUni(rdPantalon, rdPantChupin, rdPantComun, lblResultado, rdPrendaStandard, rdPrendaPremium, txtPrecioUnitario,
                rdCamisa, rdMangaLarga, rdMangaCorta, rdCamMao, rdCamComun);
            //Metodo que verifica que la cantidad no sea mayor a la ingresada
            verificador = con.cantPrenda(rdPantalon, rdPantChupin, rdPantComun, rdPrendaStandard, rdPrendaPremium, txtCantidadPrenda,
                rdCamisa, rdMangaLarga, rdMangaCorta, rdCamMao, rdCamComun);
            if (verificador == true) return;//Devuelve true corto metodo
            //Guardo fecha y id de cotizacion actual
            cotiza.modIdFechaYhora();
            //Verifico camisa de entrada para cargar las unidades
            con.verificacionCamisa(rdCamisa, rdMangaLarga, rdMangaCorta, rdCamMao, rdCamComun, lblResultado, rdPrendaStandard, rdPrendaPremium, txtPrecioUnitario);
            //Verifico el pantalon seleccionado
            con.verificacionPantalon(rdPantalon, rdPantChupin, rdPantComun, lblResultado, rdPrendaStandard, rdPrendaPremium, txtPrecioUnitario);
            double precioUnidad = Double.Parse(txtPrecioUnitario.Text);
            Int32 cantidadPrendas = Int32.Parse(txtCantidadPrenda.Text);
            //Metodo que calcula la cotizacion y carga datos en cotizacion
            cotiza.modificarCodVprendaCantU(precioUnidad, cantidadPrendas, rdPantalon, rdPantChupin, rdPantComun, rdPrendaStandard, rdPrendaPremium,
                rdCamisa, rdMangaLarga, rdMangaCorta, rdCamMao, rdCamComun, txtTotal);
            //Metodo que carga el DataGridView1 para cargar datos
            cotiza.rellenarDataGridView(historia.dataGridView1);
            txtCantidadPrenda.Text = "";
        }

        private void rdCamisa_CheckedChanged(object sender, EventArgs e)
        {
            //Verifico buttosn para ocultar al hacer click
            con.verificacionRdPrenda(rdCamisa, rdPantalon, rdMangaLarga, rdMangaCorta,
               rdCamMao, rdCamComun, rdPantChupin, rdPantComun,
               grupPantalon, grupManga, grupCuello);
            //Verifico la camisa seleccionada
            con.verificacionCamisa(rdCamisa, rdMangaLarga, rdMangaCorta, rdCamMao, rdCamComun, lblResultado, rdPrendaStandard, rdPrendaPremium, txtPrecioUnitario);
        }

        private void rdPantalon_CheckedChanged(object sender, EventArgs e)
        {
            //Verifico buttosn para ocultar al hacer click
            con.verificacionRdPrenda(rdCamisa, rdPantalon, rdMangaLarga, rdMangaCorta,
               rdCamMao, rdCamComun, rdPantChupin, rdPantComun,
               grupPantalon, grupManga, grupCuello);
            //Verifico el pantalon seleccionado
            con.verificacionPantalon(rdPantalon, rdPantChupin, rdPantComun, lblResultado, rdPrendaStandard, rdPrendaPremium, txtPrecioUnitario);
        }

        private void btnListaStock_Click(object sender, EventArgs e)
        {
            //Creo formulario con la lista stock
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void rdMangaLarga_CheckedChanged(object sender, EventArgs e)
        {
            con.verificacionCamisa(rdCamisa, rdMangaLarga, rdMangaCorta, rdCamMao, rdCamComun, lblResultado, rdPrendaStandard, rdPrendaPremium, txtPrecioUnitario);
        }

        private void rdMangaCorta_CheckedChanged(object sender, EventArgs e)
        {
            con.verificacionCamisa(rdCamisa, rdMangaLarga, rdMangaCorta, rdCamMao, rdCamComun, lblResultado, rdPrendaStandard, rdPrendaPremium, txtPrecioUnitario);
        }

        private void rdCamMao_CheckedChanged(object sender, EventArgs e)
        {
            con.verificacionCamisa(rdCamisa, rdMangaLarga, rdMangaCorta, rdCamMao, rdCamComun, lblResultado, rdPrendaStandard, rdPrendaPremium, txtPrecioUnitario);
        }

        private void rdCamComun_CheckedChanged(object sender, EventArgs e)
        {
            con.verificacionCamisa(rdCamisa, rdMangaLarga, rdMangaCorta, rdCamMao, rdCamComun, lblResultado, rdPrendaStandard, rdPrendaPremium, txtPrecioUnitario);
        }

        private void rdPrendaPremium_CheckedChanged(object sender, EventArgs e)
        {
            con.verificacionCamisa(rdCamisa, rdMangaLarga, rdMangaCorta, rdCamMao, rdCamComun, lblResultado, rdPrendaStandard, rdPrendaPremium, txtPrecioUnitario);
            con.verificacionPantalon(rdPantalon, rdPantChupin, rdPantComun, lblResultado, rdPrendaStandard, rdPrendaPremium, txtPrecioUnitario);
        }

        private void rdPrendaStandard_CheckedChanged(object sender, EventArgs e)
        {
            con.verificacionCamisa(rdCamisa, rdMangaLarga, rdMangaCorta, rdCamMao, rdCamComun, lblResultado, rdPrendaStandard, rdPrendaPremium, txtPrecioUnitario);
            con.verificacionPantalon(rdPantalon, rdPantChupin, rdPantComun, lblResultado, rdPrendaStandard, rdPrendaPremium, txtPrecioUnitario);
        }

        private void rdPantComun_CheckedChanged(object sender, EventArgs e)
        {
            con.verificacionPantalon(rdPantalon, rdPantChupin, rdPantComun, lblResultado, rdPrendaStandard, rdPrendaPremium, txtPrecioUnitario);
        }

        private void rdPantChupin_CheckedChanged(object sender, EventArgs e)
        {
            con.verificacionPantalon(rdPantalon, rdPantChupin, rdPantComun, lblResultado, rdPrendaStandard, rdPrendaPremium, txtPrecioUnitario);
        }

        private void lblLinkHistorial_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            historia.ShowDialog();
        }
        //Metodo que ejecuta para imprimir
        private void lblLinkImprimir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            imprimirD = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            imprimirD.PrinterSettings = ps;
            imprimirD.PrintPage += imprimir;
            imprimirD.Print();

        }
        //metodo que creo impresion tipo
        private void imprimir(object sender, PrintPageEventArgs e)
        {
            Impresora im = new Impresora(cotiza);
            im.datosAImprimirTotal(e);
        }

        private void lblImpCotActual_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            imprimirD = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            imprimirD.PrinterSettings = ps;
            imprimirD.PrintPage += imprimirActual;
            imprimirD.Print();
        }
        private void imprimirActual(object sender, PrintPageEventArgs e)
        {
            Impresora im = new Impresora();
            im.datosAImprimirRapido(e);

        }
    }
}
