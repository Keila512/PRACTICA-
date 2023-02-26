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

namespace PRACTICA_STREAMRYW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt|*.txt";
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            
            StreamReader sr = new StreamReader(ofd.FileName);
            richTxtBox.Text = sr.ReadToEnd();
            sr.Close();

        }

        private void btnEscribr_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "txt|*.txt";
            if (sfd.ShowDialog() != DialogResult.OK) 
            {
                return; 
            }
            StreamWriter sw = new StreamWriter(sfd.FileName);
            sw.Write(richTxtBox.Text);
            sw.Close();

        }
    }
}
