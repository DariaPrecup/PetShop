namespace PetShop
{
    partial class FrmClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClient));
            this.label1 = new System.Windows.Forms.Label();
            this.cboCategorie = new System.Windows.Forms.ComboBox();
            this.lstProduse = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPret = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdaugaCos = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.lblCantitate = new System.Windows.Forms.TextBox();
            this.pnlCos = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnComanda = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.PictureBox();
            this.lstCos = new System.Windows.Forms.ListBox();
            this.pnlComanda = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCos = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.pnlCNP = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCNP = new System.Windows.Forms.TextBox();
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.pnlCos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUndo)).BeginInit();
            this.pnlComanda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.pnlCNP.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(31, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "Astazi doresc sa cumpar produse pentru:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboCategorie
            // 
            this.cboCategorie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(222)))));
            this.cboCategorie.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategorie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(100)))));
            this.cboCategorie.FormattingEnabled = true;
            this.cboCategorie.ItemHeight = 43;
            this.cboCategorie.Location = new System.Drawing.Point(392, 4);
            this.cboCategorie.Margin = new System.Windows.Forms.Padding(0);
            this.cboCategorie.Name = "cboCategorie";
            this.cboCategorie.Size = new System.Drawing.Size(149, 51);
            this.cboCategorie.TabIndex = 11;
            this.cboCategorie.SelectedIndexChanged += new System.EventHandler(this.cboCategorie_SelectedIndexChanged);
            // 
            // lstProduse
            // 
            this.lstProduse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(100)))));
            this.lstProduse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstProduse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(222)))));
            this.lstProduse.FormattingEnabled = true;
            this.lstProduse.ItemHeight = 43;
            this.lstProduse.Location = new System.Drawing.Point(39, 84);
            this.lstProduse.Margin = new System.Windows.Forms.Padding(0);
            this.lstProduse.MaximumSize = new System.Drawing.Size(200, 200);
            this.lstProduse.MinimumSize = new System.Drawing.Size(184, 130);
            this.lstProduse.Name = "lstProduse";
            this.lstProduse.Size = new System.Drawing.Size(184, 172);
            this.lstProduse.TabIndex = 12;
            this.lstProduse.SelectedIndexChanged += new System.EventHandler(this.lstProduse_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(31, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 40);
            this.label2.TabIndex = 13;
            this.label2.Text = "Produsele disponibile:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(31, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 40);
            this.label3.TabIndex = 14;
            this.label3.Text = "Pret:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPret
            // 
            this.lblPret.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(100)))));
            this.lblPret.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(222)))));
            this.lblPret.Location = new System.Drawing.Point(84, 256);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(139, 40);
            this.lblPret.TabIndex = 15;
            this.lblPret.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(100)))));
            this.label4.Location = new System.Drawing.Point(31, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 40);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cantitate:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdaugaCos
            // 
            this.btnAdaugaCos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdaugaCos.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaCos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(100)))));
            this.btnAdaugaCos.Location = new System.Drawing.Point(39, 339);
            this.btnAdaugaCos.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdaugaCos.Name = "btnAdaugaCos";
            this.btnAdaugaCos.Size = new System.Drawing.Size(184, 41);
            this.btnAdaugaCos.TabIndex = 18;
            this.btnAdaugaCos.Text = "Adauga in cos";
            this.btnAdaugaCos.UseVisualStyleBackColor = false;
            this.btnAdaugaCos.Click += new System.EventHandler(this.btnAdaugaCos_Click);
            // 
            // lblText
            // 
            this.lblText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblText.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.lblText.Location = new System.Drawing.Point(9, 396);
            this.lblText.Margin = new System.Windows.Forms.Padding(0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(289, 97);
            this.lblText.TabIndex = 19;
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCantitate
            // 
            this.lblCantitate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(100)))));
            this.lblCantitate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCantitate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(222)))));
            this.lblCantitate.Location = new System.Drawing.Point(123, 292);
            this.lblCantitate.Name = "lblCantitate";
            this.lblCantitate.Size = new System.Drawing.Size(100, 44);
            this.lblCantitate.TabIndex = 20;
            this.lblCantitate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlCos
            // 
            this.pnlCos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.pnlCos.Controls.Add(this.lblTotal);
            this.pnlCos.Controls.Add(this.label5);
            this.pnlCos.Controls.Add(this.btnComanda);
            this.pnlCos.Controls.Add(this.btnStergere);
            this.pnlCos.Controls.Add(this.btnUndo);
            this.pnlCos.Controls.Add(this.lstCos);
            this.pnlCos.Location = new System.Drawing.Point(0, 0);
            this.pnlCos.Name = "pnlCos";
            this.pnlCos.Size = new System.Drawing.Size(800, 500);
            this.pnlCos.TabIndex = 22;
            this.pnlCos.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(222)))));
            this.lblTotal.Location = new System.Drawing.Point(682, 359);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 43);
            this.lblTotal.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(222)))));
            this.label5.Location = new System.Drawing.Point(618, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 43);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total:";
            // 
            // btnComanda
            // 
            this.btnComanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComanda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(222)))));
            this.btnComanda.Location = new System.Drawing.Point(615, 405);
            this.btnComanda.Name = "btnComanda";
            this.btnComanda.Size = new System.Drawing.Size(151, 40);
            this.btnComanda.TabIndex = 10;
            this.btnComanda.Text = "Comanda";
            this.btnComanda.UseVisualStyleBackColor = true;
            this.btnComanda.Click += new System.EventHandler(this.btnComanda_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStergere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(222)))));
            this.btnStergere.Location = new System.Drawing.Point(615, 451);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(151, 40);
            this.btnStergere.TabIndex = 9;
            this.btnStergere.Text = "Sterge produs";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.BackgroundImage = global::PetShop.Properties.Resources.undo;
            this.btnUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUndo.Location = new System.Drawing.Point(753, 2);
            this.btnUndo.Margin = new System.Windows.Forms.Padding(0);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(49, 36);
            this.btnUndo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnUndo.TabIndex = 8;
            this.btnUndo.TabStop = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // lstCos
            // 
            this.lstCos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.lstCos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstCos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(222)))));
            this.lstCos.FormattingEnabled = true;
            this.lstCos.ItemHeight = 43;
            this.lstCos.Location = new System.Drawing.Point(3, 0);
            this.lstCos.Margin = new System.Windows.Forms.Padding(0);
            this.lstCos.Name = "lstCos";
            this.lstCos.Size = new System.Drawing.Size(750, 344);
            this.lstCos.TabIndex = 0;
            // 
            // pnlComanda
            // 
            this.pnlComanda.Controls.Add(this.pictureBox1);
            this.pnlComanda.Controls.Add(this.label1);
            this.pnlComanda.Controls.Add(this.cboCategorie);
            this.pnlComanda.Controls.Add(this.lblText);
            this.pnlComanda.Controls.Add(this.lblCantitate);
            this.pnlComanda.Controls.Add(this.btnAdaugaCos);
            this.pnlComanda.Controls.Add(this.label2);
            this.pnlComanda.Controls.Add(this.lstProduse);
            this.pnlComanda.Controls.Add(this.lblPret);
            this.pnlComanda.Controls.Add(this.label4);
            this.pnlComanda.Controls.Add(this.label3);
            this.pnlComanda.Location = new System.Drawing.Point(0, -2);
            this.pnlComanda.Name = "pnlComanda";
            this.pnlComanda.Size = new System.Drawing.Size(545, 502);
            this.pnlComanda.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PetShop.Properties.Resources.shopping_64px2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 23);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnCos
            // 
            this.btnCos.BackgroundImage = global::PetShop.Properties.Resources.cart;
            this.btnCos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCos.Location = new System.Drawing.Point(696, -2);
            this.btnCos.Margin = new System.Windows.Forms.Padding(0);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(53, 47);
            this.btnCos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCos.TabIndex = 21;
            this.btnCos.TabStop = false;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::PetShop.Properties.Resources.exit2;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(749, -2);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(53, 47);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 8;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlCNP
            // 
            this.pnlCNP.Controls.Add(this.btnConfirmare);
            this.pnlCNP.Controls.Add(this.txtCNP);
            this.pnlCNP.Controls.Add(this.label6);
            this.pnlCNP.Location = new System.Drawing.Point(300, 100);
            this.pnlCNP.Name = "pnlCNP";
            this.pnlCNP.Size = new System.Drawing.Size(200, 237);
            this.pnlCNP.TabIndex = 24;
            this.pnlCNP.Visible = false;
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(100)))));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 40);
            this.label6.TabIndex = 17;
            this.label6.Text = "Confirma CNP-ul:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCNP
            // 
            this.txtCNP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(100)))));
            this.txtCNP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCNP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(222)))));
            this.txtCNP.Location = new System.Drawing.Point(0, 46);
            this.txtCNP.Name = "txtCNP";
            this.txtCNP.Size = new System.Drawing.Size(200, 44);
            this.txtCNP.TabIndex = 21;
            this.txtCNP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmare.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(100)))));
            this.btnConfirmare.Location = new System.Drawing.Point(8, 98);
            this.btnConfirmare.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(184, 41);
            this.btnConfirmare.TabIndex = 22;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = false;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // FrmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 43F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.pnlCNP);
            this.Controls.Add(this.pnlComanda);
            this.Controls.Add(this.pnlCos);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(100)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.Name = "FrmClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.pnlCos.ResumeLayout(false);
            this.pnlCos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUndo)).EndInit();
            this.pnlComanda.ResumeLayout(false);
            this.pnlComanda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.pnlCNP.ResumeLayout(false);
            this.pnlCNP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboCategorie;
        private System.Windows.Forms.ListBox lstProduse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdaugaCos;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox lblCantitate;
        private System.Windows.Forms.PictureBox btnCos;
        private System.Windows.Forms.Panel pnlCos;
        private System.Windows.Forms.ListBox lstCos;
        private System.Windows.Forms.Panel pnlComanda;
        private System.Windows.Forms.PictureBox btnUndo;
        private System.Windows.Forms.Button btnComanda;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlCNP;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.TextBox txtCNP;
        private System.Windows.Forms.Label label6;
    }
}