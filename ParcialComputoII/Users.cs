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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            fillDataGridView();
        }

        public void fillDataGridView()
        {
            Clases.Account account = new Clases.Account();

            clearDataGridView();

            dtgUsuarios.Columns.Add("codUser", "N° Registro");
            dtgUsuarios.Columns.Add("firstname", "NOMBRE");
            dtgUsuarios.Columns.Add("lastname", "APELLIDO");
            dtgUsuarios.Columns.Add("email", "EMAIL");
            dtgUsuarios.Columns.Add("registerDate", "FECHA REGISTRO");
            dtgUsuarios.Columns.Add("username", "USUARIO");

            MySqlDataReader dataReader = account.getAllUsers();

            while (dataReader.Read())
            {
                dtgUsuarios.Rows.Add(
                    dataReader.GetValue(0),
                    dataReader.GetValue(1),
                    dataReader.GetValue(2),
                    dataReader.GetValue(3),
                    dataReader.GetValue(4),
                    dataReader.GetValue(5)
                    );
            }

        }
        public void clearDataGridView()
        {
            dtgUsuarios.Columns.Clear();
            dtgUsuarios.Rows.Clear();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       
    }
}
