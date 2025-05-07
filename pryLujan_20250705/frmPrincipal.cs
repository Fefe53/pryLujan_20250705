using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLujan_20250705
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        clsClase x = new clsClase();
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbHeroes.Items.Add("Batman");
            cmbHeroes.Items.Add("Superman");
            cmbHeroes.Items.Add("Wonderwoman");

            
        }

        private void cmbHeroes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHeroes.SelectedIndex == 0)
            {
                pbHeroes.Image = Properties.Resources.Batman;
            }
            if (cmbHeroes.SelectedIndex == 1)
            {
                pbHeroes.Image = Properties.Resources.Superman;
            }
            if (cmbHeroes.SelectedIndex == 2)
            {
                pbHeroes.Image = Properties.Resources.Wonderwoman;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int Fuerza = (int)npdFuerza.Value;
            int Destreza = (int)npdDestreza.Value;

            // Texto que se escribirá en el archivo
            string contenido = $"Valor 1: {Fuerza}\nValor 2: {Destreza}";

            // Ruta del archivo (en el escritorio del usuario)
            string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "valores.txt");

            try
            {
                File.WriteAllText(ruta, contenido);
                MessageBox.Show("Archivo creado en el escritorio correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            npdFuerza.Minimum = 0;
            npdFuerza.Maximum = 10;
         
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            
            npdDestreza.Minimum = 0;
            npdDestreza.Maximum = 10;
        }
    }
}
