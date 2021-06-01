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
    public partial class USER_Liste_Produit : UserControl
    {
        private static USER_Liste_Produit Userproduit;
        //creer une instance pour le usercontrole
        private dbStockContext db;
        public static USER_Liste_Produit Instance
        {
            get
            {
                if (Userproduit == null)
                {
                    Userproduit = new USER_Liste_Produit();

                }
                return Userproduit;
            }
        }
        public USER_Liste_Produit()
        {
            InitializeComponent();
            db = new dbStockContext();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Rechercher")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.LightGray;

            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Rechercher";
                textBox1.ForeColor = Color.DimGray;

            }
        }
    }
}
