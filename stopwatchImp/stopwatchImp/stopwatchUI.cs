using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace stopwatchImp
{
    public partial class stopwatchUI : Form
    {

        StopwatchCS s;

        public stopwatchUI()
        {
            InitializeComponent();
            s = new StopwatchCS();
        }

        private void stopwatchUI_Load(object sender, EventArgs e) {}

        private void ResetLapButton_Click(object sender, EventArgs e)
        {
            s.resetLapButton();
        }

        private void ModeButton_Click(object sender, EventArgs e)
        {
            s.modeButton();
        }

        private void StartStopButton_Click(object sender, EventArgs e)
        {
            s.startStopButton();
        }

        private void display_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            Graphics g = e.Graphics;
            SolidBrush brush = new SolidBrush(Color.Black);
            Font font = new Font("Courier", 18, FontStyle.Regular);
            g.DrawString(s.getCurrentDisplay(), font, brush, 0, 0);
        }

        private void displayTimer_Tick(object sender, EventArgs e)
        {
            this.display.Refresh();
        }

    }
}
