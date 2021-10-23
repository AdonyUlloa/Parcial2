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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btnRegisterNow_Click(object sender, EventArgs e)
        {
            ValidacionTextBox();
            if (txtPasseword.Text != txtConfirmPassword.Text)
            {
                MetroFramework.MetroMessageBox.Show(this, "Contrasela no conincide", "New Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Clases.Account account = new Clases.Account();
                account._firstname = txtFistName.Text;
                account._lastname = txtLastName.Text;
                account._email = txtEmail.Text;
                account._registerdate = DateTime.Now.ToString("dd-MM-yyyy");
                account._username = txtUserName.Text;
                account._password = txtPasseword.Text;
                account.registerAccount();
                MetroFramework.MetroMessageBox.Show(this,
                    "Nuevo usuario registrado", "New Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        public void ValidacionTextBox()
        {
            if (txtFistName.Text == "")
            {
                txtFistName.Focus();
                txtFistName.BackColor = Color.Cyan;
                errorProvider1.SetError(txtFistName, "Nombre necesario");
            }
            else if (txtLastName.Text == "")
            {
                txtLastName.Focus();
                txtLastName.BackColor = Color.Cyan;
                errorProvider1.SetError(txtLastName, "Apellido necesario");
            }
            else if (txtEmail.Text == "")
            {
                txtEmail.Focus();
                txtEmail.BackColor = Color.Cyan;
                errorProvider1.SetError(txtEmail, "email necesario");
            }
            else if (txtUserName.Text == "")
            {
                txtUserName.Focus();
                txtUserName.BackColor = Color.Cyan;
                errorProvider1.SetError(txtUserName, "Nombre de usuario necesario");
            }
            else if (txtPasseword.Text == "")
            {
                txtPasseword.Focus();
                txtPasseword.BackColor = Color.Cyan;
                errorProvider1.SetError(txtPasseword, "contraseña necesaria");
            }
            else if (txtConfirmPassword.Text == "")
            {
                txtConfirmPassword.Focus();
                txtConfirmPassword.BackColor = Color.Cyan;
                errorProvider1.SetError(txtConfirmPassword, "confirmacion de la contraseña es necesaria");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Está seguró que desea salir?";
            if (MetroFramework.MetroMessageBox.Show(this, mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void mlbSignIn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        
    }
}
