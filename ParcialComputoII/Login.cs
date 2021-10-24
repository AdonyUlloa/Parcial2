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
                    MetroFramework.MetroMessageBox.Show(this,
                 "Bienvenido "+ txtbUsername.Text , "SESIÓN INICIADA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    account.insertLog();
                    MenuGeneral menuGeneral = new MenuGeneral();
                    menuGeneral.Show();  
                    this.Hide();
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Contraseña_usuario no son correctos o no está registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this,
                  "UGB", "BIENVENIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
