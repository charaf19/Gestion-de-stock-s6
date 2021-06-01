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
    public partial class USER_Liste_Commandes : UserControl
    {
        private static USER_Liste_Commandes Usercom;
        //creer une instance pour le usercontrole
        private dbStockContext db;
        public static USER_Liste_Commandes Instance
        {
            get
            {
                if (Usercom == null)
                {
                    Usercom = new USER_Liste_Commandes();

                }
                return Usercom;
            }
        }
        public USER_Liste_Commandes()
        {
            InitializeComponent();
        }


    }
}
