using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Toolbar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (LoginBox.Text == "root" && PasswordBox.Password == "IWR224")
            {
                ProcessWin taskWindow = new ProcessWin();
                taskWindow.Show();
                this.Close();
            }
            else NeverLogin.Visibility = Visibility.Visible;
            LoginBox.BorderBrush = Brushes.Red;
            PasswordBox.BorderBrush = Brushes.Red;
        }

        private void LoginBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            NeverLogin.Visibility = Visibility.Hidden;
            LoginBox.BorderBrush = new SolidColorBrush(Color.FromRgb(30, 94, 151));
            PasswordBox.BorderBrush = new SolidColorBrush(Color.FromRgb(30, 94, 151));
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            NeverLogin.Visibility = Visibility.Hidden;
            LoginBox.BorderBrush = new SolidColorBrush(Color.FromRgb(30, 94, 151));
            PasswordBox.BorderBrush = new SolidColorBrush(Color.FromRgb(30, 94, 151));
        }
    }
}
