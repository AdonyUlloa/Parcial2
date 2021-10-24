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

        string usuario;

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

        private void mlbVerPassword_Click(object sender, EventArgs e)
        {
            txtbPassword.PasswordChar.Equals(false);
        }

        private void txtbPassword_Click(object sender, EventArgs e)
        {
            if (cbPassword.Checked == true)
            {
                if (txtbPassword.PasswordChar == '*')
                {
                    txtbPassword.PasswordChar = '\0';
                }
            }
            else
            {
                txtbPassword.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Clases.Account account = new Clases.Account();
            account._username = txtbUsername.Text;
            account._password = txtbPassword.Text;

            if (account.Login() == true)
            {
                if (txtbUsername.Text == "ADMIN")
                {
                    account.insertLog();
                    MenuAdmin admin = new MenuAdmin();
                    admin.Show();
                    this.Hide();
                }
                else if (txtbUsername.Text != "ADMIN")
                {
                    account.insertLog();
                    MenuGeneral menuGeneral = new MenuGeneral();
                    menuGeneral.Show();
                    this.Hide();


                }
            }
            else if (account.Login() == false)
            {

            }
            else
            {

            }

        }

        public string Usuario()
        {
            usuario = txtbUsername.Text;

            return usuario;

        }

        

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
