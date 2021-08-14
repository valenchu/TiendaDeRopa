
namespace TiendaDeRopa
{
    partial class formStock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formStock));
            this.lblTitel = new System.Windows.Forms.Label();
            this.lblCodeVendedor = new System.Windows.Forms.Label();
            this.lblDireciionTienda = new System.Windows.Forms.Label();
            this.lblNomTienda = new System.Windows.Forms.Label();
            this.lblLinkHistorial = new System.Windows.Forms.LinkLabel();
            this.lblNombreApellido = new System.Windows.Forms.Label();
            this.grupPrenda = new System.Windows.Forms.GroupBox();
            this.rdPantalon = new System.Windows.Forms.RadioButton();
            this.rdCamisa = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblStockDisp = new System.Windows.Forms.Label();
            this.grupCalidadPrenda = new System.Windows.Forms.GroupBox();
            this.rdPrendaPremium = new System.Windows.Forms.RadioButton();
            this.rdPrendaStandard = new System.Windows.Forms.RadioButton();
            this.grupPrecioCantidad = new System.Windows.Forms.GroupBox();
            this.txtCantidadPrenda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTest = new System.Windows.Forms.Label();
            this.grupManga = new System.Windows.Forms.GroupBox();
            this.rdMangaCorta = new System.Windows.Forms.RadioButton();
            this.rdMangaLarga = new System.Windows.Forms.RadioButton();
            this.grupPantalon = new System.Windows.Forms.GroupBox();
            this.rdPantComun = new System.Windows.Forms.RadioButton();
            this.rdPantChupin = new System.Windows.Forms.RadioButton();
            this.grupCuello = new System.Windows.Forms.GroupBox();
            this.rdCamComun = new System.Windows.Forms.RadioButton();
            this.rdCamMao = new System.Windows.Forms.RadioButton();
            this.btnListaStock = new System.Windows.Forms.Button();
            this.lblLinkImprimir = new System.Windows.Forms.LinkLabel();
            this.imprimirD = new System.Drawing.Printing.PrintDocument();
            this.lblImpCotActual = new System.Windows.Forms.LinkLabel();
            this.grupPrenda.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grupCalidadPrenda.SuspendLayout();
            this.grupPrecioCantidad.SuspendLayout();
            this.grupManga.SuspendLayout();
            this.grupPantalon.SuspendLayout();
            this.grupCuello.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblTitel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitel.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.lblTitel, "lblTitel");
            this.lblTitel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitel.Name = "lblTitel";
            // 
            // lblCodeVendedor
            // 
            resources.ApplyResources(this.lblCodeVendedor, "lblCodeVendedor");
            this.lblCodeVendedor.Name = "lblCodeVendedor";
            // 
            // lblDireciionTienda
            // 
            resources.ApplyResources(this.lblDireciionTienda, "lblDireciionTienda");
            this.lblDireciionTienda.Name = "lblDireciionTienda";
            // 
            // lblNomTienda
            // 
            resources.ApplyResources(this.lblNomTienda, "lblNomTienda");
            this.lblNomTienda.Name = "lblNomTienda";
            // 
            // lblLinkHistorial
            // 
            resources.ApplyResources(this.lblLinkHistorial, "lblLinkHistorial");
            this.lblLinkHistorial.Name = "lblLinkHistorial";
            this.lblLinkHistorial.TabStop = true;
            this.lblLinkHistorial.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkHistorial_LinkClicked);
            // 
            // lblNombreApellido
            // 
            resources.ApplyResources(this.lblNombreApellido, "lblNombreApellido");
            this.lblNombreApellido.Name = "lblNombreApellido";
            // 
            // grupPrenda
            // 
            resources.ApplyResources(this.grupPrenda, "grupPrenda");
            this.grupPrenda.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grupPrenda.Controls.Add(this.rdPantalon);
            this.grupPrenda.Controls.Add(this.rdCamisa);
            this.grupPrenda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grupPrenda.Name = "grupPrenda";
            this.grupPrenda.TabStop = false;
            // 
            // rdPantalon
            // 
            resources.ApplyResources(this.rdPantalon, "rdPantalon");
            this.rdPantalon.Name = "rdPantalon";
            this.rdPantalon.UseVisualStyleBackColor = true;
            this.rdPantalon.CheckedChanged += new System.EventHandler(this.rdPantalon_CheckedChanged);
            // 
            // rdCamisa
            // 
            resources.ApplyResources(this.rdCamisa, "rdCamisa");
            this.rdCamisa.Checked = true;
            this.rdCamisa.Name = "rdCamisa";
            this.rdCamisa.TabStop = true;
            this.rdCamisa.UseVisualStyleBackColor = true;
            this.rdCamisa.CheckedChanged += new System.EventHandler(this.rdCamisa_CheckedChanged);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.lblResultado);
            this.panel1.Controls.Add(this.lblStockDisp);
            this.panel1.Name = "panel1";
            // 
            // lblResultado
            // 
            resources.ApplyResources(this.lblResultado, "lblResultado");
            this.lblResultado.Name = "lblResultado";
            // 
            // lblStockDisp
            // 
            resources.ApplyResources(this.lblStockDisp, "lblStockDisp");
            this.lblStockDisp.Name = "lblStockDisp";
            // 
            // grupCalidadPrenda
            // 
            this.grupCalidadPrenda.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grupCalidadPrenda.Controls.Add(this.rdPrendaPremium);
            this.grupCalidadPrenda.Controls.Add(this.rdPrendaStandard);
            resources.ApplyResources(this.grupCalidadPrenda, "grupCalidadPrenda");
            this.grupCalidadPrenda.Name = "grupCalidadPrenda";
            this.grupCalidadPrenda.TabStop = false;
            // 
            // rdPrendaPremium
            // 
            resources.ApplyResources(this.rdPrendaPremium, "rdPrendaPremium");
            this.rdPrendaPremium.Name = "rdPrendaPremium";
            this.rdPrendaPremium.UseVisualStyleBackColor = true;
            this.rdPrendaPremium.CheckedChanged += new System.EventHandler(this.rdPrendaPremium_CheckedChanged);
            // 
            // rdPrendaStandard
            // 
            resources.ApplyResources(this.rdPrendaStandard, "rdPrendaStandard");
            this.rdPrendaStandard.Checked = true;
            this.rdPrendaStandard.Name = "rdPrendaStandard";
            this.rdPrendaStandard.TabStop = true;
            this.rdPrendaStandard.UseVisualStyleBackColor = true;
            this.rdPrendaStandard.CheckedChanged += new System.EventHandler(this.rdPrendaStandard_CheckedChanged);
            // 
            // grupPrecioCantidad
            // 
            resources.ApplyResources(this.grupPrecioCantidad, "grupPrecioCantidad");
            this.grupPrecioCantidad.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grupPrecioCantidad.Controls.Add(this.txtCantidadPrenda);
            this.grupPrecioCantidad.Controls.Add(this.label3);
            this.grupPrecioCantidad.Controls.Add(this.txtPrecioUnitario);
            this.grupPrecioCantidad.Controls.Add(this.label2);
            this.grupPrecioCantidad.Name = "grupPrecioCantidad";
            this.grupPrecioCantidad.TabStop = false;
            // 
            // txtCantidadPrenda
            // 
            resources.ApplyResources(this.txtCantidadPrenda, "txtCantidadPrenda");
            this.txtCantidadPrenda.Name = "txtCantidadPrenda";
            this.txtCantidadPrenda.ShortcutsEnabled = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtPrecioUnitario
            // 
            resources.ApplyResources(this.txtPrecioUnitario, "txtPrecioUnitario");
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.ShortcutsEnabled = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnCotizar
            // 
            this.btnCotizar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.btnCotizar, "btnCotizar");
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.UseVisualStyleBackColor = false;
            this.btnCotizar.Click += new System.EventHandler(this.btnCotizar_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.txtTotal, "txtTotal");
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            // 
            // lblTest
            // 
            resources.ApplyResources(this.lblTest, "lblTest");
            this.lblTest.Name = "lblTest";
            // 
            // grupManga
            // 
            this.grupManga.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grupManga.Controls.Add(this.rdMangaCorta);
            this.grupManga.Controls.Add(this.rdMangaLarga);
            resources.ApplyResources(this.grupManga, "grupManga");
            this.grupManga.Name = "grupManga";
            this.grupManga.TabStop = false;
            // 
            // rdMangaCorta
            // 
            resources.ApplyResources(this.rdMangaCorta, "rdMangaCorta");
            this.rdMangaCorta.Checked = true;
            this.rdMangaCorta.Name = "rdMangaCorta";
            this.rdMangaCorta.TabStop = true;
            this.rdMangaCorta.UseVisualStyleBackColor = true;
            this.rdMangaCorta.CheckedChanged += new System.EventHandler(this.rdMangaCorta_CheckedChanged);
            // 
            // rdMangaLarga
            // 
            resources.ApplyResources(this.rdMangaLarga, "rdMangaLarga");
            this.rdMangaLarga.Name = "rdMangaLarga";
            this.rdMangaLarga.UseVisualStyleBackColor = true;
            this.rdMangaLarga.CheckedChanged += new System.EventHandler(this.rdMangaLarga_CheckedChanged);
            // 
            // grupPantalon
            // 
            this.grupPantalon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grupPantalon.Controls.Add(this.rdPantComun);
            this.grupPantalon.Controls.Add(this.rdPantChupin);
            resources.ApplyResources(this.grupPantalon, "grupPantalon");
            this.grupPantalon.Name = "grupPantalon";
            this.grupPantalon.TabStop = false;
            // 
            // rdPantComun
            // 
            resources.ApplyResources(this.rdPantComun, "rdPantComun");
            this.rdPantComun.Checked = true;
            this.rdPantComun.Name = "rdPantComun";
            this.rdPantComun.TabStop = true;
            this.rdPantComun.UseVisualStyleBackColor = true;
            this.rdPantComun.CheckedChanged += new System.EventHandler(this.rdPantComun_CheckedChanged);
            // 
            // rdPantChupin
            // 
            resources.ApplyResources(this.rdPantChupin, "rdPantChupin");
            this.rdPantChupin.Name = "rdPantChupin";
            this.rdPantChupin.UseVisualStyleBackColor = true;
            this.rdPantChupin.CheckedChanged += new System.EventHandler(this.rdPantChupin_CheckedChanged);
            // 
            // grupCuello
            // 
            this.grupCuello.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grupCuello.Controls.Add(this.rdCamComun);
            this.grupCuello.Controls.Add(this.rdCamMao);
            resources.ApplyResources(this.grupCuello, "grupCuello");
            this.grupCuello.Name = "grupCuello";
            this.grupCuello.TabStop = false;
            // 
            // rdCamComun
            // 
            resources.ApplyResources(this.rdCamComun, "rdCamComun");
            this.rdCamComun.Checked = true;
            this.rdCamComun.Name = "rdCamComun";
            this.rdCamComun.TabStop = true;
            this.rdCamComun.UseVisualStyleBackColor = true;
            this.rdCamComun.CheckedChanged += new System.EventHandler(this.rdCamComun_CheckedChanged);
            // 
            // rdCamMao
            // 
            resources.ApplyResources(this.rdCamMao, "rdCamMao");
            this.rdCamMao.Name = "rdCamMao";
            this.rdCamMao.UseVisualStyleBackColor = true;
            this.rdCamMao.CheckedChanged += new System.EventHandler(this.rdCamMao_CheckedChanged);
            // 
            // btnListaStock
            // 
            this.btnListaStock.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.btnListaStock, "btnListaStock");
            this.btnListaStock.Name = "btnListaStock";
            this.btnListaStock.UseVisualStyleBackColor = false;
            this.btnListaStock.Click += new System.EventHandler(this.btnListaStock_Click);
            // 
            // lblLinkImprimir
            // 
            resources.ApplyResources(this.lblLinkImprimir, "lblLinkImprimir");
            this.lblLinkImprimir.Name = "lblLinkImprimir";
            this.lblLinkImprimir.TabStop = true;
            this.lblLinkImprimir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkImprimir_LinkClicked);
            // 
            // lblImpCotActual
            // 
            resources.ApplyResources(this.lblImpCotActual, "lblImpCotActual");
            this.lblImpCotActual.Name = "lblImpCotActual";
            this.lblImpCotActual.TabStop = true;
            this.lblImpCotActual.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblImpCotActual_LinkClicked);
            // 
            // formStock
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.lblImpCotActual);
            this.Controls.Add(this.lblLinkImprimir);
            this.Controls.Add(this.btnListaStock);
            this.Controls.Add(this.grupCuello);
            this.Controls.Add(this.grupPantalon);
            this.Controls.Add(this.grupManga);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnCotizar);
            this.Controls.Add(this.grupPrecioCantidad);
            this.Controls.Add(this.grupCalidadPrenda);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grupPrenda);
            this.Controls.Add(this.lblDireciionTienda);
            this.Controls.Add(this.lblLinkHistorial);
            this.Controls.Add(this.lblNombreApellido);
            this.Controls.Add(this.lblNomTienda);
            this.Controls.Add(this.lblCodeVendedor);
            this.Controls.Add(this.lblTitel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "formStock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grupPrenda.ResumeLayout(false);
            this.grupPrenda.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grupCalidadPrenda.ResumeLayout(false);
            this.grupCalidadPrenda.PerformLayout();
            this.grupPrecioCantidad.ResumeLayout(false);
            this.grupPrecioCantidad.PerformLayout();
            this.grupManga.ResumeLayout(false);
            this.grupManga.PerformLayout();
            this.grupPantalon.ResumeLayout(false);
            this.grupPantalon.PerformLayout();
            this.grupCuello.ResumeLayout(false);
            this.grupCuello.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblCodeVendedor;
        private System.Windows.Forms.Label lblDireciionTienda;
        private System.Windows.Forms.Label lblNomTienda;
        private System.Windows.Forms.LinkLabel lblLinkHistorial;
        private System.Windows.Forms.Label lblNombreApellido;
        private System.Windows.Forms.RadioButton rdPantalon;
        private System.Windows.Forms.RadioButton rdCamisa;
        private System.Windows.Forms.GroupBox grupPrenda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStockDisp;
        private System.Windows.Forms.GroupBox grupCalidadPrenda;
        private System.Windows.Forms.GroupBox grupPrecioCantidad;
        private System.Windows.Forms.Button btnCotizar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.RadioButton rdPrendaPremium;
        private System.Windows.Forms.RadioButton rdPrendaStandard;
        private System.Windows.Forms.TextBox txtCantidadPrenda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grupManga;
        private System.Windows.Forms.RadioButton rdMangaCorta;
        private System.Windows.Forms.RadioButton rdMangaLarga;
        private System.Windows.Forms.GroupBox grupPantalon;
        private System.Windows.Forms.RadioButton rdPantComun;
        private System.Windows.Forms.RadioButton rdPantChupin;
        private System.Windows.Forms.RadioButton rdCamComun;
        private System.Windows.Forms.RadioButton rdCamMao;
        private System.Windows.Forms.GroupBox grupCuello;
        private System.Windows.Forms.Button btnListaStock;
        private System.Windows.Forms.Label lblResultado;
        public System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.LinkLabel lblLinkImprimir;
        private System.Drawing.Printing.PrintDocument imprimirD;
        private System.Windows.Forms.LinkLabel lblImpCotActual;
    }
}

