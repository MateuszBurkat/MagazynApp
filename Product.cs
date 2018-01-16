using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazynApp
{
   public class Product
    {
        private Product newProduct;

        public int ID { get; set; }
        public string Nazwa { get; set; }
        public int LiczbaSztuk { get; set; }
        public string Lokalizacja { get; set; }

        public Product(int I, string Naz, int Liczba, string Lok)
        {
            ID = I;
            Nazwa = Naz;
            LiczbaSztuk = Liczba;
            Lokalizacja = Lok;
        }

        public Product()
        {

        }

        public Product(Product newProduct)
        {
            this.newProduct = newProduct;
        }
    }
}
