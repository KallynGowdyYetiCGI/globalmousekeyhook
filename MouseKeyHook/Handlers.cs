using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gma.System.MouseKeyHook
{
    public delegate void MouseEventHandler(object sender, MouseEventArgs args);

    public delegate void KeyPressEventHandler(object sender, KeyPressEventArgs args);

    public delegate void KeyEventHandler(object sender, KeyEventArgsExt args);
}
