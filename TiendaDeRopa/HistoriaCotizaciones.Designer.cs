
namespace TiendaDeRopa
{
    partial class HistoriaCotizaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoriaCotizaciones));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prendaCotizar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantUniCamisa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantUniLompa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCotizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numID,
            this.fechaHora,
            this.codVendedor,
            this.prendaCotizar,
            this.cantUniCamisa,
            this.cantUniLompa,
            this.totalCotizado});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1089, 159);
            this.dataGridView1.TabIndex = 0;
            // 
            // numID
            // 
            this.numID.HeaderText = "Num ID";
            this.numID.MinimumWidth = 6;
            this.numID.Name = "numID";
            this.numID.ReadOnly = true;
            this.numID.Width = 83;
            // 
            // fechaHora
            // 
            this.fechaHora.HeaderText = "Fecha";
            this.fechaHora.MinimumWidth = 6;
            this.fechaHora.Name = "fechaHora";
            this.fechaHora.ReadOnly = true;
            this.fechaHora.Width = 76;
            // 
            // codVendedor
            // 
            this.codVendedor.HeaderText = "Codigo vendedor";
            this.codVendedor.MinimumWidth = 6;
            this.codVendedor.Name = "codVendedor";
            this.codVendedor.ReadOnly = true;
            this.codVendedor.Width = 145;
            // 
            // prendaCotizar
            // 
            this.prendaCotizar.HeaderText = "Prenda";
            this.prendaCotizar.MinimumWidth = 6;
            this.prendaCotizar.Name = "prendaCotizar";
            this.prendaCotizar.ReadOnly = true;
            this.prendaCotizar.Width = 83;
            // 
            // cantUniCamisa
            // 
            this.cantUniCamisa.HeaderText = "Cant cotizada Camisa";
            this.cantUniCamisa.MinimumWidth = 6;
            this.cantUniCamisa.Name = "cantUniCamisa";
            this.cantUniCamisa.ReadOnly = true;
            this.cantUniCamisa.Width = 173;
            // 
            // cantUniLompa
            // 
            this.cantUniLompa.HeaderText = "Cant cotizada Pantalon";
            this.cantUniLompa.MinimumWidth = 6;
            this.cantUniLompa.Name = "cantUniLompa";
            this.cantUniLompa.ReadOnly = true;
            this.cantUniLompa.Width = 183;
            // 
            // totalCotizado
            // 
            this.totalCotizado.HeaderText = "Total";
            this.totalCotizado.MinimumWidth = 6;
            this.totalCotizado.Name = "totalCotizado";
            this.totalCotizado.ReadOnly = true;
            this.totalCotizado.Width = 69;
            // 
            // HistoriaCotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1089, 450);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HistoriaCotizaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistoriaCotizaciones";
            this.Load += new System.EventHandler(this.HistoriaCotizaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn codVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn prendaCotizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantUniCamisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantUniLompa;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCotizado;
    }
}