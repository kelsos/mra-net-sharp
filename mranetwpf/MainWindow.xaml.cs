using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using mranetwpf.Classes;
using mranetwpf.Classes.Data;
using mranetwpf.Classes.Events;
using mranetwpf.Classes.Utilities;
using mranetwpf.Properties;

namespace mranetwpf
{
    /// <summary>
    ///   Interaction logic for MainWindow.xaml
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
            Communicator.Instance.ChapterFinished += HandleChapterFinished;
        }

        private void HandleChapterFinished(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void NewsStatusCheck()
        {
            if (!NetworkOperations.IsConnectivityAvailable())
            {
                if (!DatabaseWrapper.FeedDataExistInTheDatabase())
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
            listDataGrid.ItemsSource = DatabaseWrapper.GetReadingData(Settings.Default.DisplayFinished).DefaultView;

            if (listDataGrid.Columns.Count < 5)
                return;

            if (!Settings.Default.DisplayFinished && listDataGrid.Columns.Count == 6)
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

        private void LoadInfoForSelectedManga()
        {
            DataRowView dataRowView = listDataGrid.SelectedItem as DataRowView;
            if (dataRowView == null) return;
            DataRow dataRow = dataRowView.Row;
            coverDisplay.Source = DatabaseWrapper.GetMangaCover(dataRow[0].ToString());
            mangaDescriptionTextBlock.Text = DatabaseWrapper.GetMangaDescriptions(dataRow[0].ToString());
        }

        private void HandleListDataGridSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LoadInfoForSelectedManga();
        }

        private void HandleChapterFinishedButtonClick(object sender, RoutedEventArgs e)
        {
            DataRowView dataRowView = listDataGrid.SelectedItem as DataRowView;
            if (dataRowView == null) return;
            DataRow dataRow = dataRowView.Row;
            DatabaseWrapper.ChapterFinished(dataRow[0].ToString());
            (listDataGrid.SelectedItem as DataRowView).Row[2] = int.Parse(dataRow[2].ToString())+1;
            (listDataGrid.SelectedItem as DataRowView).Row[3] = DateTime.Now;
            //Send Info to Communicator Class.
        }

        private void HandleMainTabControlSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((mainTabControl.SelectedItem as TabItem) != wikiTab) return;
            DataRowView dataRowView = listDataGrid.SelectedItem as DataRowView;
            if (dataRowView == null) return;
            DataRow dataRow = dataRowView.Row;

            wikiWebBrowser.Navigate(string.Format("http://en.wikipedia.org/w/index.php?search={0}&go=Go",
                                                 RegularExpressions.WhiteSpaceToUrlEncoding(dataRow[0].ToString())));
        }

        private void HandleNavigateBackButtonClick(object sender, RoutedEventArgs e)
        {
            if(wikiWebBrowser.CanGoBack)
                wikiWebBrowser.GoBack();
        }

        private void HandleNavigateForwardButtonClick(object sender, RoutedEventArgs e)
        {
            if(wikiWebBrowser.CanGoForward)
                wikiWebBrowser.GoForward();
        }

        private void HandleReloadPageButtonClick(object sender, RoutedEventArgs e)
        {
            wikiWebBrowser.Refresh();
        }
    }
}