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

        private void FRM_Menu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ReleaseCapture()
        {
            throw new NotImplementedException();
        }

        private void SendMessage(IntPtr handle, int v1, int v2, int v3)
        {
            throw new NotImplementedException();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
