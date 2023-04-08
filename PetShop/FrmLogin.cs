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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnContNou_Click(object sender, EventArgs e)
        {
            FrmContNou cont=new FrmContNou();
            cont.Show();
        }

        private void btnConectare_Click(object sender, EventArgs e)
        {
           
            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString= @"SERVER=localhost; DATABASE=petshop; 
                                               UID=root; PASSWORD=; Allow User Variables=True";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "Select distinct Nume,CNP from clienti";
                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                { 
                    
                   if(txtNume.Text==r["Nume"].ToString() && txtCNP.Text==r["CNP"].ToString())
                    {
                        FrmClient client= new FrmClient();
                        client.Show();
                        lblText.Text=" ";
                        txtNume.Text="";
                        txtCNP.Text="";
                    }
                   else
                    {
                        lblText.Text="Numele sau CNP-ul sunt incorecte";
                    }
                }
                
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error!");
            }

        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if(txtNume.Text=="Admin" && txtCNP.Text=="1234")
            {
                FrmAdmin admin=new FrmAdmin();
                admin.Show();
                lblText.Text=" ";
                txtCNP.Text="";
                txtNume.Text="";
            }
            else
            {
                lblText.Text="Numele sau CNP-ul sunt incorecte";
            }
        }

        private void txtCNP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                lblText.Text="Atentie, CNP-ul este alcatuit doar din cifre!";
            }
        }

        private void btnModificare_Click(object sender, EventArgs e)
        {
            FrmModificare frmModificare = new FrmModificare();
            frmModificare.Show();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            FrmStergere frmStergere = new FrmStergere();
            frmStergere.Show();
        }
    }
}
