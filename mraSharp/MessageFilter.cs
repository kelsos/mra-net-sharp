using System;
using System.Windows.Forms;

namespace mraSharp
{
	/// <summary>
	/// A Message Filter
	/// </summary>
	public class MessageFilter : IMessageFilter
	{
		const int WM_XBUTTONDOWN = 0x020B;
		const int MK_XBUTTON1 = 65568;
		const int MK_XBUTTON2 = 131136;

		private Form _form;
		private EventHandler _backevent;
		private EventHandler _forwardevent;

		/// <summary>
		/// Initializes a new instance of the <see cref="MessageFilter"/> class.
		/// </summary>
		/// <param name="f">The form.</param>
		/// <param name="backevent">The backevent.</param>
		/// <param name="forwardevent">The forwardevent.</param>
		public MessageFilter(WebForm f, ref EventHandler backevent, ref EventHandler forwardevent)
		{
			_form = f;
			_backevent = backevent;
			_forwardevent = forwardevent;
		}

		/// <summary>
		/// Filters out a message before it is dispatched.
		/// </summary>
		/// <param name="m">The message to be dispatched. You cannot modify this message.</param>
		/// <returns>
		/// true to filter the message and stop it from being dispatched; false to allow the message to continue to the next filter or control.
		/// </returns>
		public bool PreFilterMessage(ref Message m)
		{
			bool bHandled = false;

			if (m.Msg == WM_XBUTTONDOWN)
			{
				int w = m.WParam.ToInt32();
				if (w == MK_XBUTTON1)
				{
					_backevent.Invoke(_form, EventArgs.Empty);
					bHandled = true;
				}
				else if (w == MK_XBUTTON2)
				{
					_forwardevent.Invoke(_form, EventArgs.Empty);
					bHandled = true;
				}
			}
			return bHandled;
		}
	}
}
