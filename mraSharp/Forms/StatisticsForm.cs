using System;
using System.Globalization;
using System.Windows.Forms;
using mraSharp.Classes;

namespace mraSharp.Forms
{
	public partial class StatisticsForm : Form
	{
		public StatisticsForm()
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