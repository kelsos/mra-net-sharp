using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
