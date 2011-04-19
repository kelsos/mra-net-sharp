using System;
using System.Windows.Forms;

namespace mraSharp
{
	public partial class StatisticsForm : Form
	{
		public StatisticsForm()
		{
			InitializeComponent();
			numberOfMangasReadTextBox.Text = DatabaseOperations.numberOfMangasRead().ToString();
			numberOfChaptersReadTextBox.Text = DatabaseOperations.numberOfChaptersRead().ToString();
			numberOfMangasFinishedTextBox.Text = DatabaseOperations.numberofMangasFinished().ToString();
			dateILastReadTextBox.Text = Convert.ToDateTime(DatabaseOperations.dateILastRead()).ToShortDateString();
			daysSinceTextBox.Text = DatabaseOperations.daysSinceILastRead().ToString();
		}
	}
}