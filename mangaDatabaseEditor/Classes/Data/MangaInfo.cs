using System;

namespace mangaDbEditor.Classes.Data
{
    public class MangaInfo
    {
        public uint Id { get; set; }
        public string Title { get; set; }
        public DateTime? PublicationDate { get; set; }
        public string PublicationStatus { get; set; }
        public string Description { get; set; }
        public uint PublisherId { get; set; }
        public string Image { get; set; }

    }
}
