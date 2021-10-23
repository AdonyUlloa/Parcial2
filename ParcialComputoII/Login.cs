using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ParcialComputoII
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Está seguró que desea salir?";
            if (MetroFramework.MetroMessageBox.Show(this, mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void mlbSign_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //string connectionString = "";
            //MySqlConnection conn;

            //try
            //{
            //    connectionString = @"Server=localhost;Database=parcialii;Uid=root;Pwd=usbw;SSL Mode=None";
            //    conn = new MySqlConnection(connectionString);
            //    conn.Open();
            //    //MessageBox.Show("Se establecio conexión correctamente");
            //    MetroFramework.MetroMessageBox.Show(this, "conexion exitosa", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    conn.Close();
            //}
            //catch (Exception Ex)
            //{
            //    //MessageBox.Show(Ex.Message);
            //    MetroFramework.MetroMessageBox.Show(this, Ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

            //Logs logs = new Logs();
            //logs.Show();
            //Users users = new Users();
            //users.Show();

        }
    }
}
