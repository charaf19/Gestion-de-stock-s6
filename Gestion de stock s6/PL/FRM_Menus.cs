using System;
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
            
            pnlParamettrer.Visible = false;
            panel1.Size = new Size(58, 450);
        }
        //desactiver le formulaire 
        public void desactiverForm()
        {
            btncopie.Enabled = false;
            btnclient.Enabled = false;
            btnproduit.Enabled = false;
            btncommande.Enabled = false;
            btncategorie.Enabled = false;
            btnutilisateur.Enabled = false;
            btndeconnecter.Enabled = false;
            btnrestaurer.Enabled = false;
            pnlBut.Enabled = false;

            btnseconnecter.Enabled = true;
        }

        public void activerForm()
        {
            btncopie.Enabled = true;
            btnclient.Enabled = true;
            btnproduit.Enabled = true;
            btncommande.Enabled = true;
            btncategorie.Enabled = true;
            btnutilisateur.Enabled = true;
            btndeconnecter.Enabled = true;
            btnrestaurer.Enabled = true;
            pnlBut.Enabled = true;
            btnseconnecter.Enabled = false;
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
            if (!(panel4.Controls.Contains(USER_Liste_Produit.Instance)))
            {
                panel4.Controls.Add(USER_Liste_Produit.Instance);
                USER_Liste_Produit.Instance.Dock = DockStyle.Fill;
                USER_Liste_Produit.Instance.BringToFront();
            }
            else
            {
                USER_Liste_Produit.Instance.BringToFront();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnclient.Top;
            if (!panel4.Controls.Contains(USER_Liste_Clients.Instance))
            {
                panel4.Controls.Add(USER_Liste_Clients.Instance);
                USER_Liste_Clients.Instance.Dock = DockStyle.Fill;
                USER_Liste_Clients.Instance.BringToFront();
            }
            else
            {
                USER_Liste_Clients.Instance.BringToFront();

            }
        }

        private void btncategorie_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btncategorie.Top;
            if (!(panel4.Controls.Contains(USER_Liste_Categorie.Instance)))
            {
                panel4.Controls.Add(USER_Liste_Categorie.Instance);
                USER_Liste_Categorie.Instance.Dock = DockStyle.Fill;
                USER_Liste_Categorie.Instance.BringToFront();
            }
            else
            {
                USER_Liste_Categorie.Instance.BringToFront();

            }
        }

        private void btncommande_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btncommande.Top;
            if (!(panel4.Controls.Contains(USER_Liste_Commandes.Instance)))
            {
                panel4.Controls.Add(USER_Liste_Commandes.Instance);
                USER_Liste_Commandes.Instance.Dock = DockStyle.Fill;
                USER_Liste_Commandes.Instance.BringToFront();
            }
            else
            {
                USER_Liste_Commandes.Instance.BringToFront();

            }
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
            pnlParamettrer.Size = new Size(315, 199);
            pnlParamettrer.Visible = !pnlParamettrer.Visible;

        }


        private void button5_Click(object sender, EventArgs e)
        {
            //afficher le formulaire de connexion
            FRM_Connexion frmC = new FRM_Connexion(this);//this refers to FRM_menu
            frmC.ShowDialog();
            
        }

        private void FRM_Menus_Load(object sender, EventArgs e)
        {
            desactiverForm();
        }

        private void btndeconnecter_Click(object sender, EventArgs e)
        {
            desactiverForm();

        }
    }
}
