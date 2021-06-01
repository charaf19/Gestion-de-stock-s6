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
        private dbStockContext db;

        private Form frmmenu;
        //class connexion
        BL.CLS_Connexion C = new BL.CLS_Connexion();
        public FRM_Connexion(Form Menu)
        {
            InitializeComponent();
            // initialiser la base de donnee
            db = new dbStockContext();
            this.frmmenu = Menu;

        }

        public FRM_Connexion()
        {
        }


        //pour verifier les champs obligatoir 
        string testobligatoire()
        {
            //si le nom d'utilisateur est vide
            if (txtNom.Text =="" || txtNom.Text == "Nom d'Utilisateur") {
                return "entrer un nom d'utilisateur valide";
            }
            //si l'utilisateur laisse le champ vide
            if (txtMotdepasse.Text == "" || txtMotdepasse.Text == "Mot de passe")
            {
                return "Le mot de passe que vous avez entré est incorrecte";
            }
            //si l'utilisateur a entré son nom et son mot de passe 
            return null;
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

        private void btnquitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnconnect_Click(object sender, EventArgs e)
        {
            if (testobligatoire()==null)
            {
                if (C.ConnexionValide(db,txtNom.Text,txtMotdepasse.Text)==true)//utilisateur existe dans la base de donnees
                {
                    this.Close();
                    (frmmenu as FRM_Menus).activerForm();
                }
                else//l'utilisateur n'existe pas on va ajouter un formulaire d'insription plutard
                {
                    MessageBox.Show("la Connexion a echoué", "Connexion", MessageBoxButtons.OK);
                }
            }
            else
            {

            }

            
        }
    }
}
