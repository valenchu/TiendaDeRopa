using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TiendaDeRopa.Model
{
    class Cotizacion
    {
        //Atributos
        private long numeroDeId;//Numero de identificacion
        private String fechaYhora;// Fecha y hora de la cotizacion
        private long codigoDelVendedor;//El codigo que contiene vendedor
        private String prendaAcotizar;//Prenda que se va a cotizar ej: Remera Adidas
        private long cantDeUnidadesCotizadasPantalon;//La cantidad de unidades que se va a cotizar de Pantalon
        private long cantDeUnidadesCotizadasCamisa;//La cantidad de unidades que se va a cotizar de Camisa
        private double resultadoCotizacion; //Guardara el resultado de la cotizacion final
        private static List<Cotizacion> listaImprimir = new List<Cotizacion>();
        private DataGridView internalData = new DataGridView();
        private Vendedor vende = new Vendedor();

        //MetodosGetterAndSettersPropiedades para C#
        public long NumeroDeId { get => numeroDeId; set => numeroDeId = value; }
        public String FechaYhora { get => fechaYhora; set => fechaYhora = value; }
        public string PrendaAcotizar { get => prendaAcotizar; set => prendaAcotizar = value; }
        public double ResultadoCotizacion { get => resultadoCotizacion; set => resultadoCotizacion = value; }
        public long CodigoDelVendedor { get => codigoDelVendedor; set => codigoDelVendedor = value; }
        public long CantDeUnidadesCotizadasPantalon { get => cantDeUnidadesCotizadasPantalon; set => cantDeUnidadesCotizadasPantalon = value; }
        public long CantDeUnidadesCotizadasCamisa { get => cantDeUnidadesCotizadasCamisa; set => cantDeUnidadesCotizadasCamisa = value; }
        public List<Cotizacion> ListaImprimir { get => listaImprimir; set => listaImprimir = value; }
        public DataGridView InternalData { get => internalData; set => internalData = value; }
        protected Vendedor Vende { get => vende; set => vende = value; }


        //Constructor LLeno y debajo el Vacio
        public Cotizacion(long numeroDeId, String fechaYhora, long codigoDelVendedor, string prendaAcotizar, long cantDeUnidadesCotizadasPantalon, long cantDeUnidadesCotizadasCamisa, double resultadoCotizacion)
        {
            this.NumeroDeId = numeroDeId;
            this.FechaYhora = fechaYhora;
            this.CodigoDelVendedor = codigoDelVendedor;
            this.PrendaAcotizar = prendaAcotizar;
            this.cantDeUnidadesCotizadasPantalon = cantDeUnidadesCotizadasPantalon;
            this.cantDeUnidadesCotizadasCamisa = cantDeUnidadesCotizadasCamisa;
            this.ResultadoCotizacion = resultadoCotizacion;
        }

        public Cotizacion()
        {
        }
        //Metodo que envia a clase Cotizacion el codigo del vendedor, la prenda cotizada y la cantidad de 
        //unidades de prenda cotizada
        public void modificarCodVprendaCantU(double precioUnitario, Int32 cantDePrendas,
           RadioButton rdPantalon, RadioButton rdPantChupin, RadioButton rdPantComun, RadioButton rdPrendaStandard, RadioButton rdPrendaPremium,
                RadioButton rdCamisa, RadioButton rdMangaLarga, RadioButton rdMangaCorta, RadioButton rdCamMao, RadioButton rdCamComun, TextBox total)
        {
            double precio = precioUnitario * cantDePrendas;//Calculo el precio
            if (rdCamisa.Checked && rdMangaCorta.Checked)
                precio = precio - (precio / 10);//Resta 10% si es manga corta
            if (rdCamisa.Checked && rdCamMao.Checked)
                precio = precio * 1.03;//Suma 3% si es cuello mao
            if (rdPantalon.Checked && rdPantChupin.Checked)
                precio = precio - (precio / 12);//Si pantalon es chupin rebajo 12%
            if (rdCamisa.Checked && rdPrendaPremium.Checked)
                precio = precio * 1.3;//Sumo un 30% al valor de la prenda camisa
            if (rdPantalon.Checked && rdPrendaPremium.Checked)
                precio = precio * 1.3;//Sumo un 30% al valor de la prenda pantalon
            if (rdPantalon.Checked && rdPantChupin.Checked && rdPrendaStandard.Checked)//Prenda Pantalon/Chupin/Standar   
            {
                this.prendaAcotizar = rdPantalon.Text + " :: " + rdPantChupin.Text + " :: " + rdPrendaStandard.Text;
                this.cantDeUnidadesCotizadasPantalon = cantDePrendas;
            }
            if (rdPantalon.Checked && rdPantChupin.Checked && rdPrendaPremium.Checked)// Prenda Pantalon/Chupin/Premiun
            {
                this.prendaAcotizar = rdPantalon.Text + " :: " + rdPantChupin.Text + " :: " + rdPrendaPremium.Text;
                this.cantDeUnidadesCotizadasPantalon = cantDePrendas;
            }
            if (rdPantalon.Checked && rdPantComun.Checked && rdPrendaStandard.Checked)//Prenda Pantalon/Comun/Standar
            {
                this.prendaAcotizar = rdPantalon.Text + " :: " + rdPantComun.Text + " :: " + rdPrendaStandard.Text;
                this.cantDeUnidadesCotizadasPantalon = cantDePrendas;
            }
            if (rdPantalon.Checked && rdPantComun.Checked && rdPrendaPremium.Checked)// Prenda Pantalon/Comun/Premiun
            {
                this.prendaAcotizar = rdPantalon.Text + " :: " + rdPantComun.Text + " :: " + rdPrendaPremium.Text;
                this.cantDeUnidadesCotizadasPantalon = cantDePrendas;
            }
            if (rdCamisa.Checked && rdCamComun.Checked && rdMangaCorta.Checked && rdPrendaStandard.Checked)//Prenda Camisa/CuelloCom/MangaCorta/Standar
            {
                this.prendaAcotizar = rdCamisa.Text + " :: " + rdCamComun.Text + " :: " + rdMangaCorta.Text + " :: " + rdPrendaStandard.Text;
                this.cantDeUnidadesCotizadasCamisa = cantDePrendas;
            }
            if (rdCamisa.Checked && rdCamComun.Checked && rdMangaCorta.Checked && rdPrendaPremium.Checked)//Prenda Camisa/CuelloCom/MangaCorta/Premium
            {
                this.prendaAcotizar = rdCamisa.Text + " :: " + rdCamComun.Text + " :: " + rdMangaCorta.Text + " :: " + rdPrendaPremium.Text;
                this.cantDeUnidadesCotizadasCamisa = cantDePrendas;
            }
            if (rdCamisa.Checked && rdCamComun.Checked && rdMangaLarga.Checked && rdPrendaStandard.Checked)//Prenda Camisa/CuelloCom/MangaLarga/Standar
            {
                this.prendaAcotizar = rdCamisa.Text + " :: " + rdCamComun.Text + " :: " + rdMangaLarga.Text + " :: " + rdPrendaStandard.Text;
                this.cantDeUnidadesCotizadasCamisa = cantDePrendas;
            }
            if (rdCamisa.Checked && rdCamComun.Checked && rdMangaLarga.Checked && rdPrendaPremium.Checked)//Prenda Camisa/CuelloCom/MangaLarga/Premium
            {
                this.prendaAcotizar = rdCamisa.Text + " :: " + rdCamComun.Text + " :: " + rdMangaLarga.Text + " :: " + rdPrendaPremium.Text;
                this.cantDeUnidadesCotizadasCamisa = cantDePrendas;
            }
            if (rdCamisa.Checked && rdCamMao.Checked && rdMangaCorta.Checked && rdPrendaStandard.Checked)//Prenda Camisa/CuelloMao/MangaCorta/Standar
            {
                this.prendaAcotizar = rdCamisa.Text + " :: " + rdCamMao.Text + " :: " + rdMangaCorta.Text + " :: " + rdPrendaStandard.Text;
                this.cantDeUnidadesCotizadasCamisa = cantDePrendas;
            }
            if (rdCamisa.Checked && rdCamMao.Checked && rdMangaCorta.Checked && rdPrendaPremium.Checked)//Prenda Camisa/CuelloMao/MangaCorta/Premium
            {
                this.prendaAcotizar = rdCamisa.Text + " :: " + rdCamMao.Text + " :: " + rdMangaCorta.Text + " :: " + rdPrendaPremium.Text;
                this.cantDeUnidadesCotizadasCamisa = cantDePrendas;
            }
            if (rdCamisa.Checked && rdCamMao.Checked && rdMangaLarga.Checked && rdPrendaStandard.Checked)//Prenda Camisa/CuelloMao/MangaLarga/Standar
            {
                this.prendaAcotizar = rdCamisa.Text + " :: " + rdCamMao.Text + " :: " + rdMangaLarga.Text + " :: " + rdPrendaStandard.Text;
                this.cantDeUnidadesCotizadasCamisa = cantDePrendas;
            }
            if (rdCamisa.Checked && rdCamMao.Checked && rdMangaLarga.Checked && rdPrendaPremium.Checked)//Prenda Camisa/CuelloMao/MangaLarga/Premium
            {
                this.prendaAcotizar = rdCamisa.Text + " :: " + rdCamMao.Text + " :: " + rdMangaLarga.Text + " :: " + rdPrendaPremium.Text;
                this.cantDeUnidadesCotizadasCamisa = cantDePrendas;
            }
            total.Text = precio.ToString();
            this.resultadoCotizacion = precio;
            this.codigoDelVendedor = Vende.CodigoVendedor;
        }
        //MEtodo que modifica el id fecha y hora de la cotizacion cada vez que se cotiza
        //un producto
        public void modIdFechaYhora()
        {
            //GuardoFecha y hora al clikear en cotizar
            this.fechaYhora = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
            long num = 1;
            this.numeroDeId = (num + this.numeroDeId);//Agrego un +1 al id por cada cotizacion así no son todos iguales

        }
        //Metodo que rellena el DataGridView
        public void rellenarDataGridView(DataGridView datos)
        {

            long numID = NumeroDeId;
            String fecha = FechaYhora;
            long codVendedor = CodigoDelVendedor;
            String prendaCotizar = PrendaAcotizar;
            long cantCamisa = CantDeUnidadesCotizadasCamisa;
            long cantPantalon = CantDeUnidadesCotizadasPantalon;
            double total = ResultadoCotizacion;
            datos.Rows.Add(numID, fecha, codVendedor, prendaCotizar, cantCamisa, cantPantalon, total);
            this.ListaImprimir.Add(new Cotizacion(numID, fecha, codVendedor, prendaCotizar, cantCamisa, cantPantalon, total));
            this.InternalData = datos;
        }

    }
}
