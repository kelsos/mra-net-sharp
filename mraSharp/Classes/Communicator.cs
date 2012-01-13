using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mraSharp.Classes
{
    public sealed class Communicator
    {
        private static readonly Communicator _instance = new Communicator();
        private ReadItem _readItemItem;

        static Communicator()
        {

        }

        private Communicator()
        {

        }

        public static Communicator Instance
        {
            get { return _instance; }
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

