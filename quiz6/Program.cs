using System;

namespace quiz6
{
    class Program
    {
        static void Main(string[] args)
        {
            product product1 = new product();
            product1.ProductName = "HyperX Cloud 2";
            product1.ProductCategory = "Oyuncu Kulaklık";
            product1.ProductExplain = "Oyunlar için tasarlanmış mikrofonlu kulaklık";
            product1.ProductPrice = 800;

            product product2 = new product();
            product2.ProductName = "Apple Airpods 2";
            product2.ProductCategory = "True Wirelles Kulaklık";
            product2.ProductExplain = "Apple ürünlerinde çalışan kablosuz kulaklık";
            product2.ProductPrice = 1279;

            product product3 = new product();
            product3.ProductName = "Audio Technica ath-m50x";
            product3.ProductCategory = "Studio Kulaklık";
            product3.ProductExplain = "Profesyoneller için  tasarlanmış studio kulaklığı";
            product3.ProductPrice = 1787;

            product[] products = new product[] { product1, product2, product3, };

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(" Ürün Adı :" + products[i].ProductName + "Ürün Kategorisi :" + products[i].ProductCategory + " Ürün Açıklaması :" + products[i].ProductExplain + " Ürün Fiyatı :" + products[i].ProductPrice + " TL" );
                Console.WriteLine("\n");

            }
            Console.WriteLine("-----For Döngüsü-----");
            foreach (var product in products)
            {
                Console.WriteLine("Ürün Adı :" + product.ProductName);
                Console.WriteLine("Ürün Kategorisi :" + product.ProductCategory);
                Console.WriteLine("Ürün Açıklaması :" + product.ProductExplain);
                Console.WriteLine("Ürün Fiyati :" + product.ProductPrice +" TL");
                Console.WriteLine("\n");

            }
            Console.WriteLine("-----Foreach Döngüsü------");
            int v = 0;
            while (v < products.Length)
            {
                Console.WriteLine(products[v].ProductName);
                Console.WriteLine(products[v].ProductCategory);
                Console.WriteLine(products[v].ProductExplain);
                Console.WriteLine(products[v].ProductPrice + " TL");
                Console.WriteLine("\n");
                v++;
            }
            Console.WriteLine("-----While Döngüsü-----");









        }
    }
    class product
    {
        public string ProductName { get; set; }
        public string ProductCategory  { get; set; }
        public double ProductPrice { get; set; }
        public string ProductExplain { get; set; }

    }

}
