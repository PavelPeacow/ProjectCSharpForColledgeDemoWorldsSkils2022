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
using System.Windows.Navigation;
using System.Windows.Shapes;
using YoutubeManTours.Database;
using YoutubeManTours.View;
using YoutubeManTours.Coordinator;

namespace YoutubeManTours.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class AuthView : Window
    {
        public AuthView()
        {
            InitializeComponent();
        }

        private void signInBtn_Click(object sender, RoutedEventArgs e)
        {
            var user = DatabaseManager.shared.getUser(emailBox.Text, passwordBox.Text);

            if (user == null)
            {
                MessageBox.Show("Не найден пользователь", "Ошибка авторизации", MessageBoxButton.OK);
                return;
            }

            ViewCoordinator.shared.goToToursView(user).Show();
            this.Close();
        }
    }
}
