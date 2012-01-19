using System;

namespace mranetwpf.Classes.Data
{
    class DisplayReadItem
    {
        public string Title { get; set; }

        public int? StartingChapter { get; set; }

        public int? CurrentChapter { get; set; }

        public DateTime? LastRead { get; set; }

        public string OnlineUrl { get; set; }

        public bool? FinishedReading { get; set; }
    }
}
