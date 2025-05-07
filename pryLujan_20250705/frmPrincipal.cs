using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
