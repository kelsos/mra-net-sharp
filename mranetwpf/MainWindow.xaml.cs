using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using mranetwpf.Classes;
using mranetwpf.Classes.Data;
using mranetwpf.Classes.Events;
using mranetwpf.Classes.Utilities;
using mranetwpf.Properties;

namespace mranetwpf
{

    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _newsTickerCounter;
        private bool _isInternetConnectionAvailable;
        
        public MainWindow()
        {
            InitializeComponent();
            _newsTickerCounter = 0;

            displayFinishedMenuItem.IsChecked = Settings.Default.DisplayFinished;
           Communicator.Instance.ChapterFinished +=HandleChapterFinished;
        }

        private void HandleChapterFinished(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void NewsStatusCheck()
        {
            if(!NetworkOperations.IsConnectivityAvailable())
            {
                if(!DatabaseWrapper.FeedDataExistInTheDatabase())
                {
                    //Tick timer.enable
                    //News Check Timer.enable
                    //Status Label,Text = No COnnection Available
                }
                else
                {
                    ClearNewsItemDisplay();
                    //status=no connection.
                    //tickTimer.disable
                    //news check.disable;
                }
            }
            else
            {
                ClearNewsItemDisplay();
                //checktimer=true
                //run fetching thread.. if fetching thread has new entries refresh the list

            }
        }

        private void ClearNewsItemDisplay()
        {
            newsTitleLabel.Content = "";
            newsDescriptionTextBlock.Text = "";
            newsUrlLabel.Content = "";
        }

        private List<NewsItem> _newsList;
        private void NewsTicker(string action)
        {
            if (_newsList == null)
                _newsList = DatabaseWrapper.GetNewsItemList();
            try
            {
                int newsItemsCount = _newsList.Count();
                if (newsItemsCount <= 0)
                    return;
                if (string.IsNullOrEmpty(action))
                {
                    if (newsItemsCount > _newsTickerCounter)
                    {
                        UpdateNewsItemDisplay(_newsList[_newsTickerCounter]);
                        _newsTickerCounter += 1;
                    }
                    else
                    {
                        UpdateNewsItemDisplay(_newsList[_newsTickerCounter]);
                        _newsTickerCounter += 1;
                    }
                }
                else
                {
                    if (_newsTickerCounter > 0)
                    {
                        UpdateNewsItemDisplay(_newsList[_newsTickerCounter]);
                        _newsTickerCounter -= 1;
                    }
                    else
                    {
                        UpdateNewsItemDisplay(_newsList[_newsTickerCounter]);
                        _newsTickerCounter -= 1;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.HandleException(ex);
            }
        }

        protected void UpdateNewsItemDisplay(NewsItem item)
        {
            newsTitleLabel.Content = item.Title;
            newsUrlLabel.Content = item.Link;
            newsDescriptionTextBlock.Text = item.Description;
        }

        private void HandleDisplayFinishedClick(object sender, RoutedEventArgs e)
        {
            Settings.Default.DisplayFinished = !Settings.Default.DisplayFinished;
            //datagrid remove last -
        }

        private void LoadReadingListToDataGrid()
        {
            listDataGrid.ItemsSource = DatabaseWrapper.GetReadingData(Settings.Default.DisplayFinished);

            if(listDataGrid.Columns.Count<5)
                return;
            
            if (!Settings.Default.DisplayFinished&&listDataGrid.Columns.Count==6)
            {
                listDataGrid.Columns[5].Visibility = Visibility.Hidden;
            }
            else
            {
                listDataGrid.Columns[5].Visibility = Visibility.Visible;
            }
            //Code for column count
        }

        private void HandleWindowLoaded(object sender, RoutedEventArgs e)
        {
            LoadReadingListToDataGrid();
        }

        private void HandleReloadButtonClick(object sender, RoutedEventArgs e)
        {
            LoadReadingListToDataGrid();
        }
    }
}
