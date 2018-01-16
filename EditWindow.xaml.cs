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

namespace MagazynApp
{
    /// <summary>
    /// Interaction logic for EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {

        private MainWindow mainWindow = null;

        public EditWindow()
        {
            InitializeComponent();
        }
        public EditWindow(MainWindow mainW)
        {
            InitializeComponent();
            mainWindow = mainW;
            Function();
        }

        private void Function()
        {
            Product p = mainWindow.Depot.SelectedItem as Product;

            if (p != null)
            {
                editProd.DataContext = p;
            }
        }

        private void btAccept_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
