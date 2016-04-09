namespace DemoLINQ
{
    partial class Test1
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
            this.cbDistritos = new System.Windows.Forms.ComboBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.ddgClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ddgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDistritos
            // 
            this.cbDistritos.BackColor = System.Drawing.SystemColors.Window;
            this.cbDistritos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDistritos.FormattingEnabled = true;
            this.cbDistritos.Location = new System.Drawing.Point(12, 15);
            this.cbDistritos.Name = "cbDistritos";
            this.cbDistritos.Size = new System.Drawing.Size(121, 21);
            this.cbDistritos.TabIndex = 0;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(194, 13);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 1;
            this.btnVer.Text = "Ver Clientes";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // ddgClientes
            // 
            this.ddgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ddgClientes.Location = new System.Drawing.Point(12, 54);
            this.ddgClientes.Name = "ddgClientes";
            this.ddgClientes.Size = new System.Drawing.Size(592, 175);
            this.ddgClientes.TabIndex = 2;
            // 
            // Test1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 241);
            this.Controls.Add(this.ddgClientes);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.cbDistritos);
            this.Name = "Test1";
            this.Text = "Test1";
            this.Load += new System.EventHandler(this.Test1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ddgClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDistritos;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.DataGridView ddgClientes;
    }
}