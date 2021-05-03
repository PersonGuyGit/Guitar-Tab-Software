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

        List<String> stringNames = new List<string>();

        Song NewSong = new Song();

        public bool bCanMoveOverToForm1
        { get; set; }

        public bool bStringsChanged
        { get; set; }

        public FormSettings(MainForm form)
        { 
            MF = form;
            InitializeComponent();

            string[] names = new string[] { "Standard Tuning", "D# Standard Tuning", "Drop D Tuning", "Drop C Tuning", "D Standard Tuning", "Drop C# Tuning" };

            cbTunings.Items.AddRange(names);
        }

        public class Song
        {
            public string Tempo
            { get; set; }

            public string SongName
            { get; set; }

            public string TimeSignature
            { get; set; }

            public string Tone
            { get; set; }
        }

        public FormSettings()
        {
            InitializeComponent();  
        }

        private void formSettings_Load(object sender, EventArgs e)
        {
            bCanMoveOverToForm1 = false;
        }

        private void btnApplySettings_Click(object sender, EventArgs e)
        {
            string selectedTuning = cbTunings.Text;

            if (cbTunings.Text != "")
            {
                bCanMoveOverToForm1 = true;
            }

            if (txtSongName.Text != "")
            {
                bCanMoveOverToForm1 = true;
            }

            if (txtTone.Text != "")
            {
                bCanMoveOverToForm1 = true;
            }

            if (txtTempo.Text != "")
            {
                bCanMoveOverToForm1 = true;
            }

            if (txtTimeSig.Text != "")
            {
                bCanMoveOverToForm1 = true;
            }

            if (bCanMoveOverToForm1 == true && bStringsChanged == true)
            {
                NewSong.SongName = txtSongName.Text;
                NewSong.Tone = txtTone.Text;
                NewSong.Tempo = txtTempo.Text;
                NewSong.TimeSignature = txtTimeSig.Text;

                {
                    switch (selectedTuning)
                    {
                        case "Standard Tuning":
                            List<string> StdTuningList = new List<string>() { "E", "A", "D", "G", "B", "E" };
                            stringNames.AddRange(StdTuningList);
                            break;

                        case "D# Standard Tuning":
                            List<string> EbTuningList = new List<string>() { "D#", "G#", "C#", "F#", "A#", "D#" };
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
                    MF.UpdateDetails(NewSong.SongName, NewSong.Tone, NewSong.TimeSignature, NewSong.Tempo);

                    stringNames.Clear();
                }
            }

            if (bCanMoveOverToForm1 == false || bStringsChanged == false)
            {
                MessageBox.Show("Settings must be populated.", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbTunings_SelectedIndexChanged(object sender, EventArgs e)
        {
            bStringsChanged = true;
        }
    }
}
