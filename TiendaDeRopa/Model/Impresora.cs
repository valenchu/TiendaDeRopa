using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaDeRopa.Model
{
    class Impresora
    {
        protected Cotizacion co = new Cotizacion();

        public Impresora()
        {
        }

        public Impresora(Cotizacion co)
        {
            this.co = co;
        }
        //metodo para impresion rapida
        public void datosAImprimirRapido(PrintPageEventArgs e)
        {
            String a = "";
            long numID;
            String fecha;
            long numIdVendedor;
            String prenda;
            long cantCam;
            long cantPant;
            double total;

            a += "-------IMPRESION RAPIDA COTIZACION ACTUAL-------\n";
            for (int i = 0; i < co.ListaImprimir.Count; i++)//Recorro lista
            {
                numID = co.ListaImprimir[i].NumeroDeId;
                fecha = co.ListaImprimir[i].FechaYhora;
                numIdVendedor = co.ListaImprimir[i].CodigoDelVendedor;
                prenda = co.ListaImprimir[i].PrendaAcotizar;
                cantCam = co.ListaImprimir[i].CantDeUnidadesCotizadasCamisa;
                cantPant = co.ListaImprimir[i].CantDeUnidadesCotizadasPantalon;
                total = co.ListaImprimir[i].ResultadoCotizacion;
                a += $"NUMEROID: {numID}\nFECHA Y HORA: {fecha}\nCOD VENDEDOR: {numIdVendedor}\nDATO PRENDA: {prenda}" +
                    $"CANT CAMISA: {cantCam}\nCANT PANTALON: {cantPant}\nTOTAL: {total}";
            }
            Font font = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point);//Creo font
            float y = 20;
            float x = 200;
            RectangleF rec = new RectangleF(x, y += 20, 1000, 800);//Creo rectangle esto me ubica en la hoja
            e.Graphics.DrawString(a, font, Brushes.Black, rec);//Mando a imprimir
        }
        //Mtodo que dibuja el dataGridView con todos los datos
        public void datosAImprimirTotal(PrintPageEventArgs e)
        {
            int heigth = co.InternalData.Height;
            co.InternalData.Height = co.InternalData.RowCount * co.InternalData.RowTemplate.Height * 2;
            Bitmap map = new Bitmap(co.InternalData.Width, co.InternalData.Height);
            co.InternalData.DrawToBitmap(map, new Rectangle(0, 0, co.InternalData.Width, co.InternalData.Height));
            co.InternalData.Height = heigth;
            e.Graphics.DrawImage(map, 0, 0);
        }

    }
}
