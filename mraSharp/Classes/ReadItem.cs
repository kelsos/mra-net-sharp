using System;

namespace mraSharp.Classes
{
    public class ReadItem
    {
        public string Title { get; set; }

        public int? StartingChapter { get; set; }

        public int? CurrentChapter { get; set; }

        public DateTime? LastRead { get; set; }

        public string OnlineUrl { get; set; }

        public bool? FinishedReading { get; set; }

        public string PersonalNote { get; set; }

        public ReadItem(string title, int? startingChapter, int? currentChapter, DateTime? lastRead,
                         string onlineUrl, bool? finishedReading)
        {
            Title = title;
            StartingChapter = startingChapter;
            CurrentChapter = currentChapter;
            LastRead = lastRead;
            OnlineUrl = onlineUrl;
            FinishedReading = finishedReading;
            PersonalNote = null;
        }

        public ReadItem(string title, int? startingChapter, int? currentChapter, DateTime? lastRead,
                         string onlineUrl, bool? finishedReading, string note)
        {
            Title = title;
            StartingChapter = startingChapter;
            CurrentChapter = currentChapter;
            LastRead = lastRead;
            OnlineUrl = onlineUrl;
            FinishedReading = finishedReading;
            PersonalNote = note;
        }

        public ReadItem(int? startingChapter, int? currentChapter, DateTime? lastRead, string onlineUrl,
                         bool? finishedReading, string personalNote)
        {
            Title = null;
            StartingChapter = startingChapter;
            CurrentChapter = currentChapter;
            LastRead = lastRead;
            OnlineUrl = onlineUrl;
            FinishedReading = finishedReading;
            PersonalNote = personalNote;
        }

        public ReadItem()
        {
            Title = null;
            StartingChapter = null;
            CurrentChapter = null;
            LastRead = null;
            OnlineUrl = null;
            FinishedReading = null;
            PersonalNote = null;
        }
    }
}