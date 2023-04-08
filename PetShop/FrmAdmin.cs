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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void btnProduse_Click(object sender, EventArgs e)
        {

            pnlAdaugare.Visible = false;
            pnlClienti.Visible = false;
            pnlComenzi.Visible = false;
            pnlModificare.Visible = false;
            pnlProduse.Visible = true;
            pnlAdmin.Visible = false;
            cboCategorie.Items.Clear();
            lstProduse.Items.Clear();
            lblStergere.Text="Alege produsul pe care doresti sa il vizualizezi";
            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString= @"SERVER=localhost; DATABASE=petshop; 
                                               UID=root; PASSWORD=; Allow User Variables=True";
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT DISTINCT Categorie FROM produse";
                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    cboCategorie.Items.Add(r["Categorie"]);
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error!");
            }

        }

        private void cboCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstProduse.Items.Clear();
            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString= @"SERVER=localhost; DATABASE=petshop; 
                                               UID=root; PASSWORD=; Allow User Variables=True";
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM produse WHERE true AND Categorie LIKE @pcategorie";
                cmd.Parameters.AddWithValue("pcategorie", cboCategorie.SelectedItem.ToString());
                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    lstProduse.Items.Add(r["idProdus"] + "." + r["Denumire"] + " - " + r["Cantitate"] + " bucati - " + r["Pret"] + " ron");  //r["coloana"]

                }

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString= @"SERVER=localhost; DATABASE=petshop; 
                                               UID=root; PASSWORD=; Allow User Variables=True";
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = @"DELETE FROM produse WHERE idProdus=@pidProdus";
                string[] s = lstProduse.SelectedItem.ToString().Split('.');
                cmd.Parameters.AddWithValue("pidProdus", s[0]);

                if (cmd.ExecuteNonQuery() != 0)
                {
                    lblStergere.Text="Produsul a fost sters cu succes!";
                    lstProduse.Items.Remove(lstProduse.SelectedItem);
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
            pnlAdaugare.Visible = false;
            pnlClienti.Visible = false;
            pnlComenzi.Visible = false;
            pnlModificare.Visible = true;
            pnlProduse.Visible = false;
            pnlAdmin.Visible = false;
            txtCantitate.Text="";
            txtCategorie.Text="";
            txtDenumire.Text="";
            txtPret.Text="";
            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString= @"SERVER=localhost; DATABASE=petshop; 
                                               UID=root; PASSWORD=; Allow User Variables=True";
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM produse ";
                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    cboProdus.Items.Add(r["idProdus"] + ". " + r["Categorie"] + ", " + r["Denumire"]);
                }

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error!");
            }


        }

        private void btnConfirmareModificare_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString= @"SERVER=localhost; DATABASE=petshop; 
                                               UID=root; PASSWORD=; Allow User Variables=True";
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = @"UPDATE produse SET Denumire=@pDenumire , Categorie=@pCategorie , Pret=@pPret , Cantitate=@pCantitate WHERE idProdus=@pidProdus ";
                cmd.Parameters.AddWithValue("pDenumire", txtDenumire.Text);
                cmd.Parameters.AddWithValue("pCategorie", txtCategorie.Text);
                cmd.Parameters.AddWithValue("pPret", txtPret.Text);
                cmd.Parameters.AddWithValue("pCantitate", txtCantitate.Text);
                string[] s = cboProdus.SelectedIndex.ToString().Split('.');
                cmd.Parameters.AddWithValue("pidProdus", s[0]);
                MySqlDataReader r = cmd.ExecuteReader();
                if (cmd.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("Produsul a fost modificat cu succes!");
                    btnModificare.PerformClick();
                }

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error!");
            }

        }

        private void btnConfirmareAdaugare_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = @"SERVER=localhost; DATABASE=petshop; 
                                               UID=root; PASSWORD=; Allow User Variables=True";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = @"INSERT INTO produse(Categorie, Denumire, Cantitate, Pret)
                                                 VALUES(@pCategorie,@pDenumire,@pCantitate,@pPret);";

                cmd.Parameters.AddWithValue("pCategorie", txtCategorieAdaugata.Text);
                cmd.Parameters.AddWithValue("pDenumire", txtDenumireAdaugata.Text);
                cmd.Parameters.AddWithValue("pCantitate", txtCantitateAdaugata.Text);
                cmd.Parameters.AddWithValue("pPret", txtPretAdaugat.Text);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    lblAdaugare.Text="Produsul a fost adaugat cu succes!";
                }
                else
                {
                    MessageBox.Show("Datele nu au fost adaugate!", "Baze de date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error!");
            }
        }

            private void FrmAdmin_Load(object sender, EventArgs e)
            {
                pnlAdaugare.Visible = false;
                pnlClienti.Visible = false;
                pnlComenzi.Visible = false;
                pnlModificare.Visible = false;
                pnlProduse.Visible = false;
                pnlAdmin.Visible = true;
            }

            private void btnAdaugare_Click(object sender, EventArgs e)
            {
                pnlAdaugare.Visible = true;
                pnlClienti.Visible = false;
                pnlComenzi.Visible = false;
                pnlModificare.Visible = false;
                pnlProduse.Visible = false;
                pnlAdmin.Visible = false;

            }

            private void btnClienti_Click(object sender, EventArgs e)
            {
                pnlAdaugare.Visible = false;
                pnlClienti.Visible = true;
                pnlComenzi.Visible = false;
                pnlModificare.Visible = false;
                pnlProduse.Visible = false;
                pnlAdmin.Visible = false;
                lstClienti.Items.Clear();
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
                        cboClienti.Items.Add(r["idClient"] + ". " + r["Nume"]);
                    }

                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error!");
                }

            }

            private void btnComenzi_Click(object sender, EventArgs e)
            {
                pnlAdaugare.Visible = false;
                pnlClienti.Visible = false;
                pnlComenzi.Visible = true;
                pnlModificare.Visible = false;
                pnlProduse.Visible = false;
                pnlAdmin.Visible = false;
                try
                {
                    MySqlConnection connection = new MySqlConnection();
                    connection.ConnectionString= @"SERVER=localhost; DATABASE=petshop; 
                                               UID=root; PASSWORD=; Allow User Variables=True";
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM comenzi, clienti WHERE comenzi.CNP=clienti.CNP";
                    MySqlDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        cboComenzi.Items.Add(r["Numar"] + ". " + r["Nume"]);
                    }

                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error!");
                }
            }

            private void btnTrimitere_Click(object sender, EventArgs e)
            {
                try
                {
                    MySqlConnection connection = new MySqlConnection();
                    connection.ConnectionString= @"SERVER=localhost; DATABASE=petshop; 
                                               UID=root; PASSWORD=; Allow User Variables=True";
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = @"DELETE FROM produse WHERE Numar=@pNumar";
                    cmd.Parameters.AddWithValue("pNumar", cboComenzi.SelectedItem.ToString().Split('.'));

                    if (cmd.ExecuteNonQuery() != 0)
                    {
                        lblComenzi.Text="Comanda a fost trimisa cu succes!";
                        lstProduse.Items.Remove(lstProduse.SelectedItem);
                        btnProduse.PerformClick();
                    }
                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error!");
                }
            }

            private void cboComenzi_SelectedIndexChanged(object sender, EventArgs e)
            {
            lstComenzi.Items.Clear();
                try
                {
                    MySqlConnection connection = new MySqlConnection();
                    connection.ConnectionString= @"SERVER=localhost; DATABASE=petshop; 
                                               UID=root; PASSWORD=; Allow User Variables=True";
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM comenzi, clienti WHERE comenzi.Numar=@pNumar";
                    string[] s = cboComenzi.SelectedItem.ToString().Split('.');
                    cmd.Parameters.AddWithValue("pNumar", s[0]);
                    MySqlDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        lstComenzi.Items.Add(r["Produse"] + ", total: " + r["Total"] + " ron");
                    }

                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error!");
                }
            }

            private void cboProdus_SelectedIndexChanged(object sender, EventArgs e)
            {
                try
                {
                    MySqlConnection connection = new MySqlConnection();
                    connection.ConnectionString= @"SERVER=localhost; DATABASE=petshop; 
                                               UID=root; PASSWORD=; Allow User Variables=True";
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM produse WHERE idProdus=@pidProdus ";
                    string[] s = cboProdus.SelectedItem.ToString().Split('.');
                    cmd.Parameters.AddWithValue("pidProdus", s[0]);
                    MySqlDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        txtCantitate.Text=r["Cantitate"].ToString();
                        txtCategorie.Text=r["Categorie"].ToString();
                        txtDenumire.Text=r["Denumire"].ToString();
                        txtPret.Text=r["Pret"].ToString();
                    }
                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error!");
                }
            }

            private void cboClienti_SelectedIndexChanged(object sender, EventArgs e)
            {
            lstComenzi.Items.Clear();
                try
                {
                    MySqlConnection connection = new MySqlConnection();
                    connection.ConnectionString= @"SERVER=localhost; DATABASE=petshop; 
                                               UID=root; PASSWORD=; Allow User Variables=True";
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM comenzi, clienti WHERE comenzi.CNP=clienti.CNP";
                    MySqlDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        lstClienti.Items.Add(r["Numar"] + ". " + r["Produse"] + " - " + r["Total"] + " ron");
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
