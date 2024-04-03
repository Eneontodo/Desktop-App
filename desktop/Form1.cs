using desktop.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace desktop
{
    public partial class Form1 : Form
    {
        public string vsp;
        public string Themes;
        public string ToolBgg;
        public string expe;
        public int pusr;
        public string MSp;
        public string MSetti;
        public string brow;
        public string Grap_edi;
        public Color ToolBg;
        public Color Theme;
        public Form1()
        {
            InitializeComponent();
            
            Grap_edi = Properties.Settings.Default.grap_edit;
            brow = Properties.Settings.Default.browser;
            MSetti = Properties.Settings.Default.Msett;
            MSp = Properties.Settings.Default.MstorePath;
            vsp = Properties.Settings.Default.vspath;
            expe = Properties.Settings.Default.explorer_path;
            pusr = Properties.Settings.Default.per_usr;
            if (Properties.Settings.Default.per_usr == 1)
            {
                Xternu.Enabled = true;
            }
            else { Xternu.Enabled = false; }
            sett se = new sett();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toTrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
           WindowState = FormWindowState.Minimized;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipText = "desktop in trey";
            notifyIcon1.BalloonTipTitle = "desktop в трее";
            notifyIcon1.Text = "desktop";
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
            }
            else if (FormWindowState.Maximized == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void развернутьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Maximized;
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pain.Text == "Help")
            {
                listBox1.Items.Add("Move Args*");
                listBox1.Items.Add("Move-переместить файлы в папку");
                listBox1.Items.Add("Args* Delete - переместить файл в папку, а прошлый удалить;");

                listBox1.Items.Add("Clear Args*");
                listBox1.Items.Add("Clear - (по умолчанию)очищает список вывода и историю ввода");
                listBox1.Items.Add("Args* history - очищает исотрию ввода");
                listBox1.Items.Add("Args* input - очищает список вывода");
                HistoryBox.Items.Add(pain.Text);
            }

            else if (pain.Text == "move") { movefile mf = new movefile(); mf.Show(); HistoryBox.Items.Add(pain.Text); }
            else if (pain.Text == "clear history") { HistoryBox.Items.Clear(); }
            else if (pain.Text == "clear input") { listBox1.Items.Clear(); HistoryBox.Items.Add(pain.Text); }
            else if (pain.Text == "move Delete") { movedel md = new movedel(); md.Show(); HistoryBox.Items.Add(pain.Text); }
            else if (pain.Text == "clear") { HistoryBox.Items.Clear(); listBox1.Items.Clear(); }
            else if (pain.Text == "explorer") { HistoryBox.Items.Add(pain.Text); cmdll.Func.Cmd($"start {expe}"); }
            else if (pain.Text == "browser") { HistoryBox.Items.Add(pain.Text); cmdll.Func.Cmd($"start {brow}"); }
            else if (pain.Text == "graphic") { HistoryBox.Items.Add(pain.Text); cmdll.Func.Cmd($"start {Grap_edi}"); }
            else { listBox1.Items.Add($"{pain.Text} - такой функции нету"); HistoryBox.Items.Add(pain.Text); }
            pain.Text = "";
        }
        private void button2_Click(object sender, EventArgs e) {cmdll.Func.Cmd(MSetti);}
        

        private void button3_Click(object sender, EventArgs e){cmdll.Func.Cmd("shutdown /s /t 0");}

        private void start_MS_Click(object sender, EventArgs e){ cmdll.Func.run(MSp); }

        private void button4_Click(object sender, EventArgs e){ cmdll.Func.run(vsp); }

        private void button5_Click(object sender, EventArgs e){ cmdll.Func.run(brow); }

        private void button6_Click(object sender, EventArgs e){ cmdll.Func.run(Grap_edi);}

        private void button7_Click(object sender, EventArgs e){sett se = new sett();se.Show();se.bootsettbtn.Focus();}
    }
}
