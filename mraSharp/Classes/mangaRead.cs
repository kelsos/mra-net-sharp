using System;

namespace mraSharp.Classes
{
	public class MangaRead
	{
	    public string Title { get; set; }

	    public double? StartingChapter { get; set; }

	    public double? CurrentChapter { get; set; }

	    public DateTime? LastRead { get; set; }

	    public string OnlineURL { get; set; }

	    public bool? FinishedReading { get; set; }

	    public string PersonalNote { get; set; }

	    public MangaRead(string title, double? startingChapter, double? currentChapter, DateTime? lastRead, string onlineURL, bool? finishedReading)
		{
			Title = title;
			StartingChapter = startingChapter;
			CurrentChapter = currentChapter;
			LastRead = lastRead;
			OnlineURL = onlineURL;
			FinishedReading = finishedReading;
         PersonalNote = null;
		}

		public MangaRead(string title, double? startingChapter, double? currentChapter, DateTime? lastRead, string onlineURL, bool? finishedReading, string note)
		{
			Title = title;
			StartingChapter = startingChapter;
			CurrentChapter = currentChapter;
			LastRead = lastRead;
			OnlineURL = onlineURL;
			FinishedReading = finishedReading;
			PersonalNote = note;
		}

      public MangaRead(double? startingChapter, double? currentChapter, DateTime? lastRead, string onlineURL, bool? finishedReading, string personalNote)
      {
         Title = null;
         StartingChapter = startingChapter;
         CurrentChapter = currentChapter;
         LastRead = lastRead;
         OnlineURL = onlineURL;
         FinishedReading = finishedReading;
         PersonalNote = personalNote;
      }

      public MangaRead()
      {
         Title = null;
         StartingChapter = null;
         CurrentChapter = null;
         LastRead = null;
         OnlineURL = null;
         FinishedReading = null;
         PersonalNote = null;
      }
	}
}