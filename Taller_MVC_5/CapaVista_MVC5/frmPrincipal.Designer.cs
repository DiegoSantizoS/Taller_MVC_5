namespace CapaVista_MVC5
{
    partial class frmPrincipal
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
            this.btnConsultarCiudad = new System.Windows.Forms.Button();
            this.DgvConsultarCiudad = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsultarCiudad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultarCiudad
            // 
            this.btnConsultarCiudad.Location = new System.Drawing.Point(152, 23);
            this.btnConsultarCiudad.Name = "btnConsultarCiudad";
            this.btnConsultarCiudad.Size = new System.Drawing.Size(278, 92);
            this.btnConsultarCiudad.TabIndex = 0;
            this.btnConsultarCiudad.Text = "Consultar Ciudad";
            this.btnConsultarCiudad.UseVisualStyleBackColor = true;
            this.btnConsultarCiudad.Click += new System.EventHandler(this.btnConsultarCiudad_Click);
            // 
            // DgvConsultarCiudad
            // 
            this.DgvConsultarCiudad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvConsultarCiudad.Location = new System.Drawing.Point(53, 147);
            this.DgvConsultarCiudad.Name = "DgvConsultarCiudad";
            this.DgvConsultarCiudad.RowHeadersWidth = 51;
            this.DgvConsultarCiudad.RowTemplate.Height = 24;
            this.DgvConsultarCiudad.Size = new System.Drawing.Size(691, 257);
            this.DgvConsultarCiudad.TabIndex = 1;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgvConsultarCiudad);
            this.Controls.Add(this.btnConsultarCiudad);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsultarCiudad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultarCiudad;
        private System.Windows.Forms.DataGridView DgvConsultarCiudad;
    }
}