using System;
using System.Globalization;
using System.Windows.Forms;
using mraNet.Classes;

namespace mraNet.Forms
{
	public partial class StatisticsWindow : Form
	{
		public StatisticsWindow()
		{
			InitializeComponent();
			numberOfMangasReadTextBox.Text = DatabaseWrapper.GetNumberOfMangasRead().ToString(CultureInfo.InvariantCulture);
			numberOfChaptersReadTextBox.Text = DatabaseWrapper.GetNumberOfChaptersRead().ToString(CultureInfo.InvariantCulture);
			numberOfMangasFinishedTextBox.Text = DatabaseWrapper.NumberofMangasFinished().ToString();
			dateILastReadTextBox.Text = Convert.ToDateTime(DatabaseWrapper.DateILastRead()).ToShortDateString();
			daysSinceTextBox.Text = DatabaseWrapper.DaysSinceILastRead().ToString(CultureInfo.InvariantCulture);
		}
	}
}