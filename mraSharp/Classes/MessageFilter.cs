using System;
using System.Windows.Forms;
using mraSharp.Forms;

namespace mraSharp.Classes
{
    /// <summary>
    /// A Message Filter
    /// </summary>
    public class MessageFilter : IMessageFilter
    {
        private const int WM_XBUTTONDOWN = 0x020B;
        private const int MK_XBUTTON1 = 65568;
        private const int MK_XBUTTON2 = 131136;

        private readonly Form _form;
        private readonly EventHandler _backevent;
        private readonly EventHandler _forwardevent;

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageFilter"/> class.
        /// </summary>
        /// <param name="f">The form.</param>
        /// <param name="backevent">The backevent.</param>
        /// <param name="forwardevent">The forwardevent.</param>
        public MessageFilter(Form f, ref EventHandler backevent, ref EventHandler forwardevent)
        {
            if (f == null) throw new ArgumentNullException("f");
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
            var bHandled = false;

            if (m.Msg == WM_XBUTTONDOWN)
            {
                var w = m.WParam.ToInt32();
                switch (w)
                {
                    case MK_XBUTTON1:
                        _backevent.Invoke(_form, EventArgs.Empty);
                        bHandled = true;
                        break;
                    case MK_XBUTTON2:
                        _forwardevent.Invoke(_form, EventArgs.Empty);
                        bHandled = true;
                        break;
                }
            }
            return bHandled;
        }
    }
}