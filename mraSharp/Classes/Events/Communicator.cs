using System;
using mraNet.Classes.Data;

namespace mraNet.Classes.Events
{
    public sealed class Communicator
    {
        private static readonly Communicator ClassInstance = new Communicator();
        private ReadItem _readItemItem;
        public event EventHandler<WebDataArgs> WebDataAvailable;

        public void OnWebDataAvailable(Object sender, WebDataArgs e)
        {
            EventHandler<WebDataArgs> handler = WebDataAvailable;
            if (handler != null) handler(this, e);
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

