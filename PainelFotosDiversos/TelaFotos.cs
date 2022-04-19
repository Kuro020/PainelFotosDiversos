using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PainelFotosDiversos
{
    public partial class TelaFotos : Form
    {
        public TelaFotos()
        {
            InitializeComponent();
        }

        private void btnFoto1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Arquivos png|*.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbxFoto1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnFoto2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Arquivos png|*.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbxFoto2.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnFoto3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Arquivos png|*.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbxFoto3.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void pbxFoto3_Click(object sender, EventArgs e)
        {

        }
    }
}
