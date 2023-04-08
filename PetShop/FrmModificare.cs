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
    public partial class FrmModificare : Form
    {
        public FrmModificare()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmModificare_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString= @"SERVER=localhost; DATABASE=petshop; 
                                               UID=root; PASSWORD=; Allow User Variables=True";
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM clienti";
                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    cboCont.Items.Add(r["idClient"] + ". " + r["Nume"] + ", " + r["Adresa"] + ", " + r["Telefon"]);
                }

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error!");
            }
        }

        private void cboCont_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString= @"SERVER=localhost; DATABASE=petshop; 
                                               UID=root; PASSWORD=; Allow User Variables=True";
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM clienti WHERE idClient LIKE @pidClient";
                string[] s = cboCont.SelectedItem.ToString().Split('.');
                cmd.Parameters.AddWithValue("pidClient", s[0]);
                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    txtNume.Text=r["Nume"].ToString();
                    txtAdresa.Text=r["Adresa"].ToString();
                    txtCNP.Text=r["CNP"].ToString();
                    txtEmail.Text=r["Email"].ToString();
                    txtTelefon.Text=r["Telefon"].ToString();
                }

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error!");
            }
        }

        private void btnModificare_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString= @"SERVER=localhost; DATABASE=petshop; 
                                               UID=root; PASSWORD=; Allow User Variables=True";
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = @"UPDATE clienti SET Nume=@pNume, Adresa=@pAdresa, CNP=@pCNP, Email=@pEmail, Telefon=@pTelefon WHERE idClient=@pidClient";
                cmd.Parameters.AddWithValue("pNume", txtNume.Text);
                cmd.Parameters.AddWithValue("pAdresa", txtAdresa.Text);
                cmd.Parameters.AddWithValue("pCNP", txtCNP.Text);
                cmd.Parameters.AddWithValue("pEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("pTelefon", txtTelefon.Text);
                string[] s=cboCont.SelectedIndex.ToString().Split('.');
                cmd.Parameters.AddWithValue("pidClient", s[0]);
                MySqlDataReader r = cmd.ExecuteReader();
                if (cmd.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("Contul a fost modificat cu succes!");
                    this.Close();
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
