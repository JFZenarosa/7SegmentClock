using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7SegmentClock
{
    public partial class SevenSegmentClock : Form
    {
        System.Media.SoundPlayer BGMmusic = new System.Media.SoundPlayer();

        int sec;
        int sec2;
        int min;
        int min2;
        int hr;
        int hr2;
        string current_sec;
        string current_sec2;
        string current_min;
        string current_min2;
        string current_hr;
        string current_hr2;


        public SevenSegmentClock()
        {
            BGMmusic.SoundLocation = "CanonD.wav";
            InitializeComponent();
        }

        private void clockTic(object sender, EventArgs e)
        {
            Button segmentBtnClick = (Button)sender;
            segmentBtnClick.BackColor = System.Drawing.Color.FromArgb(235, 21, 57);
        }

        private void clockTicTimer_Tick(object sender, EventArgs e)
        {
            current_sec = DateTime.Now.ToString("ss");
            sec = Convert.ToInt32(current_sec.Substring(current_sec.Length - 1));

            //SecondsOnesPlace

            if (sec == 0)
            {
                btnTopSec.PerformClick();
                btnTopSecLeft.PerformClick();
                btnTopSecRight.PerformClick();
                btnBotSecLeft.PerformClick();
                btnBotSecRight.PerformClick();
                btnBotSec.PerformClick();
                btnMidSec.BackColor = System.Drawing.Color.Transparent;

            }
            else if (sec == 1)
            {
                btnTopSecRight.PerformClick();
                btnBotSecRight.PerformClick();
                btnTopSec.BackColor = System.Drawing.Color.Transparent;
                btnTopSecLeft.BackColor = System.Drawing.Color.Transparent;
                btnMidSec.BackColor = System.Drawing.Color.Transparent;
                btnBotSecLeft.BackColor = System.Drawing.Color.Transparent;
                btnBotSec.BackColor = System.Drawing.Color.Transparent;
            }
            else if (sec == 2)
            {
                btnTopSec.PerformClick();
                btnTopSecRight.PerformClick();
                btnMidSec.PerformClick();
                btnBotSecLeft.PerformClick();
                btnBotSec.PerformClick();
                btnTopSecLeft.BackColor = System.Drawing.Color.Transparent;
                btnBotSecRight.BackColor = System.Drawing.Color.Transparent;
            }
            else if (sec == 3)
            {
                btnTopSec.PerformClick();
                btnTopSecRight.PerformClick();
                btnMidSec.PerformClick();
                btnBotSecRight.PerformClick();
                btnBotSec.PerformClick();
                btnTopSecLeft.BackColor = System.Drawing.Color.Transparent;
                btnBotSecLeft.BackColor = System.Drawing.Color.Transparent;
            }
            else if (sec == 4)
            {
                btnTopSecRight.PerformClick();
                btnTopSecLeft.PerformClick();
                btnMidSec.PerformClick();
                btnBotSecRight.PerformClick();
                btnTopSec.BackColor = System.Drawing.Color.Transparent;
                btnBotSecLeft.BackColor = System.Drawing.Color.Transparent;
                btnBotSec.BackColor = System.Drawing.Color.Transparent;
            }
            else if (sec == 5)
            {
                btnTopSec.PerformClick();
                btnTopSecLeft.PerformClick();
                btnMidSec.PerformClick();
                btnBotSecRight.PerformClick();
                btnBotSec.PerformClick();
                btnTopSecRight.BackColor = System.Drawing.Color.Transparent;
                btnBotSecLeft.BackColor = System.Drawing.Color.Transparent;
            }
            else if (sec == 6)
            {
                btnTopSec.PerformClick();
                btnTopSecLeft.PerformClick();
                btnMidSec.PerformClick();
                btnBotSecLeft.PerformClick();
                btnBotSecRight.PerformClick();
                btnBotSec.PerformClick();
                btnTopSecRight.BackColor = System.Drawing.Color.Transparent;
            }
            else if (sec == 7)
            {
                btnTopSec.PerformClick();
                btnTopSecRight.PerformClick();
                btnBotSecRight.PerformClick();
                btnTopSecLeft.BackColor = System.Drawing.Color.Transparent;
                btnMidSec.BackColor = System.Drawing.Color.Transparent;
                btnBotSecLeft.BackColor = System.Drawing.Color.Transparent;
                btnBotSec.BackColor = System.Drawing.Color.Transparent;
            }
            else if (sec == 8)
            {
                btnTopSec.PerformClick();
                btnTopSecRight.PerformClick();
                btnBotSecRight.PerformClick();
                btnTopSecLeft.PerformClick();
                btnMidSec.PerformClick();
                btnBotSecLeft.PerformClick();
                btnBotSec.PerformClick();
            }
            else if (sec == 9)
            {
                btnTopSec.PerformClick();
                btnTopSecRight.PerformClick();
                btnTopSecLeft.PerformClick();
                btnMidSec.PerformClick();
                btnBotSecRight.PerformClick();
                btnBotSec.PerformClick();
                btnBotSecLeft.BackColor = System.Drawing.Color.Transparent;
            }

            //SecondsTensPlace

            current_sec2 = DateTime.Now.ToString("ss");
            sec2 = Convert.ToInt32(current_sec2.Substring(0, 1));

            if (sec2 == 0)
            {
                btnTopSec2.PerformClick();
                btnTopSecLeft2.PerformClick();
                btnTopSecRight2.PerformClick();
                btnBotSecLeft2.PerformClick();
                btnBotSecRight2.PerformClick();
                btnBotSec2.PerformClick();
                btnMidSec2.BackColor = System.Drawing.Color.Transparent;
            }
            else if (sec2 == 1)
            {
                btnTopSecRight2.PerformClick();
                btnBotSecRight2.PerformClick();
                btnTopSec2.BackColor = System.Drawing.Color.Transparent;
                btnTopSecLeft2.BackColor = System.Drawing.Color.Transparent;
                btnMidSec2.BackColor = System.Drawing.Color.Transparent;
                btnBotSecLeft2.BackColor = System.Drawing.Color.Transparent;
                btnBotSec2.BackColor = System.Drawing.Color.Transparent;
            }
            else if (sec2 == 2)
            {
                btnTopSec2.PerformClick();
                btnTopSecRight2.PerformClick();
                btnMidSec2.PerformClick();
                btnBotSecLeft2.PerformClick();
                btnBotSec2.PerformClick();
                btnTopSecLeft2.BackColor = System.Drawing.Color.Transparent;
                btnBotSecRight2.BackColor = System.Drawing.Color.Transparent;
            }
            else if (sec2 == 3)
            {
                btnTopSec2.PerformClick();
                btnTopSecRight2.PerformClick();
                btnMidSec2.PerformClick();
                btnBotSecRight2.PerformClick();
                btnBotSec2.PerformClick();
                btnTopSecLeft2.BackColor = System.Drawing.Color.Transparent;
                btnBotSecLeft2.BackColor = System.Drawing.Color.Transparent;
            }
            else if (sec2 == 4)
            {
                btnTopSecRight2.PerformClick();
                btnTopSecLeft2.PerformClick();
                btnMidSec2.PerformClick();
                btnBotSecRight2.PerformClick();
                btnTopSec2.BackColor = System.Drawing.Color.Transparent;
                btnBotSecLeft2.BackColor = System.Drawing.Color.Transparent;
                btnBotSec2.BackColor = System.Drawing.Color.Transparent;
            }
            else if (sec2 == 5)
            {
                btnTopSec2.PerformClick();
                btnTopSecLeft2.PerformClick();
                btnMidSec2.PerformClick();
                btnBotSecRight2.PerformClick();
                btnBotSec2.PerformClick();
                btnTopSecRight2.BackColor = System.Drawing.Color.Transparent;
                btnBotSecLeft2.BackColor = System.Drawing.Color.Transparent;
            }

            //MinutesOnesPlace

            current_min = DateTime.Now.ToString("mm");
            min = Convert.ToInt32(current_min.Substring(current_min.Length - 1));

            if (min == 0)
            {
                btnTopMin.PerformClick();
                btnTopMinLeft.PerformClick();
                btnTopMinRight.PerformClick();
                btnBotMinLeft.PerformClick();
                btnBotMinRight.PerformClick();
                btnBotMin.PerformClick();
                btnMidMin.BackColor = System.Drawing.Color.Transparent;
            }
            else if (min == 1)
            {
                btnTopMinRight.PerformClick();
                btnBotMinRight.PerformClick();
                btnTopMin.BackColor = System.Drawing.Color.Transparent;
                btnTopMinLeft.BackColor = System.Drawing.Color.Transparent;
                btnMidMin.BackColor = System.Drawing.Color.Transparent;
                btnBotMinLeft.BackColor = System.Drawing.Color.Transparent;
                btnBotMin.BackColor = System.Drawing.Color.Transparent;
            }
            else if (min == 2)
            {
                btnTopMin.PerformClick();
                btnTopMinRight.PerformClick();
                btnMidMin.PerformClick();
                btnBotMinLeft.PerformClick();
                btnBotMin.PerformClick();
                btnTopMinLeft.BackColor = System.Drawing.Color.Transparent;
                btnBotMinRight.BackColor = System.Drawing.Color.Transparent;
            }
            else if (min == 3)
            {
                btnTopMin.PerformClick();
                btnTopMinRight.PerformClick();
                btnMidMin.PerformClick();
                btnBotMinRight.PerformClick();
                btnBotMin.PerformClick();
                btnTopMinLeft.BackColor = System.Drawing.Color.Transparent;
                btnBotMinLeft.BackColor = System.Drawing.Color.Transparent;
            }
            else if (min == 4)
            {
                btnTopMinRight.PerformClick();
                btnTopMinLeft.PerformClick();
                btnMidMin.PerformClick();
                btnBotMinRight.PerformClick();
                btnTopMin.BackColor = System.Drawing.Color.Transparent;
                btnBotMinLeft.BackColor = System.Drawing.Color.Transparent;
                btnBotMin.BackColor = System.Drawing.Color.Transparent;
            }
            else if (min == 5)
            {
                btnTopMin.PerformClick();
                btnTopMinLeft.PerformClick();
                btnMidMin.PerformClick();
                btnBotMinRight.PerformClick();
                btnBotMin.PerformClick();
                btnTopMinRight.BackColor = System.Drawing.Color.Transparent;
                btnBotMinLeft.BackColor = System.Drawing.Color.Transparent;
            }
            else if (min == 6)
            {
                btnTopMin.PerformClick();
                btnTopMinLeft.PerformClick();
                btnMidMin.PerformClick();
                btnBotMinLeft.PerformClick();
                btnBotMinRight.PerformClick();
                btnBotMin.PerformClick();
                btnTopMinRight.BackColor = System.Drawing.Color.Transparent;
            }
            else if (min == 7)
            {
                btnTopMin.PerformClick();
                btnTopMinRight.PerformClick();
                btnBotMinRight.PerformClick();
                btnTopMinLeft.BackColor = System.Drawing.Color.Transparent;
                btnMidMin.BackColor = System.Drawing.Color.Transparent;
                btnBotMinLeft.BackColor = System.Drawing.Color.Transparent;
                btnBotMin.BackColor = System.Drawing.Color.Transparent;
            }
            else if (min == 8)
            {
                btnTopMin.PerformClick();
                btnTopMinRight.PerformClick();
                btnBotMinRight.PerformClick();
                btnTopMinLeft.PerformClick();
                btnMidMin.PerformClick();
                btnBotMinLeft.PerformClick();
                btnBotMin.PerformClick();
            }
            else if (min == 9)
            {
                btnTopMin.PerformClick();
                btnTopMinRight.PerformClick();
                btnTopMinLeft.PerformClick();
                btnMidMin.PerformClick();
                btnBotMinRight.PerformClick();
                btnBotMin.PerformClick();
                btnBotMinLeft.BackColor = System.Drawing.Color.Transparent;
            }

            //MinutesTensPlace

            current_min2 = DateTime.Now.ToString("mm");
            min2 = Convert.ToInt32(current_min2.Substring(0, 1));

            if (min2 == 0)
            {
                btnTopMin2.PerformClick();
                btnTopMinLeft2.PerformClick();
                btnTopMinRight2.PerformClick();
                btnBotMinLeft2.PerformClick();
                btnBotMinRight2.PerformClick();
                btnBotMin2.PerformClick();
                btnMidMin2.BackColor = System.Drawing.Color.Transparent;
            }
            else if (min2 == 1)
            {
                btnTopMinRight2.PerformClick();
                btnBotMinRight2.PerformClick();
                btnTopMin2.BackColor = System.Drawing.Color.Transparent;
                btnTopMinLeft2.BackColor = System.Drawing.Color.Transparent;
                btnMidMin2.BackColor = System.Drawing.Color.Transparent;
                btnBotMinLeft2.BackColor = System.Drawing.Color.Transparent;
                btnBotMin2.BackColor = System.Drawing.Color.Transparent;
            }
            else if (min2 == 2)
            {
                btnTopMin2.PerformClick();
                btnTopMinRight2.PerformClick();
                btnMidMin2.PerformClick();
                btnBotMinLeft2.PerformClick();
                btnBotMin2.PerformClick();
                btnTopMinLeft2.BackColor = System.Drawing.Color.Transparent;
                btnBotMinRight2.BackColor = System.Drawing.Color.Transparent;
            }
            else if (min2 == 3)
            {
                btnTopMin2.PerformClick();
                btnTopMinRight2.PerformClick();
                btnMidMin2.PerformClick();
                btnBotMinRight2.PerformClick();
                btnBotMin2.PerformClick();
                btnTopMinLeft2.BackColor = System.Drawing.Color.Transparent;
                btnBotMinLeft2.BackColor = System.Drawing.Color.Transparent;
            }
            else if (min2 == 4)
            {
                btnTopMinRight2.PerformClick();
                btnTopMinLeft2.PerformClick();
                btnMidMin2.PerformClick();
                btnBotMinRight2.PerformClick();
                btnTopMin2.BackColor = System.Drawing.Color.Transparent;
                btnBotMinLeft2.BackColor = System.Drawing.Color.Transparent;
                btnBotMin2.BackColor = System.Drawing.Color.Transparent;
            }
            else if (min2 == 5)
            {
                btnTopMin2.PerformClick();
                btnTopMinLeft2.PerformClick();
                btnMidMin2.PerformClick();
                btnBotMinRight2.PerformClick();
                btnBotMin2.PerformClick();
                btnTopMinRight2.BackColor = System.Drawing.Color.Transparent;
                btnBotMinLeft2.BackColor = System.Drawing.Color.Transparent;
            }

            //HoursOnesPlace

            current_hr = DateTime.Now.ToString("hh");
            hr = Convert.ToInt32(current_hr.Substring(current_hr.Length-1));

            if (hr == 0)
            {
                btnTopHr.PerformClick();
                btnTopHrLeft.PerformClick();
                btnTopHrRight.PerformClick();
                btnBotHrLeft.PerformClick();
                btnBotHrRight.PerformClick();
                btnBotHr.PerformClick();
                btnMidHr.BackColor = System.Drawing.Color.Transparent;
            }
            else if (hr == 1)
            {
                btnTopHrRight.PerformClick();
                btnBotHrRight.PerformClick();
                btnTopHr.BackColor = System.Drawing.Color.Transparent;
                btnTopHrLeft.BackColor = System.Drawing.Color.Transparent;
                btnMidHr.BackColor = System.Drawing.Color.Transparent;
                btnBotHrLeft.BackColor = System.Drawing.Color.Transparent;
                btnBotHr.BackColor = System.Drawing.Color.Transparent;
            }
            else if (hr == 2)
            {
                btnTopHr.PerformClick();
                btnTopHrRight.PerformClick();
                btnMidHr.PerformClick();
                btnBotHrLeft.PerformClick();
                btnBotHr.PerformClick();
                btnTopHrLeft.BackColor = System.Drawing.Color.Transparent;
                btnBotHrRight.BackColor = System.Drawing.Color.Transparent;
            }
            else if (hr == 3)
            {
                btnTopHr.PerformClick();
                btnTopHrRight.PerformClick();
                btnMidHr.PerformClick();
                btnBotHrRight.PerformClick();
                btnBotHr.PerformClick();
                btnTopHrLeft.BackColor = System.Drawing.Color.Transparent;
                btnBotHrLeft.BackColor = System.Drawing.Color.Transparent;
            }
            else if (hr == 4)
            {
                btnTopHrRight.PerformClick();
                btnTopHrLeft.PerformClick();
                btnMidHr.PerformClick();
                btnBotHrRight.PerformClick();
                btnTopHr.BackColor = System.Drawing.Color.Transparent;
                btnBotHrLeft.BackColor = System.Drawing.Color.Transparent;
                btnBotHr.BackColor = System.Drawing.Color.Transparent;
            }
            else if (hr == 5)
            {
                btnTopHr.PerformClick();
                btnTopHrLeft.PerformClick();
                btnMidHr.PerformClick();
                btnBotHrRight.PerformClick();
                btnBotHr.PerformClick();
                btnTopHrRight.BackColor = System.Drawing.Color.Transparent;
                btnBotHrLeft.BackColor = System.Drawing.Color.Transparent;
            }
            else if (hr == 6)
            {
                btnTopHr.PerformClick();
                btnTopHrLeft.PerformClick();
                btnMidHr.PerformClick();
                btnBotHrLeft.PerformClick();
                btnBotHrRight.PerformClick();
                btnBotHr.PerformClick();
                btnTopHrRight.BackColor = System.Drawing.Color.Transparent;
            }
            else if (hr == 7)
            {
                btnTopHr.PerformClick();
                btnTopHrRight.PerformClick();
                btnBotHrRight.PerformClick();
                btnTopHrLeft.BackColor = System.Drawing.Color.Transparent;
                btnMidHr.BackColor = System.Drawing.Color.Transparent;
                btnBotHrLeft.BackColor = System.Drawing.Color.Transparent;
                btnBotHr.BackColor = System.Drawing.Color.Transparent;
            }
            else if (hr == 8)
            {
                btnTopHr.PerformClick();
                btnTopHrRight.PerformClick();
                btnBotHrRight.PerformClick();
                btnTopHrLeft.PerformClick();
                btnMidHr.PerformClick();
                btnBotHrLeft.PerformClick();
                btnBotHr.PerformClick();
            }
            else if (hr == 9)
            {
                btnTopHr.PerformClick();
                btnTopHrRight.PerformClick();
                btnTopHrLeft.PerformClick();
                btnMidHr.PerformClick();
                btnBotHrRight.PerformClick();
                btnBotHr.PerformClick();
                btnBotHrLeft.BackColor = System.Drawing.Color.Transparent;
            }

            //HoursTensPlace

            current_hr2 = DateTime.Now.ToString("hh");
            hr2 = Convert.ToInt32(current_hr2.Substring(0, 1));

            if (hr2 == 0)
            {
                btnTopHr2.PerformClick();
                btnTopHrLeft2.PerformClick();
                btnTopHrRight2.PerformClick();
                btnBotHrLeft2.PerformClick();
                btnBotHrRight2.PerformClick();
                btnBotHr2.PerformClick();
                btnMidHr2.BackColor = System.Drawing.Color.Transparent;
            }
            else if (hr2 == 1)
            {
                btnTopHrRight2.PerformClick();
                btnBotHrRight2.PerformClick();
                btnTopHr2.BackColor = System.Drawing.Color.Transparent;
                btnTopHrLeft2.BackColor = System.Drawing.Color.Transparent;
                btnMidHr2.BackColor = System.Drawing.Color.Transparent;
                btnBotHrLeft2.BackColor = System.Drawing.Color.Transparent;
                btnBotHr2.BackColor = System.Drawing.Color.Transparent;
            }

            lblTimeConvention.Text = DateTime.Now.ToString("tt");
            lblDateTime.Text = DateTime.Now.ToString();
        }

        private void SevenSegmentClock_Load(object sender, EventArgs e)
        {
            BGMmusic.Play();
        }

        private void musicStop(object sender, FormClosedEventArgs e)
        {
            BGMmusic.Stop();
        }
    }
}
