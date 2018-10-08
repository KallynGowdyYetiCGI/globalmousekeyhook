using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gma.System.MouseKeyHook
{
    public class KeyEventArgs : EventArgs
    {
        public KeyEventArgs(Keys keyData)
        {
            KeyCode = keyData;
        }

        public Keys KeyCode { get; set; }
        public bool Handled { get; set; }
    }
}
