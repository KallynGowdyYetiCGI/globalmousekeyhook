using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gma.System.MouseKeyHook
{
    public class MouseEventArgs : EventArgs
    {
        public MouseEventArgs(MouseButtons buttons, int clicks, int x, int y, int delta)
        {
            Button = buttons;
            Clicks = clicks;
            X = x;
            Y = y;
            Delta = delta;
        }

        public MouseButtons Button { get; set; }
        public int Clicks { get; set; }
        public int Delta { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
