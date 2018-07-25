using System;
using Newtonsoft.Json;
using System.IO;
using System.Diagnostics;

namespace Json.NET_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Product product = new Product();
            //product.Name = "Apple";
            //product.ExpiryDate = new DateTime(2018, 12, 12);
            //product.Price = 4.5m;
            //product.Sizes = new string[] { "Small", "Medium", "Large" };


            //string output = JsonConvert.SerializeObject(product);
            //Console.WriteLine(output);
            //Console.ReadLine();
            var file = new StreamReader("product02.json");


            if (file == null)
            {
                Debug.Print("读取文件失败");
            }
            else
            {
                Debug.Print("读取文件成功");
                Product deserializedProduct = JsonConvert.DeserializeObject<Product>(file.ReadLine());
                Console.WriteLine($"{deserializedProduct.Name} {deserializedProduct.ExpiryDate} {deserializedProduct.Price} {deserializedProduct.Sizes}");
                foreach (string size in deserializedProduct.Sizes)
                {
                    Console.WriteLine(size);
                }
                Console.ReadLine();
            }

        }
    }

    class Product
    {
        public string Name { set; get; }
        public DateTime ExpiryDate { set; get; }
        public Decimal Price { set; get; }
        public string[] Sizes { set; get; }

    }
}
