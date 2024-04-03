using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace desktop
{
    public partial class sett : Form
    {
        public sett()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            // расширенное окно для выбора цвета
            colorDialog1.FullOpen = true;
            // установка начального цвета для colorDialog
            colorDialog1.Color = Color.Black;
            colorDialog2.FullOpen = true;
            // установка начального цвета для colorDialog
            colorDialog2.Color = Color.Black;
            grap.Text = Properties.Settings.Default.grap_edit;
            browser.Text = Properties.Settings.Default.browser;
            Mse.Text = Properties.Settings.Default.Msett;
            Mspath.Text = Properties.Settings.Default.MstorePath;
            vsname.Text = Properties.Settings.Default.vspath;
            expname.Text = Properties.Settings.Default.explorer_path;
            permis.Value = Properties.Settings.Default.per_usr;
        }

        private void bootsettbtn_Click(object sender, EventArgs e)
        {
            bootsett.Visible = true;
            bootsettbtn.Visible = false;
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bootsett.Visible = false;
            bootsettbtn.Visible = true;
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            Form1 f1 = new Form1();
            f1.Grap_edi = grap.Text;
            f1.vsp = vsname.Text;
            f1.expe = expname.Text;
            f1.pusr = (int)permis.Value;
            f1.MSp = Mspath.Text;
            f1.MSetti = Mse.Text;
            f1.brow = browser.Text;
            Properties.Settings.Default.grap_edit = grap.Text;
            Properties.Settings.Default.browser = browser.Text;
            Properties.Settings.Default.Msett = Mse.Text;
            Properties.Settings.Default.MstorePath = Mspath.Text;
            Properties.Settings.Default.vspath = vsname.Text;
            Properties.Settings.Default.explorer_path = expname.Text;
            Properties.Settings.Default.per_usr = (int)permis.Value;
            Properties.Settings.Default.Save();
            Application.Restart();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            grap.Enabled = true;
            browser.Enabled = true;
            Mse.Enabled = true;
            Mspath.Enabled = true;
            vsname.Enabled = true;
            expname.Enabled = true;
            permis.Enabled = true;
            button3.Visible = false;
            button4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            grap.Enabled = false;
            browser.Enabled = false;
            Mse.Enabled = false;
            Mspath.Enabled = false;
            vsname.Enabled = false;
            expname.Enabled = false;
            permis.Enabled = false;
            button3.Visible = true;
            button4.Visible = false;
        }
    }
}
