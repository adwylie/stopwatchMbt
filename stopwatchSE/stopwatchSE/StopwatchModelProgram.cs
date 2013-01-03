using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using Microsoft.Modeling;

namespace stopwatchSE
{
    [TypeBinding("stopwatchImp.StopwatchCS")]
    class StopwatchModelProgram
    {
        public enum TimerMode { Reset, Running, Stopped }

        // We have two display modes; date & time mode and timer mode.
        bool timerDisplayed;

        // We can have the timer running whilst its display is frozen.
        bool timerFrozen;

        // And we keep track of the timer mode.
        TimerMode timerMode;

        [Rule(Action = "new this.StopwatchCS()")]
        StopwatchModelProgram()
        {
            // We begin be initializing the system with the time showing,
            // the timer reset and not frozen.
            timerDisplayed = false;
            timerFrozen = false;
            timerMode = TimerMode.Reset;
        }

        [Rule(Action = "this.modeButton()")]
        void modeButton()
        {
            timerDisplayed = !timerDisplayed;
        }

        [Rule(Action = "this.startStopButton()")]
        void startStopButton()
        {
            // For the stop/start button to do anything the watch needs to be
            // in timer mode.
            Condition.IsTrue(timerDisplayed);

            // If the watch is in timer mode and the start/stop button is
            // pressed then the timer is either started or stopped depending
            // on its previous state.
            if (timerMode == TimerMode.Reset || timerMode == TimerMode.Stopped)
            {
                timerMode = TimerMode.Running;
            }
            else
            {
                timerMode = TimerMode.Stopped;

                // When we stop the timer we want the current timed duration
                // to be seen, so we unfreeze the display.
                timerFrozen = false;
            }
        }

        [Rule(Action = "this.resetLapButton()")]
        void resetLapButton()
        {
            // For the reset/lap button to do anything the watch needs to be
            // in timer mode. The timer must also not be currently reset in
            // order to be reset.
            Condition.IsTrue(timerDisplayed);
            Condition.IsTrue(timerMode != TimerMode.Reset);

            // If the timer is running then we freeze/unfreeze the display. If
            // the timer is stopped then we reset the timer.
            if (timerMode == TimerMode.Stopped)
            {
                timerMode = TimerMode.Reset;
            }
            else
            {
                timerFrozen = !timerFrozen;
            }
        }

        // Rules which can be run at any time which check current state.
        [Rule(Action = "this.getMode()/result")]
        string getMode()
        {
            return timerDisplayed ? "Timer" : "DateTime";
        }

        [Rule(Action = "this.getTimerState()/result")]
        string getTimerState()
        {
            return timerMode.ToString();
        }

        [Rule(Action = "this.isTimerFrozen()/result")]
        bool isTimerFrozen()
        {
            return timerFrozen;
        }

    }

}
