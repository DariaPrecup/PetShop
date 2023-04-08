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

namespace PetShop
{
    public partial class FrmStergere : Form
    {
        public FrmStergere()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString= @"SERVER=localhost; DATABASE=petshop; 
                                               UID=root; PASSWORD=; Allow User Variables=True";
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = @"DELETE FROM clienti WHERE CNP=@pCNP";
                cmd.Parameters.AddWithValue("pCNP", txtCNP.Text);

                if (cmd.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("Contul a fost sters cu succes!");
                    txtCNP.Text="";
                    txtNume.Text="";
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error!");
            }
        }
    }
}
