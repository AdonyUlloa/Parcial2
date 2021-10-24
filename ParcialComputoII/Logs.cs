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
    public partial class Logs : Form
    {
        public Logs()
        {
            InitializeComponent();
        }

        private void Logs_Load(object sender, EventArgs e)
        {
            fillDataGridView();
        }

        public void fillDataGridView()
        {
            Clases.Account account = new Clases.Account();

            clearDataGridView();

            dtgLogs.Columns.Add("codLog", "N° Registro");
            dtgLogs.Columns.Add("username", "Usuario");
            dtgLogs.Columns.Add("timeLoggedin", "Hora de inicio de sesión");

            MySqlDataReader dataReader = account.getAllLogs();
            while (dataReader.Read())
            {
                dtgLogs.Rows.Add(
                    dataReader.GetValue(0),
                    dataReader.GetValue(1),
                    dataReader.GetValue(2)
                    );
            }
        }

        public void clearDataGridView()
        {
            dtgLogs.Columns.Clear();
            dtgLogs.Rows.Clear();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void rjToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        
    }
}
