
namespace Gestion_de_stock_s6.PL
{
    partial class USER_Liste_Produit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnexcel = new System.Windows.Forms.Button();
            this.btnimprimertout = new System.Windows.Forms.Button();
            this.btnimprimerselection = new System.Windows.Forms.Button();
            this.btnaffichphotop = new System.Windows.Forms.Button();
            this.btnsuprimerp = new System.Windows.Forms.Button();
            this.btnmodifierp = new System.Windows.Forms.Button();
            this.btnajouterp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(126, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(524, 150);
            this.dataGridView1.TabIndex = 15;
            // 
            // column1
            // 
            this.column1.HeaderText = "Select";
            this.column1.Name = "column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "id";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantité";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Prix";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Categorie";
            this.Column5.Name = "Column5";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.DarkGray;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.comboBox2.Items.AddRange(new object[] {
            "Id",
            "Nom",
            "Quantité",
            "Prix",
            "Categorie"});
            this.comboBox2.Location = new System.Drawing.Point(84, 80);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(99, 28);
            this.comboBox2.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(189, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 1);
            this.panel2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox1.Location = new System.Drawing.Point(189, 80);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(368, 26);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "Rechercher";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(35, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 1);
            this.panel1.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Location = new System.Drawing.Point(35, 291);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(675, 1);
            this.panel3.TabIndex = 12;
            // 
            // btnexcel
            // 
            this.btnexcel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnexcel.FlatAppearance.BorderSize = 0;
            this.btnexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexcel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnexcel.Image = global::Gestion_de_stock_s6.Properties.Resources.excel;
            this.btnexcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexcel.Location = new System.Drawing.Point(515, 298);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(195, 44);
            this.btnexcel.TabIndex = 19;
            this.btnexcel.Text = "   Vers Excel";
            this.btnexcel.UseVisualStyleBackColor = false;
            // 
            // btnimprimertout
            // 
            this.btnimprimertout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnimprimertout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnimprimertout.FlatAppearance.BorderSize = 0;
            this.btnimprimertout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprimertout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimertout.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnimprimertout.Image = global::Gestion_de_stock_s6.Properties.Resources.exchange;
            this.btnimprimertout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnimprimertout.Location = new System.Drawing.Point(289, 298);
            this.btnimprimertout.Name = "btnimprimertout";
            this.btnimprimertout.Size = new System.Drawing.Size(201, 44);
            this.btnimprimertout.TabIndex = 18;
            this.btnimprimertout.Text = "   Imprimer tout";
            this.btnimprimertout.UseVisualStyleBackColor = false;
            // 
            // btnimprimerselection
            // 
            this.btnimprimerselection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnimprimerselection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnimprimerselection.FlatAppearance.BorderSize = 0;
            this.btnimprimerselection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprimerselection.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimerselection.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnimprimerselection.Image = global::Gestion_de_stock_s6.Properties.Resources.printer;
            this.btnimprimerselection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnimprimerselection.Location = new System.Drawing.Point(35, 298);
            this.btnimprimerselection.Name = "btnimprimerselection";
            this.btnimprimerselection.Size = new System.Drawing.Size(229, 44);
            this.btnimprimerselection.TabIndex = 17;
            this.btnimprimerselection.Text = "   Imprimer la selection";
            this.btnimprimerselection.UseVisualStyleBackColor = false;
            // 
            // btnaffichphotop
            // 
            this.btnaffichphotop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaffichphotop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnaffichphotop.FlatAppearance.BorderSize = 0;
            this.btnaffichphotop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaffichphotop.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaffichphotop.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnaffichphotop.Image = global::Gestion_de_stock_s6.Properties.Resources.picture;
            this.btnaffichphotop.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaffichphotop.Location = new System.Drawing.Point(503, 14);
            this.btnaffichphotop.Name = "btnaffichphotop";
            this.btnaffichphotop.Size = new System.Drawing.Size(207, 44);
            this.btnaffichphotop.TabIndex = 16;
            this.btnaffichphotop.Text = "Afficher la photo";
            this.btnaffichphotop.UseVisualStyleBackColor = false;
            // 
            // btnsuprimerp
            // 
            this.btnsuprimerp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnsuprimerp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnsuprimerp.FlatAppearance.BorderSize = 0;
            this.btnsuprimerp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsuprimerp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuprimerp.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnsuprimerp.Image = global::Gestion_de_stock_s6.Properties.Resources.delete;
            this.btnsuprimerp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsuprimerp.Location = new System.Drawing.Point(347, 14);
            this.btnsuprimerp.Name = "btnsuprimerp";
            this.btnsuprimerp.Size = new System.Drawing.Size(151, 44);
            this.btnsuprimerp.TabIndex = 10;
            this.btnsuprimerp.Text = "Supprimer";
            this.btnsuprimerp.UseVisualStyleBackColor = false;
            // 
            // btnmodifierp
            // 
            this.btnmodifierp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnmodifierp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnmodifierp.FlatAppearance.BorderSize = 0;
            this.btnmodifierp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodifierp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifierp.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnmodifierp.Image = global::Gestion_de_stock_s6.Properties.Resources.exchange;
            this.btnmodifierp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmodifierp.Location = new System.Drawing.Point(191, 14);
            this.btnmodifierp.Name = "btnmodifierp";
            this.btnmodifierp.Size = new System.Drawing.Size(151, 44);
            this.btnmodifierp.TabIndex = 9;
            this.btnmodifierp.Text = "Modifier";
            this.btnmodifierp.UseVisualStyleBackColor = false;
            // 
            // btnajouterp
            // 
            this.btnajouterp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnajouterp.FlatAppearance.BorderSize = 0;
            this.btnajouterp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnajouterp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouterp.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnajouterp.Image = global::Gestion_de_stock_s6.Properties.Resources.add;
            this.btnajouterp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnajouterp.Location = new System.Drawing.Point(35, 14);
            this.btnajouterp.Name = "btnajouterp";
            this.btnajouterp.Size = new System.Drawing.Size(151, 44);
            this.btnajouterp.TabIndex = 8;
            this.btnajouterp.Text = "Ajouter";
            this.btnajouterp.UseVisualStyleBackColor = false;
            // 
            // USER_Liste_Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.btnimprimertout);
            this.Controls.Add(this.btnimprimerselection);
            this.Controls.Add(this.btnaffichphotop);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnsuprimerp);
            this.Controls.Add(this.btnmodifierp);
            this.Controls.Add(this.btnajouterp);
            this.Name = "USER_Liste_Produit";
            this.Size = new System.Drawing.Size(739, 361);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsuprimerp;
        private System.Windows.Forms.Button btnmodifierp;
        private System.Windows.Forms.Button btnajouterp;
        private System.Windows.Forms.Button btnaffichphotop;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.Button btnimprimertout;
        private System.Windows.Forms.Button btnimprimerselection;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
