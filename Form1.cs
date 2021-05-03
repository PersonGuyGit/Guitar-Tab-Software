using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guitar_Tab_Software
{
    public partial class MainForm : Form
    {
        // If not enabled, the user cannot save to a file, as the details on the top would be blank otherwise 
        public bool bCanSaveToFile
        {
            get; set;
        }

        FormSettings FS;

        public int NumOfBars
        {
            get; set;
        }

        private SoundPlayer IntroTheme;

        List<string> TxtFromString1 = new List<string>();
        List<string> TxtFromString2 = new List<string>();
        List<string> TxtFromString3 = new List<string>();
        List<string> TxtFromString4 = new List<string>();
        List<string> TxtFromString5 = new List<string>();
        List<string> TxtFromString6 = new List<string>();

        public MainForm()
        {
            InitializeComponent();
            NumOfBars = 0;
            bCanSaveToFile = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IntroTheme = new SoundPlayer("IntroMusic.wav");
            IntroTheme.Play();
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
     

        private void btnOpenAdvancedFormSettings(object sender, EventArgs e)
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

        public void UpdateDetails(string songName, string tone, string timeSignature, string tempo)
        {
            lblSongName.Text = songName;
            lblTone.Text = tone;
            lblTimeSignature.Text = timeSignature;
            lblTempo.Text = tempo;

            bCanSaveToFile = true;
        }

        private void btnCreateSongFile_Click(object sender, EventArgs e)
        {
            if (bCanSaveToFile == true)
            {
                SaveFileDialog saveDlg = new SaveFileDialog();

                saveDlg.Title = "Save to a file";
                saveDlg.Filter = "Text Files|*.txt*|All Files|*.*";


                DialogResult result = saveDlg.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string fName = saveDlg.FileName;
                    FileStream fs = new FileStream(fName, FileMode.Create);
                    StreamWriter sw = new StreamWriter(fs);

                    sw.WriteLine("Song Name: " + lblSongName.Text);
                    sw.WriteLine("Tone: " + lblTone.Text);
                    sw.WriteLine("Time Signature: " + lblTimeSignature.Text);
                    sw.WriteLine("Tempo: " + lblTempo.Text + "\n");

                    for (int i = 0; i < NumOfBars; i++)
                    {
                        sw.WriteLine(lblString1.Text + " " + TxtFromString6[i]);
                        sw.WriteLine(lblString2.Text + " " + TxtFromString5[i]);
                        sw.WriteLine(lblString3.Text + " " + TxtFromString5[i]);
                        sw.WriteLine(lblString4.Text + " " + TxtFromString3[i]);
                        sw.WriteLine(lblString5.Text + " " + TxtFromString2[i]);
                        sw.WriteLine(lblString6.Text + " " + TxtFromString1[i] + "\n");
                    }

                    sw.WriteLine("Created using Instant Guitar Tab software: Created by Luke Gebbink");

                    sw.Close();
                }
            }

            if (bCanSaveToFile == false)
            {
                MessageBox.Show("Advanced Song Settings must be defined before song can be saved", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAddCurrentBarToFile_Click(object sender, EventArgs e)
        {
            ++NumOfBars;

            TxtFromString1.Add(textBox6.Text);
            TxtFromString2.Add(textBox5.Text);
            TxtFromString3.Add(textBox4.Text);
            TxtFromString4.Add(textBox3.Text);
            TxtFromString5.Add(textBox2.Text);
            TxtFromString6.Add(textBox1.Text);
        }
    }
}

