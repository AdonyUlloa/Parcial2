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
    
    public partial class Profile : Form
    {
        Clases.Account account = new Clases.Account();

        public Profile()
        {
            InitializeComponent();
        }

        public void Profile_Load(object sender, EventArgs e)
        {

            fillDataGridView();
            /*Login login = new Login()*/;

            label1.Text = dtgPerfil.CurrentRow.Cells[5].Value.ToString();
            label2.Text = dtgPerfil.CurrentRow.Cells[3].Value.ToString();
            label3.Text = dtgPerfil.CurrentRow.Cells[4].Value.ToString();




        }

        public void fillDataGridView()
        {
            Clases.Account account = new Clases.Account();

            clearDataGridView();

            dtgPerfil.Columns.Add("codUser", "N° Registro");
            dtgPerfil.Columns.Add("firstname", "NOMBRE");
            dtgPerfil.Columns.Add("lastname", "APELLIDO");
            dtgPerfil.Columns.Add("email", "EMAIL");
            dtgPerfil.Columns.Add("registerDate", "FECHA REGISTRO");
            dtgPerfil.Columns.Add("username", "USUARIO");

            MySqlDataReader dataReader = account.getAllUsers();

            while (dataReader.Read())
            {
                dtgPerfil.Rows.Add(
                    dataReader.GetValue(0),
                    dataReader.GetValue(1),
                    dataReader.GetValue(2),
                    dataReader.GetValue(3),
                    dataReader.GetValue(4),
                    dataReader.GetValue(5)
                    );
                dtgPerfil.Visible = false;
            }

        }
        public void clearDataGridView()
        {
            dtgPerfil.Columns.Clear();
            dtgPerfil.Rows.Clear();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
