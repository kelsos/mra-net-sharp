using System;

namespace mranetwpf.Classes.Events
{
    public class WebDataArgs : EventArgs
    {
        public WebDataArgs(string message, string navUrl, string source)
        {
            Message = message;
            NavigateUrl = navUrl;
            Source = source;
        }

        public string NavigateUrl { get; private set; }

        public string Message { get; private set; }

        public string Source { get; private set; }
    }
}
