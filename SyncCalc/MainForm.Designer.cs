
namespace SyncCalc
{
    partial class MainForm
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
            this.txtStartSec = new System.Windows.Forms.TextBox();
            this.txtEndSec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEndFrame = new System.Windows.Forms.TextBox();
            this.txtStartFrame = new System.Windows.Forms.TextBox();
            this.lblToCalc = new System.Windows.Forms.Label();
            this.txtBeatsOrBpm = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblOutputDesc = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.rdioBPM = new System.Windows.Forms.RadioButton();
            this.rdioBeats = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFpsSelector = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtStartSec
            // 
            this.txtStartSec.Location = new System.Drawing.Point(98, 53);
            this.txtStartSec.Name = "txtStartSec";
            this.txtStartSec.Size = new System.Drawing.Size(32, 20);
            this.txtStartSec.TabIndex = 0;
            // 
            // txtEndSec
            // 
            this.txtEndSec.Location = new System.Drawing.Point(98, 94);
            this.txtEndSec.Name = "txtEndSec";
            this.txtEndSec.Size = new System.Drawing.Size(32, 20);
            this.txtEndSec.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "sec";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "frame";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "End";
            // 
            // txtEndFrame
            // 
            this.txtEndFrame.Location = new System.Drawing.Point(136, 94);
            this.txtEndFrame.Name = "txtEndFrame";
            this.txtEndFrame.Size = new System.Drawing.Size(32, 20);
            this.txtEndFrame.TabIndex = 7;
            // 
            // txtStartFrame
            // 
            this.txtStartFrame.Location = new System.Drawing.Point(136, 53);
            this.txtStartFrame.Name = "txtStartFrame";
            this.txtStartFrame.Size = new System.Drawing.Size(32, 20);
            this.txtStartFrame.TabIndex = 6;
            // 
            // lblToCalc
            // 
            this.lblToCalc.AutoSize = true;
            this.lblToCalc.Location = new System.Drawing.Point(13, 154);
            this.lblToCalc.Name = "lblToCalc";
            this.lblToCalc.Size = new System.Drawing.Size(34, 13);
            this.lblToCalc.TabIndex = 8;
            this.lblToCalc.Text = "Beats";
            // 
            // txtBeatsOrBpm
            // 
            this.txtBeatsOrBpm.Location = new System.Drawing.Point(98, 151);
            this.txtBeatsOrBpm.Name = "txtBeatsOrBpm";
            this.txtBeatsOrBpm.Size = new System.Drawing.Size(32, 20);
            this.txtBeatsOrBpm.TabIndex = 9;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(16, 245);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(150, 47);
            this.btnCalc.TabIndex = 10;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblOutputDesc
            // 
            this.lblOutputDesc.AutoSize = true;
            this.lblOutputDesc.Location = new System.Drawing.Point(13, 199);
            this.lblOutputDesc.Name = "lblOutputDesc";
            this.lblOutputDesc.Size = new System.Drawing.Size(77, 13);
            this.lblOutputDesc.TabIndex = 11;
            this.lblOutputDesc.Text = "Output (BPM): ";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput.Location = new System.Drawing.Point(95, 199);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(144, 15);
            this.lblOutput.TabIndex = 12;
            this.lblOutput.Text = "Output will be displayed here";
            // 
            // rdioBPM
            // 
            this.rdioBPM.AutoSize = true;
            this.rdioBPM.Location = new System.Drawing.Point(10, 27);
            this.rdioBPM.Name = "rdioBPM";
            this.rdioBPM.Size = new System.Drawing.Size(48, 17);
            this.rdioBPM.TabIndex = 13;
            this.rdioBPM.TabStop = true;
            this.rdioBPM.Text = "BPM";
            this.rdioBPM.UseVisualStyleBackColor = true;
            this.rdioBPM.CheckedChanged += new System.EventHandler(this.rdioBPM_CheckedChanged);
            // 
            // rdioBeats
            // 
            this.rdioBeats.AutoSize = true;
            this.rdioBeats.Location = new System.Drawing.Point(101, 27);
            this.rdioBeats.Name = "rdioBeats";
            this.rdioBeats.Size = new System.Drawing.Size(52, 17);
            this.rdioBeats.TabIndex = 14;
            this.rdioBeats.TabStop = true;
            this.rdioBeats.Text = "Beats";
            this.rdioBeats.UseVisualStyleBackColor = true;
            this.rdioBeats.CheckedChanged += new System.EventHandler(this.rdioBeats_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdioBeats);
            this.groupBox1.Controls.Add(this.rdioBPM);
            this.groupBox1.Location = new System.Drawing.Point(6, 322);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 60);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose what to calculate";
            // 
            // cmbFpsSelector
            // 
            this.cmbFpsSelector.FormattingEnabled = true;
            this.cmbFpsSelector.Location = new System.Drawing.Point(224, 151);
            this.cmbFpsSelector.Name = "cmbFpsSelector";
            this.cmbFpsSelector.Size = new System.Drawing.Size(121, 21);
            this.cmbFpsSelector.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Framerate:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbFpsSelector);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblOutputDesc);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtBeatsOrBpm);
            this.Controls.Add(this.lblToCalc);
            this.Controls.Add(this.txtEndFrame);
            this.Controls.Add(this.txtStartFrame);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEndSec);
            this.Controls.Add(this.txtStartSec);
            this.Name = "MainForm";
            this.Text = "Sync Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStartSec;
        private System.Windows.Forms.TextBox txtEndSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEndFrame;
        private System.Windows.Forms.TextBox txtStartFrame;
        private System.Windows.Forms.Label lblToCalc;
        private System.Windows.Forms.TextBox txtBeatsOrBpm;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblOutputDesc;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.RadioButton rdioBPM;
        private System.Windows.Forms.RadioButton rdioBeats;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbFpsSelector;
        private System.Windows.Forms.Label label5;
    }
}

