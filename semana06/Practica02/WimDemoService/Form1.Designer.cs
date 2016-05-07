namespace WimDemoService
{
    partial class Form1
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
            this.dtgProveedor = new System.Windows.Forms.DataGridView();
            this.BtnConultar = new System.Windows.Forms.Button();
            this.cboProductos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgProveedor
            // 
            this.dtgProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProveedor.Location = new System.Drawing.Point(12, 73);
            this.dtgProveedor.Name = "dtgProveedor";
            this.dtgProveedor.Size = new System.Drawing.Size(500, 312);
            this.dtgProveedor.TabIndex = 7;
            // 
            // BtnConultar
            // 
            this.BtnConultar.Location = new System.Drawing.Point(301, 19);
            this.BtnConultar.Name = "BtnConultar";
            this.BtnConultar.Size = new System.Drawing.Size(75, 23);
            this.BtnConultar.TabIndex = 6;
            this.BtnConultar.Text = "Consultar";
            this.BtnConultar.UseVisualStyleBackColor = true;
            this.BtnConultar.Click += new System.EventHandler(this.BtnConultar_Click);
            // 
            // cboProductos
            // 
            this.cboProductos.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProductos.FormattingEnabled = true;
            this.cboProductos.Location = new System.Drawing.Point(104, 19);
            this.cboProductos.Name = "cboProductos";
            this.cboProductos.Size = new System.Drawing.Size(171, 21);
            this.cboProductos.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Producto:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 405);
            this.Controls.Add(this.dtgProveedor);
            this.Controls.Add(this.BtnConultar);
            this.Controls.Add(this.cboProductos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Jair Revilla";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgProveedor;
        private System.Windows.Forms.Button BtnConultar;
        private System.Windows.Forms.ComboBox cboProductos;
        private System.Windows.Forms.Label label1;
    }
}

