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
using YoutubeManTours.Database;
using YoutubeManTours.Model;

namespace YoutubeManTours.View.Hotels
{
    /// <summary>
    /// Interaction logic for HotelAddView.xaml
    /// </summary>
    public partial class HotelAddView : Window
    {
        private HotelView hotelView;
        public HotelAddView()
        {
            InitializeComponent();

            CmbNameCountry.ItemsSource = DatabaseManager.shared.getCountries();
            CmbNameCountry.SelectedIndex = 0;
        }

        public void configure(HotelView hotelView)
        {
            this.hotelView = hotelView;
        }
        private void BtnAddHotel_Click(object sender, RoutedEventArgs e)
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

            DatabaseManager.shared.addHotelToDB(TxtNameHotel.Text, countStars, TxtDescriptionHotel.Text, country);

            hotelView.refreshHotels();

            this.Close();
        }

        void addHotelToDB(string name, int stars, string description, Country county)
        {
            Hotel newHotel = new Hotel();
            newHotel.Name = name;
            newHotel.CountOfStars = stars;
            newHotel.Description = description;
            newHotel.Country = county;

            DatabaseManager.shared.entities.Hotels.AddObject(newHotel);
            DatabaseManager.shared.entities.SaveChanges();
        }
    }
}
