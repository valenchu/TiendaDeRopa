using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaDeRopa.Model;

namespace TiendaDeRopa.Controller
{
    class ControllerCotizacion
    {
        TiendaRopa tienda = new TiendaRopa();


        //Metodo para verificar los radio button
        public void verificacionRdPrenda(RadioButton rdCamisa, RadioButton rdPantalon, RadioButton rdCamLarga,
            RadioButton rdCamCorta, RadioButton rdCamMao, RadioButton rdCamCom, RadioButton rdPanChu, RadioButton rdPanCom,
            GroupBox grupTiposPantalon, GroupBox grupCamisaManga, GroupBox grupCamisaCuello)
        {
            if (rdCamisa.Checked)
                grupTiposPantalon.Visible = false;
            else
                grupTiposPantalon.Visible = true;

            if (rdPantalon.Checked)
            {
                grupCamisaManga.Visible = false;
                grupCamisaCuello.Visible = false;
            }
            else
            {
                grupCamisaManga.Visible = true;
                grupCamisaCuello.Visible = true;
            }
        }
        //Metodo que segun lo que se le pasa por variable se carga la cantidad de unidades en stock Camisa
        public void verificacionCamisa(RadioButton rdCamisa, RadioButton rdCamLarga, RadioButton rdCamCorta, RadioButton rdCamMao, RadioButton rdCamCom, Label unidadesStock, RadioButton rdStandard, RadioButton rdPremium, TextBox txtPreUnit)
        {
            //Cargo unidades stock camisa  corta/ comun /standard
            if (rdCamisa.Checked && rdCamCorta.Checked && rdCamCom.Checked && rdStandard.Checked)
                tienda.mostrarUnidadesStockCamisa(rdCamCorta.Text, rdCamCom.Text, rdStandard.Text, unidadesStock, txtPreUnit);
            //Cargo unidades stock camisa  larga/ comun /standard
            if (rdCamisa.Checked && rdCamLarga.Checked && rdCamCom.Checked && rdStandard.Checked)
                tienda.mostrarUnidadesStockCamisa(rdCamLarga.Text, rdCamCom.Text, rdStandard.Text, unidadesStock, txtPreUnit);
            //Cargo unidades stock camisa  corta/ mao /standard
            if (rdCamisa.Checked && rdCamCorta.Checked && rdCamMao.Checked && rdStandard.Checked)
                tienda.mostrarUnidadesStockCamisa(rdCamCorta.Text, rdCamMao.Text, rdStandard.Text, unidadesStock, txtPreUnit);
            //Cargo unidades stock camisa  larga/ mao /standard
            if (rdCamisa.Checked && rdCamLarga.Checked && rdCamMao.Checked && rdStandard.Checked)
                tienda.mostrarUnidadesStockCamisa(rdCamLarga.Text, rdCamMao.Text, rdStandard.Text, unidadesStock, txtPreUnit);
            //Cargo unidades stock camisa  corta/ comun /premium
            if (rdCamisa.Checked && rdCamCorta.Checked && rdCamCom.Checked && rdPremium.Checked)
                tienda.mostrarUnidadesStockCamisa(rdCamCorta.Text, rdCamCom.Text, rdPremium.Text, unidadesStock, txtPreUnit);
            //Cargo unidades stock camisa  larga/ comun /premium
            if (rdCamisa.Checked && rdCamLarga.Checked && rdCamCom.Checked && rdPremium.Checked)
                tienda.mostrarUnidadesStockCamisa(rdCamLarga.Text, rdCamCom.Text, rdPremium.Text, unidadesStock, txtPreUnit);
            //Cargo unidades stock camisa  corta/ mao /premium
            if (rdCamisa.Checked && rdCamCorta.Checked && rdCamMao.Checked && rdPremium.Checked)
                tienda.mostrarUnidadesStockCamisa(rdCamCorta.Text, rdCamMao.Text, rdPremium.Text, unidadesStock, txtPreUnit);
            //Cargo unidades stock camisa  larga/ mao /premium
            if (rdCamisa.Checked && rdCamLarga.Checked && rdCamMao.Checked && rdPremium.Checked)
                tienda.mostrarUnidadesStockCamisa(rdCamLarga.Text, rdCamMao.Text, rdPremium.Text, unidadesStock, txtPreUnit);

        }
        //Metodo que segun lo que se le pasa por variable se carga la cantidad de unidades en stock PAntalon
        public void verificacionPantalon(RadioButton rdPantalon, RadioButton rdPanChu, RadioButton rdPanComun, Label unidadesStock, RadioButton rdStandard, RadioButton rdPremium, TextBox txtPreUnit)
        {
            //Cargo unidades stock pantalon comun/standard
            if (rdPantalon.Checked && rdPanComun.Checked && rdStandard.Checked)
                tienda.mostrarUnidadesStockPantalon(rdPanComun.Text, rdStandard.Text, unidadesStock, txtPreUnit);
            //Cargo unidades stock pantalon chupin/standard
            if (rdPantalon.Checked && rdPanChu.Checked && rdStandard.Checked)
                tienda.mostrarUnidadesStockPantalon(rdPanChu.Text, rdStandard.Text, unidadesStock, txtPreUnit);
            //Cargo unidades stock pantalon comun/premium
            if (rdPantalon.Checked && rdPanComun.Checked && rdPremium.Checked)
                tienda.mostrarUnidadesStockPantalon(rdPanComun.Text, rdPremium.Text, unidadesStock, txtPreUnit);
            //Cargo unidades stock pantalon chupin/premium
            if (rdPantalon.Checked && rdPanChu.Checked && rdPremium.Checked)
                tienda.mostrarUnidadesStockPantalon(rdPanChu.Text, rdPremium.Text, unidadesStock, txtPreUnit);

        }
        //Metodo que cambia el precio unitario de las prendas
        public void precioUni(RadioButton rdPantalon, RadioButton rdPanChu, RadioButton rdPanComun, Label unidadesStock, RadioButton rdStandard, RadioButton rdPremium, TextBox txtPreUnit,
           RadioButton rdCamisa, RadioButton rdCamLarga, RadioButton rdCamCorta, RadioButton rdCamMao, RadioButton rdCamCom)
        {
            //Cargo unidades stock camisa  corta/ comun /standard
            if (rdCamisa.Checked && rdCamCorta.Checked && rdCamCom.Checked && rdStandard.Checked)
                tienda.pCamisa(rdCamCorta.Text, rdCamCom.Text, rdStandard.Text, unidadesStock, txtPreUnit);
            //Cargo unidades stock camisa  larga/ comun /standard
            if (rdCamisa.Checked && rdCamLarga.Checked && rdCamCom.Checked && rdStandard.Checked)
                tienda.pCamisa(rdCamLarga.Text, rdCamCom.Text, rdStandard.Text, unidadesStock, txtPreUnit);
            //Cargo unidades stock camisa  corta/ mao /standard
            if (rdCamisa.Checked && rdCamCorta.Checked && rdCamMao.Checked && rdStandard.Checked)
                tienda.pCamisa(rdCamCorta.Text, rdCamMao.Text, rdStandard.Text, unidadesStock, txtPreUnit);
            //Cargo unidades stock camisa  larga/ mao /standard
            if (rdCamisa.Checked && rdCamLarga.Checked && rdCamMao.Checked && rdStandard.Checked)
                tienda.pCamisa(rdCamLarga.Text, rdCamMao.Text, rdStandard.Text, unidadesStock, txtPreUnit);
            //Cargo unidades stock camisa  corta/ comun /premium
            if (rdCamisa.Checked && rdCamCorta.Checked && rdCamCom.Checked && rdPremium.Checked)
                tienda.pCamisa(rdCamCorta.Text, rdCamCom.Text, rdPremium.Text, unidadesStock, txtPreUnit);
            //Cargo unidades stock camisa  larga/ comun /premium
            if (rdCamisa.Checked && rdCamLarga.Checked && rdCamCom.Checked && rdPremium.Checked)
                tienda.pCamisa(rdCamLarga.Text, rdCamCom.Text, rdPremium.Text, unidadesStock, txtPreUnit);
            //Cargo unidades stock camisa  corta/ mao /premium
            if (rdCamisa.Checked && rdCamCorta.Checked && rdCamMao.Checked && rdPremium.Checked)
                tienda.pCamisa(rdCamCorta.Text, rdCamMao.Text, rdPremium.Text, unidadesStock, txtPreUnit);
            //Cargo unidades stock camisa  larga/ mao /premium
            if (rdCamisa.Checked && rdCamLarga.Checked && rdCamMao.Checked && rdPremium.Checked)
                tienda.pCamisa(rdCamLarga.Text, rdCamMao.Text, rdPremium.Text, unidadesStock, txtPreUnit);
            //Cargo unidades stock pantalon comun/standard
            if (rdPantalon.Checked && rdPanComun.Checked && rdStandard.Checked)
                tienda.pPantalon(rdPanComun.Text, rdStandard.Text, unidadesStock, txtPreUnit);
            //Cargo unidades stock pantalon chupin/standard
            if (rdPantalon.Checked && rdPanChu.Checked && rdStandard.Checked)
                tienda.pPantalon(rdPanChu.Text, rdStandard.Text, unidadesStock, txtPreUnit);
            //Cargo unidades stock pantalon comun/premium
            if (rdPantalon.Checked && rdPanComun.Checked && rdPremium.Checked)
                tienda.pPantalon(rdPanComun.Text, rdPremium.Text, unidadesStock, txtPreUnit);
            //Cargo unidades stock pantalon chupin/premium
            if (rdPantalon.Checked && rdPanChu.Checked && rdPremium.Checked)
                tienda.pPantalon(rdPanChu.Text, rdPremium.Text, unidadesStock, txtPreUnit);
        }
        //Metodo que verifica la cotizacion y la envia a la clase Cotizacion
        public Boolean analizarCotizacion(TextBox precioUnitario, TextBox cantidadProductos)
        {
            Double verificar = 0;
            Int32 verCant = 0;
            //Verifico que no esten vacios los campos txt
            if (precioUnitario.Text.Length.Equals(0) || cantidadProductos.Text.Length.Equals(0))
            {
                MessageBox.Show("Posee campos vacios para realizar el calculo", "Vacio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            //Verifico que sea un double y un int los campos txt
            else if (!Double.TryParse(precioUnitario.Text, out verificar) || !Int32.TryParse(cantidadProductos.Text, out verCant))
            {
                precioUnitario.Text = "";
                cantidadProductos.Text = "";
                MessageBox.Show("Datos erroneos precio unitario o cantidad", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                //Si toda la verificacion de double y int es correcta guardo los datos
                verificar = Double.Parse(precioUnitario.Text);
                verCant = Int32.Parse(cantidadProductos.Text);
            }
            //Finalmente verifico que sean mayores a 0 ambos
            if (verificar < 0 || verCant < 0)
            {
                precioUnitario.Text = "";
                cantidadProductos.Text = "";
                MessageBox.Show("Datos erroneos precio unitario o cantidad", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
        //Metodo que envia la lista a verificar
        public Boolean cantPrenda(RadioButton rdPantalon, RadioButton rdPanChu, RadioButton rdPanComun, RadioButton rdStandard, RadioButton rdPremium, TextBox cantPrenda,
          RadioButton rdCamisa, RadioButton rdCamLarga, RadioButton rdCamCorta, RadioButton rdCamMao, RadioButton rdCamCom)
        {
            Boolean verificarCantidad = false;
            //Cargo unidades stock camisa  corta/ comun /standard
            if (rdCamisa.Checked && rdCamCorta.Checked && rdCamCom.Checked && rdStandard.Checked)
                verificarCantidad = tienda.cantPrendaCamisa(rdCamCorta.Text, rdCamCom.Text, rdStandard.Text, cantPrenda);
            //Cargo unidades stock camisa  larga/ comun /standard
            if (rdCamisa.Checked && rdCamLarga.Checked && rdCamCom.Checked && rdStandard.Checked)
                verificarCantidad = tienda.cantPrendaCamisa(rdCamLarga.Text, rdCamCom.Text, rdStandard.Text, cantPrenda);
            //Cargo unidades stock camisa  corta/ mao /standard
            if (rdCamisa.Checked && rdCamCorta.Checked && rdCamMao.Checked && rdStandard.Checked)
                verificarCantidad = tienda.cantPrendaCamisa(rdCamCorta.Text, rdCamMao.Text, rdStandard.Text, cantPrenda);
            //Cargo unidades stock camisa  larga/ mao /standard
            if (rdCamisa.Checked && rdCamLarga.Checked && rdCamMao.Checked && rdStandard.Checked)
                verificarCantidad = tienda.cantPrendaCamisa(rdCamLarga.Text, rdCamMao.Text, rdStandard.Text, cantPrenda);
            //Cargo unidades stock camisa  corta/ comun /premium
            if (rdCamisa.Checked && rdCamCorta.Checked && rdCamCom.Checked && rdPremium.Checked)
                verificarCantidad = tienda.cantPrendaCamisa(rdCamCorta.Text, rdCamCom.Text, rdPremium.Text, cantPrenda);
            //Cargo unidades stock camisa  larga/ comun /premium
            if (rdCamisa.Checked && rdCamLarga.Checked && rdCamCom.Checked && rdPremium.Checked)
                verificarCantidad = tienda.cantPrendaCamisa(rdCamLarga.Text, rdCamCom.Text, rdPremium.Text, cantPrenda);
            //Cargo unidades stock camisa  corta/ mao /premium
            if (rdCamisa.Checked && rdCamCorta.Checked && rdCamMao.Checked && rdPremium.Checked)
                verificarCantidad = tienda.cantPrendaCamisa(rdCamCorta.Text, rdCamMao.Text, rdPremium.Text, cantPrenda);
            //Cargo unidades stock camisa  larga/ mao /premium
            if (rdCamisa.Checked && rdCamLarga.Checked && rdCamMao.Checked && rdPremium.Checked)
                verificarCantidad = tienda.cantPrendaCamisa(rdCamLarga.Text, rdCamMao.Text, rdPremium.Text, cantPrenda);
            //Cargo unidades stock pantalon comun / stand
            if (rdPantalon.Checked && rdPanComun.Checked && rdStandard.Checked)
                verificarCantidad = tienda.cantPrendaPantalon(rdPanComun.Text, rdStandard.Text, cantPrenda);
            //Cargo unidades stock pantalon chupin/standard
            if (rdPantalon.Checked && rdPanChu.Checked && rdStandard.Checked)
                verificarCantidad = tienda.cantPrendaPantalon(rdPanChu.Text, rdStandard.Text, cantPrenda);
            //Cargo unidades stock pantalon comun/premium
            if (rdPantalon.Checked && rdPanComun.Checked && rdPremium.Checked)
                verificarCantidad = tienda.cantPrendaPantalon(rdPanComun.Text, rdPremium.Text, cantPrenda);
            //Cargo unidades stock pantalon chupin/premium
            if (rdPantalon.Checked && rdPanChu.Checked && rdPremium.Checked)
                verificarCantidad = tienda.cantPrendaPantalon(rdPanChu.Text, rdPremium.Text, cantPrenda);
            if (verificarCantidad == true)
                MessageBox.Show("La cantidad ingresada es mayor a la que hay disponible", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return verificarCantidad;
        }
        
    }

}
