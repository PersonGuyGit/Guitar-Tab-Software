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

    public partial class FormSettings : Form
    {

        MainForm MF;

        List<String> stringNames;

        public FormSettings(MainForm form)
        {
            

            MF = form;
            InitializeComponent();

            string[] names = new string[] { "Standard Tuning", "E FLat Tuning", "Drop D Tuning", "Drop C Tuning", "D Standard Tuning", "Drop C# Tuning" };

            cbTunings.Items.AddRange(names);

        }


        public class Song
        {
            private int Tempo;
            private string songName;
            private string Tone;
            private string TimeSignature;

            public int PTempo
            {
                get
                {
                    return Tempo;
                }

                set
                {
                    Tempo = value;
                }
            }
            public string PSongName
            {
                get
                {
                    return songName;
                }

                set
                {
                   songName = value;
                }
            }
            public string PTone
            {
                get
                {
                    return Tone;
                }

                set
                {
                    Tone = value;
                }
            }
            public string PTimeSignature
            {
                get
                {
                    return TimeSignature;
                }

                set
                {
                    TimeSignature = value;
                }
            }


            

        }

        public FormSettings()
        {
            InitializeComponent();
        }

        private void formSettings_Load(object sender, EventArgs e)
        {
               PictureBox pbTabGuide = new PictureBox();
               pbTabGuide.ImageLocation = "../SamuderaJayaMotor.png";
               pbTabGuide.SizeMode = PictureBoxSizeMode.AutoSize;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnApplySettings_Click(object sender, EventArgs e)
        {

            //When Clicked, all of the options will be confirmed and put into the main form



            // Confirm the selected tuning, and assign the string letters to the selections

            string selectedTuning = cbTunings.Text;

            switch (selectedTuning)
            {
                case "Standard Tuning":
                    List<string> StdTuningList = new List<string>() { "E", "A", "D", "G", "B", "E" };
                    stringNames.AddRange(StdTuningList);
                    break;

                case "E Flat Tuning":
                    List<string> EbTuningList = new List<string>() { "Eb", "Ab", "Db", "Gb", "Bb", "Eb" };
                    stringNames.AddRange(EbTuningList);
                    break;

                case "Drop D Tuning":
                    List<string> DropDTuningList = new List<string>() { "D", "A", "D", "G", "B", "E" };
                    stringNames.AddRange(DropDTuningList);
                    break;
                case "Drop C Tuning":
                    List<string> DropCTuningList = new List<string>() { "C", "G", "C", "F", "A", "D" };
                    stringNames.AddRange(DropCTuningList);
                    break;
                case "D Standard Tuning":
                    List<string> DStdTuningList = new List<string>() { "D", "G", "C", "F", "A", "D" };
                    stringNames.AddRange(DStdTuningList);
                    break;
                case "Drop C# Tuning":
                    List<string> DropCSharpTuningList = new List<string>() { "C#", "G#", "C#", "F#", "A#", "D#" };
                    stringNames.AddRange(DropCSharpTuningList);
                    break;
            }

            MF.changeTunings(stringNames);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
