using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gma.System.MouseKeyHook
{
	public delegate void KeyEventHandler(object sender, KeyEventArgs e);
	public delegate void KeyPressEventHandler(object sender, KeyPressEventArgs e);
	public delegate void MouseEventHandler(object sender, MouseEventArgs e);
}
