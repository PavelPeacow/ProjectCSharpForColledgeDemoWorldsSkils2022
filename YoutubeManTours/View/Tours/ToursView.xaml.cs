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
using Type = YoutubeManTours.Model.Type;
using YoutubeManTours.Coordinator;

namespace YoutubeManTours.View
{
    /// <summary>
    /// Interaction logic for ToursView.xaml
    /// </summary>
    public partial class ToursView : Window
    {

        private List<Tour> savedTours = new List<Tour>();
        private string selectedType;
        private string findedName;
        private User user;

        public ToursView()
        {
            InitializeComponent();

            ListTours.ItemsSource = DatabaseManager.shared.GetTours();

            cmbType.ItemsSource = DatabaseManager.shared.GetToursType();
            cmbType.SelectedIndex = 0;

            savedTours = DatabaseManager.shared.GetTours();
        }

        public void configure(User user)
        {
            DataContext = user;
            this.user = user;
            userImage.Source = new BitmapImage(new Uri("/Resources/photo.png", UriKind.Relative));
        }

        private void syncRefresh()
        {
            List<Tour> toursWithSelectedtype = DatabaseManager.shared.getToursByType(type: selectedType);

            if (selectedType == "Все типы")
                toursWithSelectedtype = DatabaseManager.shared.GetTours();

            savedTours = toursWithSelectedtype;

            if (textBoxSearch.Text != "")
                savedTours = DatabaseManager.shared.searchTourByName(inList: savedTours, byName: findedName);

            if ((bool)ChbActual.IsChecked)
                savedTours = DatabaseManager.shared.getActualTours(inList: savedTours);

            ListTours.ItemsSource = savedTours;
        }

        private void textBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            findedName = textBoxSearch.Text;

            syncRefresh();
        }

        private void cmbType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Type type = cmbType.SelectedItem as Type;
            selectedType = type.Name;
            syncRefresh();

            //Второй способ
            /* (from t in savedTours
              from tn in t.Types
              where tn.Name == selectedType
              select t).ToList();*/
        }

        private void ChbActual_Checked(object sender, RoutedEventArgs e)
        {
            syncRefresh();
        }

        private void ChbActual_Unchecked(object sender, RoutedEventArgs e)
        {
            syncRefresh();
        }

        private void goToHotelViewBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewCoordinator.shared.goToHotelView().ShowDialog();
        }

        private void ListTours_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Tour item = ListTours.SelectedItem as Tour;
            if (item == null) return;

            MessageBox.Show($"{item.Name}\n{item.FullPrice}\n{item.FullTicketCount}\n{item.State}", item.Name, MessageBoxButton.OK);
        }
    }
}
