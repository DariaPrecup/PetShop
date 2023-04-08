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
    public partial class FrmClient : Form
    {
        public FrmClient()
        {
            InitializeComponent();
        }
        int[] v= new int[100];
        int nr = 1;
        int total=0;
        int pret = 0;
        int cantitate = 0;
        string index, produse="" ;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void Client_Load(object sender, EventArgs e)
        {
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
                     lstProduse.Items.Add(r["Denumire"]);
                }
                
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error!");
            }
        }

        private void lstProduse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString= @"SERVER=localhost; DATABASE=petshop; 
                                               UID=root; PASSWORD=; Allow User Variables=True";
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT Pret FROM produse WHERE true AND Denumire LIKE @pdenumire";
                cmd.Parameters.AddWithValue("pdenumire", lstProduse.SelectedItem.ToString());
                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read()) 
                {
                    lblPret.Text=r["Pret"].ToString() + " ron";
                }

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error!");
            }
        }
       

        private void btnAdaugaCos_Click(object sender, EventArgs e)
        {
            int ok = 0;
            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString= @"SERVER=localhost; DATABASE=petshop; 
                                               UID=root; PASSWORD=; Allow User Variables=True";
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM produse WHERE Denumire LIKE @pdenumire";
                cmd.Parameters.AddWithValue("pdenumire", lstProduse.SelectedItem.ToString());
                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read()) 
                {
                    if (Convert.ToInt16(r["Cantitate"].ToString())<Convert.ToInt16(lblCantitate.Text))
                    {
                        lblText.Text="Ne pare rau, din pacate cantitatea selectata nu este disponibila.";
                        ok=1;
                    }
                }
                if(ok==0)
                {
                    lstCos.Items.Add(nr.ToString() + ". " + lstProduse.SelectedItem + " - " + lblPret.Text + " X " + lblCantitate.Text + " bucati");
                    string[] s=lblPret.Text.Split(' ');
                    pret=Convert.ToInt16(s[0]);
                    cantitate=Convert.ToInt16(lblCantitate.Text);    
                    total=total+(pret*cantitate);
                    produse=produse+(lstProduse.SelectedItem)+", ";
                    lblText.Text="Produsul a fost adaugat in cos!";
                    v[nr]=pret*cantitate;
                    nr++;
                }

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error!");
            }
        }
       

        private void btnCos_Click(object sender, EventArgs e)
        {
            pnlCos.Visible=true;
            pnlComanda.Visible=false;
            lblTotal.Text=total.ToString();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            pnlCos.Visible = false;
            pnlComanda.Visible = true;
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            int x= lstCos.SelectedIndex;
            string[] s=lstCos.SelectedItem.ToString().Split('.');
            int y=Convert.ToInt32(s[0]);
            lstCos.Items.Remove(lstCos.SelectedItem);
            total=total-v[y];
            lblTotal.Text= total.ToString();    

        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            
            pnlCNP.Visible=true;
            pnlComanda.Visible=false;
            pnlCos.Visible=false;
        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = @"SERVER=localhost; DATABASE=petshop; 
                                               UID=root; PASSWORD=; Allow User Variables=True";
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = @"INSERT INTO comenzi(Produse, CNP, Total)
                                                 VALUES(@pProduse,@pCNP,@pTotal);";
                cmd.Parameters.AddWithValue("pProduse", produse);
                cmd.Parameters.AddWithValue("pCNP", txtCNP.Text);
                cmd.Parameters.AddWithValue("pTotal", lblTotal.Text);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("Comanda a fost plasata!");
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error!", "Baze de date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
