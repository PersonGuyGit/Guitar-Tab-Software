using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guitar_Tab_Software
{
    public partial class MainForm : Form
    {

        FormSettings FS;

        private int tuningIndex;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnAddToSong_Click(object sender, EventArgs e)
        {
            string TxtFromString1 = textBox1.Text;
            string TxtFromString2 = textBox2.Text;
            string TxtFromString3 = textBox3.Text; 
            string TxtFromString4 = textBox4.Text; 
            string TxtFromString5 = textBox5.Text;
            string TxtFromString6 = textBox6.Text;
        }

        private void btnWriteSongToFile_Click(object sender, EventArgs e)
        {

        }

        private void btnPickATrack_Click(object sender, EventArgs e)
        {

        }
 
        public void changeTunings(List<string> TheTuningList)
        {
            lblString1.Text = TheTuningList[5];
            lblString2.Text = TheTuningList[4];
            lblString3.Text = TheTuningList[3];
            lblString4.Text = TheTuningList[2];
            lblString5.Text = TheTuningList[1];
            lblString6.Text = TheTuningList[0];

        }
     

        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count==1)
            {
                FS = new FormSettings(this);
                FS.Show();
            }
            else
            {
                MessageBox.Show("Song Settings Are Already Open In Another Window.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       
        }
    }
}

