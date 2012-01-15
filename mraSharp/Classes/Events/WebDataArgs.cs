using System;

namespace mraNet.Classes.Events
{
    public class WebDataArgs : EventArgs
    {
        public WebDataArgs(string message, string navUrl)
        {
            Message = message;
            NavigateUrl = navUrl;
        }

        public string NavigateUrl { get; private set; }

        public string Message { get; private set; }
    }
}
