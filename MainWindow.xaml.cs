using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
using System.Xml.Serialization;

namespace MagazynApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        internal ObservableCollection<Product> List = null;

        public MainWindow()
        {
            InitializeComponent();
            Function();
        }



        private void Function()
        {
            List = new ObservableCollection<Product>();
            Depot.ItemsSource = List;
        }

       

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            AddWindow win = new AddWindow(this);
            win.ShowDialog();
        }

        private void btDelete_Click(object sender, RoutedEventArgs e)
        {
            Product p = Depot.SelectedItem as Product;
            MessageBoxResult question = MessageBox.Show("Czy na pewno skasować?", "Pytanie", MessageBoxButton.YesNo);
            if (question == MessageBoxResult.Yes)
            {
                List.Remove(p);
            }
        }

        private void btSav_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Product>));
                Stream stream2 = new FileStream(@"..\..\Data\prod.xml", FileMode.Create, FileAccess.Write, FileShare.None);
                serializer.Serialize(stream2, List);
                stream2.Close();
                MessageBox.Show("Dane zostały zapisane!");
            }
            catch(Exception)
            {
                MessageBox.Show("Nie można zapisać danych!");
            }
        }


        private void btLoad_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(ObservableCollection<Product>));
                Stream stream2 = new FileStream(@"..\..\Data\prod.xml", FileMode.Open,
                    FileAccess.Read, FileShare.None);
                List = (ObservableCollection<Product>)deserializer.Deserialize(stream2);
                Depot.ItemsSource = List;
                stream2.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Nie można wczytać pliku!");
            }
        }

        private void btEdit_Click(object sender, RoutedEventArgs e)
        {
            EditWindow win = new EditWindow(this);
            win.ShowDialog();
        }
    }
}
