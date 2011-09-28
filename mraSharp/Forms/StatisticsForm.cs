using System;
using System.Windows.Forms;
using mraSharp.Classes;

namespace mraSharp.Forms
{
	public partial class StatisticsForm : Form
	{
		public StatisticsForm()
		{
			InitializeComponent();
			numberOfMangasReadTextBox.Text = DatabaseOperations.NumberOfMangasRead().ToString();
			numberOfChaptersReadTextBox.Text = DatabaseOperations.NumberOfChaptersRead().ToString();
			numberOfMangasFinishedTextBox.Text = DatabaseOperations.NumberofMangasFinished().ToString();
			dateILastReadTextBox.Text = Convert.ToDateTime(DatabaseOperations.DateILastRead()).ToShortDateString();
			daysSinceTextBox.Text = DatabaseOperations.DaysSinceILastRead().ToString();
		}
	}
}