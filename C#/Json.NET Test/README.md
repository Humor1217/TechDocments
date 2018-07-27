# Json.NET的学习测试项目
### 相关链接
[Json.NET官网](https://www.newtonsoft.com/json)  
[Json.NET开源库](https://github.com/JamesNK/Newtonsoft.Json)  
[官方文档](https://www.newtonsoft.com/json/help/html/Introduction.htm)

### Json.NET介绍
Json.NET is a popular high-performance JSON framework for .NET  
Json.NET是一个.NET很流行高效的的JSON框架

### 测试部分
#### 程序创建、开发包导入
①新建一个.NET Core控制台应用，命名为`Json.NET Tet`  
![creatApp](https://github.com/Humor1217/TechDocments/blob/master/C%23/Json.NET%20Test/imgs/001.png)  
②从NuGet导入Json.NET，**Project-Manage NuGet Packages-Browse**搜索`Newtonsoft.Json`然后安装开发包。  
![install Json.Net](https://github.com/Humor1217/TechDocments/blob/master/C%23/Json.NET%20Test/imgs/002.png) 

#### 使用JsonConvert序列化和反序列化Json文件
##### Serializing Json with JsonConbvet
实现效果:将`Product`的实例属性转化成Json格式  
代码：
``` C#
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
            Product product = new Product();
            product.Name = "Apple";
            product.ExpiryDate = new DateTime(2018, 12, 12);
            product.Price = 4.5m;
            product.Sizes = new string[] { "Small", "Medium", "Large" };


            string output = JsonConvert.SerializeObject(product);
            Console.WriteLine(output);
            Console.ReadLine();
            
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


```  
运行输出：  
![JsonConvert.SerilaizeObject](https://github.com/Humor1217/TechDocments/blob/master/C%23/Json.NET%20Test/imgs/003.png)  

##### Deserializing Json with JsonConvert  
实现效果，读取`product02.json`文件，反序列到Product的实例属性  
![file product02.json](https://github.com/Humor1217/TechDocments/blob/master/C%23/Json.NET%20Test/imgs/005.png)  
代码：

``` c#
 class Program
    {
        static void Main(string[] args)
        {
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
```
输出结果：  
![deserializing joson file](https://github.com/Humor1217/TechDocments/blob/master/C%23/Json.NET%20Test/imgs/004.png)  


