using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows;
using System.Windows.Documents;
using System.Collections.ObjectModel;


namespace MagazynApp
{
    public partial class AddWindow : Window
    {
        private MainWindow mainWindow = null;
        private Product newProduct;

        public AddWindow()
        {
            InitializeComponent();
            Function();
        }

        public AddWindow (MainWindow mainWin)
        {
            InitializeComponent();
            Function();
           mainWindow = mainWin;
        }

        private void Function ()
        {
         
            newProduct = new Product(1,"",0,"");
            newProd.DataContext = newProduct;
           



        }

        private void btAccept_Click(object sender, RoutedEventArgs e)
        {

            mainWindow.List.Add(newProduct);
            Close();
            
            
            
        }

        private void btCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
