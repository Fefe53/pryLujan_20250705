namespace pryLujan_20250705
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
            this.cmbHeroes = new System.Windows.Forms.ComboBox();
            this.pbHeroes = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeroes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SUPERHEROES";
            // 
            // cmbHeroes
            // 
            this.cmbHeroes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHeroes.FormattingEnabled = true;
            this.cmbHeroes.Location = new System.Drawing.Point(185, 54);
            this.cmbHeroes.Name = "cmbHeroes";
            this.cmbHeroes.Size = new System.Drawing.Size(308, 21);
            this.cmbHeroes.TabIndex = 1;
            this.cmbHeroes.SelectedIndexChanged += new System.EventHandler(this.cmbHeroes_SelectedIndexChanged);
            // 
            // pbHeroes
            // 
            this.pbHeroes.Location = new System.Drawing.Point(56, 107);
            this.pbHeroes.Name = "pbHeroes";
            this.pbHeroes.Size = new System.Drawing.Size(483, 303);
            this.pbHeroes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHeroes.TabIndex = 2;
            this.pbHeroes.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 450);
            this.Controls.Add(this.pbHeroes);
            this.Controls.Add(this.cmbHeroes);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHeroes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbHeroes;
        private System.Windows.Forms.PictureBox pbHeroes;
    }
}

