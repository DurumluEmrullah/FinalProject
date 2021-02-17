using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            string operations = "Ürünleri Görüntülemek için 1\n" +
                             "Yeni ürün eklemk için 2\n" +
                             "Ürün silmek için 3\n" +
                             "Ürün güncellemek için 4\n" +
                             "Çıkmak için 0\'a basiniz ...";
            int seletctedOperation;
            List<Product> products;
            while (true)
            {
                Console.WriteLine("\n*********************************** \n");
                Console.WriteLine(operations);
                Console.WriteLine("\n*********************************** \n");
                seletctedOperation =int.Parse (Console.ReadLine());

                if(seletctedOperation == 1)
                {
                    products = productManager.GetAll();
                    foreach (var product in products)
                    {

                        Console.WriteLine("Ürün adi : " + product.ProductName + "\t|Fiyati : " + product.UnitPrice + "\t|Stok adedi : " + product.UnitsInStock);
                    }

                }
                else if(seletctedOperation == 2)
                {

                }
                else if (seletctedOperation == 3)
                {

                }
                else if(seletctedOperation == 4)
                {

                }
                else if(seletctedOperation ==0){
                    Console.WriteLine("Programdan çıkılıyor ....");
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı işlem ...\nLütfen tanımlı işlemlerden seçim yapınız ...\n");
                }


            }
        }
    }
}
