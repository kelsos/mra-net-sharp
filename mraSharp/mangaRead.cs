using System;

namespace mraSharp
{
	class mangaRead
	{
		private string _title;
		private double? _startingChapter;
		private double? _currentChapter;
		private DateTime? _lastRead;
		private string _onlineURL;
		private bool? _finishedReading;

		public string Title
		{
			get { return _title; }
			set { _title = value; }
		}

		public double? StartingChapter
		{
			get { return _startingChapter; }
			set { _startingChapter = value; }
		}

		public double? CurrentChapter
		{
			get { return _currentChapter; }
			set { _currentChapter = value; }
		}

		public DateTime? LastRead
		{
			get { return _lastRead; }
			set { _lastRead = value; }
		}

		public string OnlineURL
		{
			get { return _onlineURL; }
			set { _onlineURL = value; }
		}

		public bool? FinishedReading
		{
			get { return _finishedReading; }
			set { _finishedReading = value; }
		}

		public mangaRead(string title, double? startingChapter, double? currentChapter, DateTime? lastRead, string onlineURL, bool? finishedReading)
		{
			_title = title;
			_startingChapter = startingChapter;
			_currentChapter = currentChapter;
			_lastRead = lastRead;
			_onlineURL = onlineURL;
			_finishedReading = finishedReading;
		}


	}
}
