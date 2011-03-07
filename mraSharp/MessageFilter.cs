using System;
using System.Windows.Forms;

namespace mraSharp
{
	public class MessageFilter : IMessageFilter
	{
		const int WM_XBUTTONDOWN = 0x020B;
		const int MK_XBUTTON1 = 65568;
		const int MK_XBUTTON2 = 131136;

		private Form _form;
		private EventHandler _backevent;
		private EventHandler _forwardevent;

		public MessageFilter(WebForm f, ref EventHandler backevent, ref EventHandler forwardevent)
		{
			_form = f;
			_backevent = backevent;
			_forwardevent = forwardevent;
		}

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
   
