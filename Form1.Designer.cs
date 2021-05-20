namespace Conexion
{
    partial class Exportar
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grilla = new System.Windows.Forms.DataGridView();
            this.Btnsalir = new System.Windows.Forms.Button();
            this.Btnexportar = new System.Windows.Forms.Button();
            this.btnprocesar = new System.Windows.Forms.Button();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.lbldesde = new System.Windows.Forms.Label();
            this.lblhasta = new System.Windows.Forms.Label();
            this.mtxtdesde = new System.Windows.Forms.MaskedTextBox();
            this.mtxthasta = new System.Windows.Forms.MaskedTextBox();
            this.txtlista = new System.Windows.Forms.TextBox();
            this.lbllista = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // grilla
            // 
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Location = new System.Drawing.Point(39, 43);
            this.grilla.MultiSelect = false;
            this.grilla.Name = "grilla";
            this.grilla.ReadOnly = true;
            this.grilla.Size = new System.Drawing.Size(621, 364);
            this.grilla.TabIndex = 4;
            this.grilla.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.grilla_RowPostPaint);
            // 
            // Btnsalir
            // 
            this.Btnsalir.Location = new System.Drawing.Point(666, 377);
            this.Btnsalir.Name = "Btnsalir";
            this.Btnsalir.Size = new System.Drawing.Size(109, 30);
            this.Btnsalir.TabIndex = 5;
            this.Btnsalir.Text = "Salir";
            this.Btnsalir.UseVisualStyleBackColor = true;
            this.Btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // Btnexportar
            // 
            this.Btnexportar.Location = new System.Drawing.Point(666, 43);
            this.Btnexportar.Name = "Btnexportar";
            this.Btnexportar.Size = new System.Drawing.Size(109, 30);
            this.Btnexportar.TabIndex = 3;
            this.Btnexportar.Text = "Exportar";
            this.Btnexportar.UseVisualStyleBackColor = true;
            this.Btnexportar.Click += new System.EventHandler(this.Btnexportar_Click);
            // 
            // btnprocesar
            // 
            this.btnprocesar.Location = new System.Drawing.Point(551, 7);
            this.btnprocesar.Name = "btnprocesar";
            this.btnprocesar.Size = new System.Drawing.Size(109, 30);
            this.btnprocesar.TabIndex = 2;
            this.btnprocesar.Text = "Procesar";
            this.btnprocesar.UseVisualStyleBackColor = true;
            this.btnprocesar.Click += new System.EventHandler(this.btnprocesar_Click);
            // 
            // cmb
            // 
            this.cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb.FormattingEnabled = true;
            this.cmb.Location = new System.Drawing.Point(39, 12);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(153, 21);
            this.cmb.TabIndex = 1;
            this.cmb.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectedIndexChanged);
            // 
            // lbldesde
            // 
            this.lbldesde.AutoSize = true;
            this.lbldesde.Location = new System.Drawing.Point(233, 20);
            this.lbldesde.Name = "lbldesde";
            this.lbldesde.Size = new System.Drawing.Size(38, 13);
            this.lbldesde.TabIndex = 7;
            this.lbldesde.Text = "Desde";
            // 
            // lblhasta
            // 
            this.lblhasta.AutoSize = true;
            this.lblhasta.Location = new System.Drawing.Point(394, 20);
            this.lblhasta.Name = "lblhasta";
            this.lblhasta.Size = new System.Drawing.Size(35, 13);
            this.lblhasta.TabIndex = 9;
            this.lblhasta.Text = "Hasta";
            // 
            // mtxtdesde
            // 
            this.mtxtdesde.Location = new System.Drawing.Point(277, 17);
            this.mtxtdesde.Mask = "00/00/0000";
            this.mtxtdesde.Name = "mtxtdesde";
            this.mtxtdesde.Size = new System.Drawing.Size(100, 20);
            this.mtxtdesde.TabIndex = 10;
            this.mtxtdesde.ValidatingType = typeof(System.DateTime);
            // 
            // mtxthasta
            // 
            this.mtxthasta.Location = new System.Drawing.Point(435, 17);
            this.mtxthasta.Mask = "00/00/0000";
            this.mtxthasta.Name = "mtxthasta";
            this.mtxthasta.Size = new System.Drawing.Size(100, 20);
            this.mtxthasta.TabIndex = 11;
            this.mtxthasta.ValidatingType = typeof(System.DateTime);
            // 
            // txtlista
            // 
            this.txtlista.Location = new System.Drawing.Point(277, 17);
            this.txtlista.MaxLength = 3;
            this.txtlista.Name = "txtlista";
            this.txtlista.Size = new System.Drawing.Size(100, 20);
            this.txtlista.TabIndex = 12;
            this.txtlista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtlista_KeyPress);
            this.txtlista.Leave += new System.EventHandler(this.txtlista_Leave);
            // 
            // lbllista
            // 
            this.lbllista.AutoSize = true;
            this.lbllista.Location = new System.Drawing.Point(233, 20);
            this.lbllista.Name = "lbllista";
            this.lbllista.Size = new System.Drawing.Size(29, 13);
            this.lbllista.TabIndex = 13;
            this.lbllista.Text = "Lista";
            // 
            // Exportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbllista);
            this.Controls.Add(this.txtlista);
            this.Controls.Add(this.mtxthasta);
            this.Controls.Add(this.mtxtdesde);
            this.Controls.Add(this.lblhasta);
            this.Controls.Add(this.lbldesde);
            this.Controls.Add(this.cmb);
            this.Controls.Add(this.btnprocesar);
            this.Controls.Add(this.Btnexportar);
            this.Controls.Add(this.Btnsalir);
            this.Controls.Add(this.grilla);
            this.Name = "Exportar";
            this.Text = "Exportar tablas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btnsalir;
        private System.Windows.Forms.Button Btnexportar;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.Button btnprocesar;
        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.Label lbldesde;
        private System.Windows.Forms.Label lblhasta;
        private System.Windows.Forms.MaskedTextBox mtxtdesde;
        private System.Windows.Forms.MaskedTextBox mtxthasta;
        private System.Windows.Forms.TextBox txtlista;
        private System.Windows.Forms.Label lbllista;
    }
}

