using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using YoutubeManTours.Coordinator;
using YoutubeManTours.Database;
using YoutubeManTours.Model;

namespace YoutubeManTours.View
{
    /// <summary>
    /// Interaction logic for HotelView.xaml
    /// </summary>
    public partial class HotelView : Window
    {

        private int currentPage = 1;
        private int maxPage = 0;

        public HotelView()
        {
            InitializeComponent();

            refreshHotels();
        }

        public void refreshHotels()
        {
            DataGridHotels.ItemsSource = DatabaseManager.shared.getHotels();
            maxPage = Convert.ToInt32(Math.Ceiling(DatabaseManager.shared.getHotels().Count * 1.0 / 10));

            var listHotels = DatabaseManager.shared.getCountriesByPage(currentPage);

            LblTotalPages.Content = "of " + maxPage.ToString();
            TxtCurrentPageNumber.Text = currentPage.ToString();
            DataGridHotels.ItemsSource = listHotels;
        }

        private void TxtCurrentPageNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TxtCurrentPageNumber.Text == "") return;

            if (currentPage > 0 && currentPage < maxPage)
            {
                currentPage = Convert.ToInt32(TxtCurrentPageNumber.Text);
                refreshHotels();
            }
               
        }

        private void GoFirstPageButton_Click(object sender, RoutedEventArgs e)
        {
            currentPage = 1;
            refreshHotels();
        }

        private void GoPrevPageButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentPage - 1 < 1) return;

            currentPage= currentPage - 1;
            refreshHotels();
        }

        private void GoNextPageButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentPage + 1 > maxPage) return;

            currentPage = currentPage + 1;
            refreshHotels();
        }

        private void GoLastPageButton_Click(object sender, RoutedEventArgs e)
        {
            currentPage = maxPage;
            refreshHotels();
        }

        private void BtnEditHotelInfo_Click(object sender, RoutedEventArgs e)
        {
            var hotel = (sender as Button).DataContext as Hotel;
            ViewCoordinator.shared.goToHotelEditInfoView(fromView: this, hotel: hotel).ShowDialog();
        }

        private void AddNewHotelButton_Click(object sender, RoutedEventArgs e)
        {
            ViewCoordinator.shared.goToHotelAddView(fromView: this).ShowDialog();
        }
    }
}
