﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Gestion_de_stock_s6.PL
{
    public partial class FRM_Menus : Form
    {
        public FRM_Menus()
        {
            InitializeComponent();
            panel1.Size = new Size(186, 450);
            pnlParamettrer.Visible = false;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if(panel1.Size == new Size(186, 450))
            {
                panel1.Size = new Size(58, 450);
            }
            else
            {
                panel1.Size = new Size(186, 450);
            }
        }

        private void btnproduit_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnproduit.Top;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnclient.Top;
        }

        private void btncategorie_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btncategorie.Top;
        }

        private void btncommande_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btncommande.Top;
        }

        private void btnutilisateur_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnutilisateur.Top;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
          if(  pnlParamettrer.Visible == true)
            {
                pnlParamettrer.Visible = false;
            }
            else
            {
                pnlParamettrer.Visible = true;
            }

        }


        private void button5_Click(object sender, EventArgs e)
        {
            //afficher le formulaire de connexion
            FRM_Connexion frmC = new FRM_Connexion();
            frmC.ShowDialog();
        }
    }
}
