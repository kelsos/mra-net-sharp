﻿using mraSharp.Forms;

namespace mraSharp.Classes
{
    internal class DataPasser
    {
        public DataPasser(MainForm form, string filepath)
        {
            Form = form;
            FilePath = filepath;
        }

        public MainForm Form { get; set; }

        public string FilePath { get; set; }
    }
}