using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialComputoII
{
    public partial class Trabajos : Form
    {
        public Trabajos()
        {
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/AdonyUlloa/CRUDBasico");
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/alfredo122e/ConexionBD.git");
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/DavidFer77/Patient-CRUD");
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Moises1Martinez/Practicasemana12.git");
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/DanCastSV/practica071021");
        }
    }
}
