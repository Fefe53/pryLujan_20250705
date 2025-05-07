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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.npdFuerza = new System.Windows.Forms.NumericUpDown();
            this.npdDestreza = new System.Windows.Forms.NumericUpDown();
            this.btnCrear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeroes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdFuerza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdDestreza)).BeginInit();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "FUERZA";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "DESTREZA";
            // 
            // npdFuerza
            // 
            this.npdFuerza.Location = new System.Drawing.Point(267, 444);
            this.npdFuerza.Name = "npdFuerza";
            this.npdFuerza.Size = new System.Drawing.Size(120, 20);
            this.npdFuerza.TabIndex = 5;
            this.npdFuerza.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // npdDestreza
            // 
            this.npdDestreza.Location = new System.Drawing.Point(267, 491);
            this.npdDestreza.Name = "npdDestreza";
            this.npdDestreza.Size = new System.Drawing.Size(120, 20);
            this.npdDestreza.TabIndex = 6;
            this.npdDestreza.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(394, 557);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(145, 35);
            this.btnCrear.TabIndex = 7;
            this.btnCrear.Text = "CREAR";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 620);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.npdDestreza);
            this.Controls.Add(this.npdFuerza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbHeroes);
            this.Controls.Add(this.cmbHeroes);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHeroes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdFuerza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdDestreza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbHeroes;
        private System.Windows.Forms.PictureBox pbHeroes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown npdFuerza;
        private System.Windows.Forms.NumericUpDown npdDestreza;
        private System.Windows.Forms.Button btnCrear;
    }
}

