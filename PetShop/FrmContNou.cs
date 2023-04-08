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
    public partial class FrmContNou : Form
    {
        public FrmContNou()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnContNou_Click(object sender, EventArgs e)
        {
            if(IsValidEmail(txtEmail.Text)==false)
            {
                lblText.Text ="Atentie, e-mail-ul este invalid!";
            }
            else
            {
                try
                {
                    MySqlConnection connection = new MySqlConnection();
                    connection.ConnectionString = @"SERVER=localhost; DATABASE=petshop; 
                                               UID=root; PASSWORD=; Allow User Variables=True";
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = @"INSERT INTO clienti(Nume, CNP, Adresa, Telefon, Email)
                                                 VALUES(@pNume,@pCNP,@pAdresa,@pTelefon,@pEmail);";
                    cmd.Parameters.AddWithValue("pNume", txtNume.Text);
                    cmd.Parameters.AddWithValue("pCNP", txtCNP.Text);
                    cmd.Parameters.AddWithValue("pAdresa", txtAdresa.Text);
                    cmd.Parameters.AddWithValue("pTelefon", txtTelefon.Text);
                    cmd.Parameters.AddWithValue("pEmail", txtEmail.Text);
                    if (cmd.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("Datele au fost adaugate!", "Baze de date",
                                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Datele nu au fost adaugate!", "Baze de date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error!", "Baze de date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
        bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        private void txtCNP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                lblText.Text="Atentie, CNP-ul este alcatuit doar din cifre!";
            }
        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                lblText.Text="Atentie, numarul de telefon este alcatuit doar din cifre!";
            }
        }
    }
}
