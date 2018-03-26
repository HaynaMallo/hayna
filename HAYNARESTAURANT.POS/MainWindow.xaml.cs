using HAYNARESTAURANT.Domain.Models;
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
using HAYNARESTAURANT.Domain.BBL;

namespace HAYNARESTAURANT.POS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnUsers_Click(object sender, RoutedEventArgs e)
        {
            User.List userWindow = new User.List();
            userWindow.Show();
            
        }

        private void btnCategory_Click(object sender, RoutedEventArgs e)
        {
            Category.List categoryWindow = new Category.List();
            categoryWindow.Show();
        }

        private void btnProducts_Click(object sender, RoutedEventArgs e)
        {
            Products.List productWindow = new Products.List();
            productWindow.Show();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Delivery.List deliveryWindow = new Delivery.List();
            deliveryWindow.Show();
        }
    }
}
