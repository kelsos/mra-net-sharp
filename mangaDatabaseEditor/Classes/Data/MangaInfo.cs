using System;

namespace mangaDbEditor.Classes.Data
{
    public class MangaInfo
    {
        public string Title { get; set; }
        public int Id { get; set; }
        public DateTime? PublicationDate { get; set; }
        public string PublicationStatus { get; set; }
        public string Description { get; set; }
    }
}
