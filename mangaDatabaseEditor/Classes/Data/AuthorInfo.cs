﻿using System;

namespace mangaDbEditor.Classes.Data
{
    public class AuthorInfo
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public DateTime? Birthday { get; set; }
        public string Website { get; set; }
    }
}
