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

namespace MobileAppUsageDashboard
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, RoutedEventArgs e) {
            MainHost.IsLeftDrawerOpen = false;
            radio1.IsChecked = true;
            radio2.IsChecked = false;
            radio3.IsChecked = false;
        }

        private void Btn2_Click(object sender, RoutedEventArgs e) {
            MainHost.IsLeftDrawerOpen = false;
            radio1.IsChecked = false;
            radio2.IsChecked = true;
            radio3.IsChecked = false;
        }

        private void Btn3_Click(object sender, RoutedEventArgs e) {
            MainHost.IsLeftDrawerOpen = false;
            radio1.IsChecked = false;
            radio2.IsChecked = false;
            radio3.IsChecked = true;
        }

        private void Card_MouseUp(object sender, MouseButtonEventArgs e) {
            try {
                this.DragMove();
            }
            catch (Exception) {

                throw;
            }
           
        }
    }
}
