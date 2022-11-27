using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyncCalc
{
    public partial class MainForm : Form
    {
        double dblStartSec;
        double dblEndSec;
        double dblBPM;
        double dblBeats;
        double dblFramerate;

        int intStartFrame;
        int intEndFrame;

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        public void InitializeGUI()
        {
            rdioBPM.Checked = true;

            cmbFpsSelector.Items.Add("24");
            cmbFpsSelector.Items.Add("30");

            cmbFpsSelector.SelectedIndex = 0;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            BeatsCalculator beatsCalculator = new BeatsCalculator();

            double calcBPM = 0;

            ReadInput();

            if (rdioBPM.Checked)
            {
                calcBPM = beatsCalculator.CalculateBeatsPerMinute(dblStartSec, intStartFrame, dblEndSec, intEndFrame, dblBeats, dblFramerate);
            }
            else if (rdioBeats.Checked)
            {
                calcBPM = beatsCalculator.CalculateBeats(dblStartSec, intStartFrame, dblEndSec, intEndFrame, dblBPM, dblFramerate);
            }

            lblOutput.Text = calcBPM.ToString();
        }

        private bool ReadInput()
        {
            string strStartSec = txtStartSec.Text;
            string strStartFrame = txtStartFrame.Text;
            string strEndSec = txtEndSec.Text;
            string strEndFrame = txtEndFrame.Text;
            string strBeatsOrBpm = txtBeatsOrBpm.Text;
            string strFramerate = cmbFpsSelector.SelectedItem.ToString();

            bool bStartSec = Double.TryParse(strStartSec, out dblStartSec);

            if(!bStartSec || dblStartSec < 0)
            {
                MessageBox.Show("Invalid input in the Start Second field");
                return false;
            }

            bool bStartFrame = int.TryParse(strStartFrame, out intStartFrame);

            if (!bStartFrame || intStartFrame < 0)
            {
                MessageBox.Show("Invalid input in the Start Frame field");
                return false;
            }

            bool bEndSec = Double.TryParse(strEndSec, out dblEndSec);

            if (!bEndSec || dblEndSec < 0 || dblEndSec < dblStartSec)
            {
                MessageBox.Show("Invalid input in the End Second field");
                return false;
            }

            bool bEndFrame = int.TryParse(strEndFrame, out intEndFrame);

            if (!bEndFrame || intEndFrame < 0 || (dblEndSec == dblStartSec && intEndFrame <= intStartFrame))
            {
                MessageBox.Show("Invalid input in the End Frame field");
                return false;
            }


            bool bFramerate = Double.TryParse(strFramerate, out dblFramerate);

            if (!bFramerate || dblEndSec < 0)
            {
                MessageBox.Show("Invalid input in the Framerate field");
                return false;
            }

            if(rdioBPM.Checked)
            {
                bool bBeats = Double.TryParse(strBeatsOrBpm, out dblBeats);
                if(!bBeats || dblBeats < 0)
                {
                    MessageBox.Show("Invalid input in the Beats field");
                    return false;
                }
            }
            else if(rdioBeats.Checked)
            {
                bool bBpm = Double.TryParse(strBeatsOrBpm, out dblBPM);
                if (!bBpm || dblBPM < 0)
                {
                    MessageBox.Show("Invalid input in the BPM field");
                    return false;
                }
            }

            return true;
        }

        private void rdioBPM_CheckedChanged(object sender, EventArgs e)
        {
            lblOutputDesc.Text = "Output (BPM): ";
            lblToCalc.Text = "Beats";
        }

        private void rdioBeats_CheckedChanged(object sender, EventArgs e)
        {
            lblOutputDesc.Text = "Output (Beats): ";
            lblToCalc.Text = "BPM";
        }
    }
}

