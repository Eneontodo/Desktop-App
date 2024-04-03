using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace desktop
{

    
    public partial class movedel : Form
    {
        public string outpath;
        public string inpath;
        public string outname;
        public string inname;
        public movedel()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                outpath = openFileDialog1.FileName;
                outname = openFileDialog1.Title;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                outpath = openFileDialog1.FileName;
                outname = openFileDialog1.Title;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                inpath = saveFileDialog1.FileName;
                inname = saveFileDialog1.Title;
                File.Copy(@outpath, @inpath);
                this.Close();
            }
        }
    }
}
