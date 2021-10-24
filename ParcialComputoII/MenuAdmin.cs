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
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {

            InitializeComponent();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this,
                  "Bienvenido Admin", "SESIÓN INICIADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tileRegistros_Click(object sender, EventArgs e)
        {
            Logs logs = new Logs();
            logs.Show();
        }

        private void tileUsuarios_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();
        }

        private void tilePerfil_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
        }

        private void tileTrabajos_Click(object sender, EventArgs e)
        {
            Trabajos trabajos = new Trabajos();
            trabajos.Show();
        }

        private void tilePerfil_Click_1(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
        }
    }

    
}
