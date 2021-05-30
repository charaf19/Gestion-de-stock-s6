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
    public partial class FRM_Connexion : Form
    {
        public FRM_Connexion()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(txtNom.Text == "Nom d'Utilisateur")
            {
                txtNom.Text = "";
                txtNom.ForeColor = Color.LightGray;

            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtNom.Text == "")
            {
                txtNom.Text = "Nom d'Utilisateur";
                txtNom.ForeColor = Color.DimGray;

            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (txtMotdepasse.Text == "Mot de passe")
            {
                txtMotdepasse.Text = "";
                txtMotdepasse.ForeColor = Color.LightGray;
                txtMotdepasse.UseSystemPasswordChar = true;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (txtMotdepasse.Text == "")
            {
                txtMotdepasse.Text = "Mot de passe";
                txtMotdepasse.ForeColor = Color.DimGray;
                txtMotdepasse.UseSystemPasswordChar = false;
            }
        }

        private void txtMotdepasse_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
