using System;
using mraNet.Classes.Data;

namespace mraNet.Classes.Events
{
    public sealed class Communicator
    {
        private static readonly Communicator ClassInstance = new Communicator();
        private ReadItem _readItemItem;
        public String URL { get; set; }
        public event EventHandler<WebDataArgs> WebDataAvailable;

        public void OnWebDataAvailable(Object sender, WebDataArgs e)
        {
            if (WebDataAvailable != null) WebDataAvailable(sender, e);
        }

        public event EventHandler ChapterFinished;

        public void OnChapterFinished(Object sender, EventArgs e)
        {
            if (ChapterFinished != null) ChapterFinished(sender, e);
        }

        static Communicator()
        {
        }

        private Communicator()
        {
        }

        public static Communicator Instance
        {
            get { return ClassInstance; }
        }

        public void SetReadItem(ReadItem readItemItem)
        {
            _readItemItem = readItemItem;
        }

        public void ClearReadItem()
        {
            _readItemItem = null;
        }

        public ReadItem GetReadItem()
        {
            return _readItemItem;
        }
    }
}