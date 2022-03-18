using System;

namespace OPP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.ProductName = " Masa ";
            product1.CategoryId = 1;
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;


            Product product2 = new Product  // < - Dizi
            {
                ProductName = "Kalem", Id = 3 , UnitPrice = 300 , CategoryId = 4 , UnitsInStock = 51
            };
            // PascalCase -camelCase
            // Case Sensitive
            // stack      - heap
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Add(product2);

            int toplamaSonucu = productManager.Topla(3,9);

            Console.WriteLine(toplamaSonucu*2);

            // int , double , bool  > Deger Tip
            // class , array , abstract class , interface > Referans tip
            // ref - aut
            // void  -> git yap bitir
        }
    }
}