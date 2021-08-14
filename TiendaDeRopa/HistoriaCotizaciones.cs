using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaDeRopa.Model;

namespace TiendaDeRopa
{
    public partial class HistoriaCotizaciones : Form
    {
        public DataGridView data = new DataGridView();
        public HistoriaCotizaciones()
        {
            InitializeComponent();
          
        }
        
        private void HistoriaCotizaciones_Load(object sender, EventArgs e)
        {
            //Cotizacion co = new Cotizacion();
            //Label l = new Label();
            //co.agregarDatosDataGridView(dataGridView1,  l);
        }
    }
}
