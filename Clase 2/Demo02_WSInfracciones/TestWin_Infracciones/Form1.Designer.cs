namespace TestWin_Infracciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMulta = new System.Windows.Forms.Label();
            this.lblPapeleta = new System.Windows.Forms.Label();
            this.ddgPapeletas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ddgPapeletas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar Placa:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(95, 20);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(125, 20);
            this.txtPlaca.TabIndex = 1;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(226, 18);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 2;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Multa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Papeleta:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblMulta
            // 
            this.lblMulta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMulta.Location = new System.Drawing.Point(385, 22);
            this.lblMulta.Name = "lblMulta";
            this.lblMulta.Size = new System.Drawing.Size(148, 19);
            this.lblMulta.TabIndex = 6;
            // 
            // lblPapeleta
            // 
            this.lblPapeleta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPapeleta.Location = new System.Drawing.Point(385, 57);
            this.lblPapeleta.Name = "lblPapeleta";
            this.lblPapeleta.Size = new System.Drawing.Size(318, 19);
            this.lblPapeleta.TabIndex = 7;
            // 
            // ddgPapeletas
            // 
            this.ddgPapeletas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ddgPapeletas.Location = new System.Drawing.Point(24, 107);
            this.ddgPapeletas.Name = "ddgPapeletas";
            this.ddgPapeletas.Size = new System.Drawing.Size(679, 191);
            this.ddgPapeletas.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 306);
            this.Controls.Add(this.ddgPapeletas);
            this.Controls.Add(this.lblPapeleta);
            this.Controls.Add(this.lblMulta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ddgPapeletas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMulta;
        private System.Windows.Forms.Label lblPapeleta;
        private System.Windows.Forms.DataGridView ddgPapeletas;
    }
}

