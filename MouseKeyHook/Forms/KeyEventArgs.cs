using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gma.System.MouseKeyHook
{
	/// <summary>Provides data for the <see cref="E:System.Windows.Forms.Control.KeyDown" /> or <see cref="E:System.Windows.Forms.Control.KeyUp" /> event.</summary>
	public class KeyEventArgs : EventArgs
	{
		private readonly Keys keyData;
		private bool handled;
		private bool suppressKeyPress;
		/// <summary>Gets a value indicating whether the ALT key was pressed.</summary>
		/// <returns>true if the ALT key was pressed; otherwise, false.</returns>
		/// <filterpriority>1</filterpriority>
		public virtual bool Alt
		{
			get
			{
				return (this.keyData & Keys.Alt) == Keys.Alt;
			}
		}
		/// <summary>Gets a value indicating whether the CTRL key was pressed.</summary>
		/// <returns>true if the CTRL key was pressed; otherwise, false.</returns>
		/// <filterpriority>1</filterpriority>
		public bool Control
		{
			get
			{
				return (this.keyData & Keys.Control) == Keys.Control;
			}
		}
		/// <summary>Gets or sets a value indicating whether the event was handled.</summary>
		/// <returns>true to bypass the control's default handling; otherwise, false to also pass the event along to the default control handler.</returns>
		/// <filterpriority>1</filterpriority>
		public bool Handled
		{
			get
			{
				return this.handled;
			}
			set
			{
				this.handled = value;
			}
		}
		/// <summary>Gets the keyboard code for a <see cref="E:System.Windows.Forms.Control.KeyDown" /> or <see cref="E:System.Windows.Forms.Control.KeyUp" /> event.</summary>
		/// <returns>A <see cref="T:System.Windows.Forms.Keys" /> value that is the key code for the event.</returns>
		/// <filterpriority>1</filterpriority>
		public Keys KeyCode
		{
			get
			{
				Keys keys = this.keyData & Keys.KeyCode;
				if (!Enum.IsDefined(typeof(Keys), (int)keys))
				{
					return Keys.None;
				}
				return keys;
			}
		}
		/// <summary>Gets the keyboard value for a <see cref="E:System.Windows.Forms.Control.KeyDown" /> or <see cref="E:System.Windows.Forms.Control.KeyUp" /> event.</summary>
		/// <returns>The integer representation of the <see cref="P:System.Windows.Forms.KeyEventArgs.KeyCode" /> property.</returns>
		/// <filterpriority>1</filterpriority>
		public int KeyValue
		{
			get
			{
				return (int)(this.keyData & Keys.KeyCode);
			}
		}
		/// <summary>Gets the key data for a <see cref="E:System.Windows.Forms.Control.KeyDown" /> or <see cref="E:System.Windows.Forms.Control.KeyUp" /> event.</summary>
		/// <returns>A <see cref="T:System.Windows.Forms.Keys" /> representing the key code for the key that was pressed, combined with modifier flags that indicate which combination of CTRL, SHIFT, and ALT keys was pressed at the same time.</returns>
		/// <filterpriority>1</filterpriority>
		public Keys KeyData
		{
			get
			{
				return this.keyData;
			}
		}
		/// <summary>Gets the modifier flags for a <see cref="E:System.Windows.Forms.Control.KeyDown" /> or <see cref="E:System.Windows.Forms.Control.KeyUp" /> event. The flags indicate which combination of CTRL, SHIFT, and ALT keys was pressed.</summary>
		/// <returns>A <see cref="T:System.Windows.Forms.Keys" /> value representing one or more modifier flags.</returns>
		/// <filterpriority>1</filterpriority>
		public Keys Modifiers
		{
			get
			{
				return this.keyData & Keys.Modifiers;
			}
		}
		/// <summary>Gets a value indicating whether the SHIFT key was pressed.</summary>
		/// <returns>true if the SHIFT key was pressed; otherwise, false.</returns>
		/// <filterpriority>1</filterpriority>
		public virtual bool Shift
		{
			get
			{
				return (this.keyData & Keys.Shift) == Keys.Shift;
			}
		}
		/// <summary>Gets or sets a value indicating whether the key event should be passed on to the underlying control.</summary>
		/// <returns>true if the key event should not be sent to the control; otherwise, false.</returns>
		public bool SuppressKeyPress
		{
			get
			{
				return this.suppressKeyPress;
			}
			set
			{
				this.suppressKeyPress = value;
				this.handled = value;
			}
		}
		/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.KeyEventArgs" /> class.</summary>
		/// <param name="keyData">A <see cref="T:System.Windows.Forms.Keys" /> representing the key that was pressed, combined with any modifier flags that indicate which CTRL, SHIFT, and ALT keys were pressed at the same time. Possible values are obtained be applying the bitwise OR (|) operator to constants from the <see cref="T:System.Windows.Forms.Keys" /> enumeration. </param>
		public KeyEventArgs(Keys keyData)
		{
			this.keyData = keyData;
		}
	}
}
