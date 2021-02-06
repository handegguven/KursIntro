using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product) // bu aynı string ad gibi bu buraya atanacak.
            //Bu bizim methodumuzun cnasıl cagrılacagını anlattıgı . Benim adım add bana product turunde bisey ver.
        {
            Console.WriteLine(product.ProductName + " Eklendi." );
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " Güncellendi.");
        }

        public int Topla(int sayi1, int sayi2) //burada diyorum ki sen sayi 1 ile sayi 2 yi
            //topla bana int tipinde bir değer ver.
        {
            return sayi1 + sayi2;
        }

        public void Topla2(int sayi1, int sayi2) //bunda void toplamayi yapar ve biter.
            //ben o degeri tekrar bir yerde kullanamam.
        {
            Console.WriteLine(sayi1 + sayi2);
        }

    }

}
