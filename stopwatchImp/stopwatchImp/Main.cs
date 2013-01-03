using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace stopwatchImp
{
    // Subclass Panel class to create a double-buffered display for the GUI.
    public class StopwatchDisplay : Panel
    {
        public StopwatchDisplay()
        {
            this.DoubleBuffered = true;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);
        }
    }

    // Stopwatch class.
    public class StopwatchCS
    {
        private Stopwatch timer;
        private String frozenTime;

        private Boolean displayFrozen;

        private enum MODE { DateTime, Timer };
        private MODE currentMode;

        public StopwatchCS()
        {
            timer = new Stopwatch();
            timer.Reset();
            displayFrozen = false;
            currentMode = MODE.DateTime;
        }

        // Control Methods to be called by GUI.
        public void modeButton()
        {
            if (currentMode == MODE.DateTime)
            {
                currentMode = MODE.Timer;
            }
            else if (currentMode == MODE.Timer)
            {
                currentMode = MODE.DateTime;
            }
            return;
        }

        public void startStopButton()
        {
            if (currentMode == MODE.Timer)
            {
                if (timer.IsRunning)
                {
                    timer.Stop();
                    displayFrozen = false;
                }
                else if (!timer.IsRunning)
                {
                    timer.Start();
                }
            }
            return;
        }

        public void resetLapButton()
        {
            if (currentMode == MODE.Timer)
            {
                if (timer.IsRunning)
                {
                    if (!displayFrozen)
                    {
                        frozenTime = getCurrentTimer();
                    }
                    displayFrozen = !displayFrozen;
                }
                else if (!timer.IsRunning)
                {
                    timer.Reset();
                }
            }
            return;
        }

        // Added functions for Spec Explorer & Validation Framework access.
        
        public string getMode()
        {
            return currentMode.ToString();
        }

        public string getTimerState()
        {
            if (timer.IsRunning)
            {
                return "Running";
            }
            else if (timer.ElapsedTicks == 0)
            {
                return "Reset";
            }
            else if (!(timer.ElapsedTicks == 0) && !timer.IsRunning)
            {
                return "Stopped";
            }
            return "Reset";
        }

        public Boolean isTimerFrozen()
        {
            return displayFrozen;
        }

        // Accessor/Mutator methods.

        private String getCurrentTimer()
        {
            Stopwatch sw = this.timer;
            return String.Format("{0:00}", sw.Elapsed.Minutes) + ":" +
                    String.Format("{0:00}", sw.Elapsed.Seconds) + ":" +
                    String.Format("{0:000}", sw.Elapsed.Milliseconds);
        }

        private String getCurrentDateTime()
        {
            return DateTime.Now.ToString("HH:mm:ss");
        }

        public String getCurrentDisplay()
        {
            if (currentMode == MODE.DateTime)
            {
                return getCurrentDateTime();
            }
            else if (currentMode == MODE.Timer)
            {
                if (displayFrozen)
                {
                    return frozenTime;
                }
                else if (!displayFrozen)
                {
                    return getCurrentTimer();
                }
                return "00:00:000";
            }
            return "00:00:00";
        }

        // main

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new stopwatchUI());
        }
    }
}
