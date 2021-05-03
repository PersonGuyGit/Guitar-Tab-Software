
namespace Guitar_Tab_Software
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.lblSettings = new System.Windows.Forms.Label();
            this.cbTunings = new System.Windows.Forms.ComboBox();
            this.btnApplySettings = new System.Windows.Forms.Button();
            this.txtSongName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimeSig = new System.Windows.Forms.TextBox();
            this.txtTone = new System.Windows.Forms.TextBox();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSettings
            // 
            this.lblSettings.Font = new System.Drawing.Font("Bahnschrift Condensed", 50F, System.Drawing.FontStyle.Bold);
            this.lblSettings.Location = new System.Drawing.Point(12, 15);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(660, 115);
            this.lblSettings.TabIndex = 25;
            this.lblSettings.Text = "Tunings, Tones, and Settings";
            // 
            // cbTunings
            // 
            this.cbTunings.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbTunings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTunings.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTunings.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbTunings.FormattingEnabled = true;
            this.cbTunings.Location = new System.Drawing.Point(186, 400);
            this.cbTunings.Name = "cbTunings";
            this.cbTunings.Size = new System.Drawing.Size(317, 21);
            this.cbTunings.TabIndex = 32;
            this.cbTunings.SelectedIndexChanged += new System.EventHandler(this.cbTunings_SelectedIndexChanged);
            // 
            // btnApplySettings
            // 
            this.btnApplySettings.BackColor = System.Drawing.Color.Black;
            this.btnApplySettings.Font = new System.Drawing.Font("Bahnschrift Condensed", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplySettings.Location = new System.Drawing.Point(186, 506);
            this.btnApplySettings.Name = "btnApplySettings";
            this.btnApplySettings.Size = new System.Drawing.Size(317, 110);
            this.btnApplySettings.TabIndex = 5;
            this.btnApplySettings.Text = "Apply Settings";
            this.btnApplySettings.UseVisualStyleBackColor = false;
            this.btnApplySettings.Click += new System.EventHandler(this.btnApplySettings_Click);
            // 
            // txtSongName
            // 
            this.txtSongName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtSongName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSongName.Location = new System.Drawing.Point(320, 143);
            this.txtSongName.Name = "txtSongName";
            this.txtSongName.Size = new System.Drawing.Size(285, 29);
            this.txtSongName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 42);
            this.label1.TabIndex = 37;
            this.label1.Text = "Song Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 42);
            this.label2.TabIndex = 38;
            this.label2.Text = "Time Signature";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 42);
            this.label3.TabIndex = 39;
            this.label3.Text = "Tempo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 42);
            this.label4.TabIndex = 41;
            this.label4.Text = "Tone";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTimeSig
            // 
            this.txtTimeSig.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTimeSig.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeSig.Location = new System.Drawing.Point(320, 204);
            this.txtTimeSig.Name = "txtTimeSig";
            this.txtTimeSig.Size = new System.Drawing.Size(285, 29);
            this.txtTimeSig.TabIndex = 2;
            // 
            // txtTone
            // 
            this.txtTone.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTone.Location = new System.Drawing.Point(320, 329);
            this.txtTone.Name = "txtTone";
            this.txtTone.Size = new System.Drawing.Size(285, 29);
            this.txtTone.TabIndex = 4;
            // 
            // txtTempo
            // 
            this.txtTempo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTempo.Location = new System.Drawing.Point(320, 266);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(285, 29);
            this.txtTempo.TabIndex = 3;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(671, 628);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.txtTone);
            this.Controls.Add(this.txtTimeSig);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSongName);
            this.Controls.Add(this.btnApplySettings);
            this.Controls.Add(this.cbTunings);
            this.Controls.Add(this.lblSettings);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advanced Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.ComboBox cbTunings;
        private System.Windows.Forms.Button btnApplySettings;
        private System.Windows.Forms.TextBox txtSongName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTimeSig;
        private System.Windows.Forms.TextBox txtTone;
        private System.Windows.Forms.TextBox txtTempo;
    }
}