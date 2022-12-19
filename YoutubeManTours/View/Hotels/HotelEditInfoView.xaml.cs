using System;
using System.Collections;
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
using System.Xml.Linq;
using YoutubeManTours.Database;
using YoutubeManTours.Model;

namespace YoutubeManTours.View
{
    /// <summary>
    /// Interaction logic for HotelEditInfoView.xaml
    /// </summary>
    public partial class HotelEditInfoView : Window
    {
        private HotelView hotelView;
        private Hotel hotel;

        public HotelEditInfoView()
        {
            InitializeComponent();

            CmbNameCountry.ItemsSource = DatabaseManager.shared.getCountries();

        }

        public void configure(HotelView hotelView, Hotel hotel)
        {
            this.hotelView = hotelView;
            this.hotel = hotel;

            TxtNameHotel.Text = hotel.Name;
            TxtCountStars.Text = Convert.ToString(hotel.CountOfStars);
            TxtDescriptionHotel.Text = hotel.Description;

            CmbNameCountry.SelectedItem = hotel.Country;
        }

        private void BtnDeleteHotel_Click(object sender, RoutedEventArgs e)
        {
            DatabaseManager.shared.entities.Hotels.DeleteObject(this.hotel);
            DatabaseManager.shared.entities.SaveChanges();

            hotelView.refreshHotels();

            this.Close();
        }

        private void BtnUpdateHotel_Click(object sender, RoutedEventArgs e)
        {

            int countStars;
            Country country = CmbNameCountry.SelectedItem as Country;

            try
            {
                if (TxtNameHotel.Text == "")
                {
                    MessageBox.Show("Имя отеля не может быть пустым");
                    return;
                }

                countStars = Convert.ToInt32(TxtCountStars.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Введите число");
                return;
            }

            DatabaseManager.shared.updateHotel(hotel, TxtNameHotel.Text, countStars, TxtDescriptionHotel.Text, country);

            hotelView.refreshHotels();

            this.Close();
        }

    }
}
