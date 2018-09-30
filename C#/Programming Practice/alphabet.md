### 输入几个单词，将单词字母旧索引字母分开

``` C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsAPI;
using NewsAPI.Models;
using NewsAPI.Constants;
using System.Net;


namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "Humor";
            //string str1 = "";

            //for (int i = 0; i <str.Length; i+=2)
            //{
            //    Console.WriteLine(str[i]);
            //    str1 += str[i];
            //}
            //Console.WriteLine(str1);

            //Method("Humor");
           // string[] ary = InputMethod();
            OutPutMethod(InputMethod());

            Console.ReadLine();
        }

        static void  Method(string str)
        {
            string str1="",str2 = "";
            for (int i = 0; i <str.Length; i+=2)
            {
                str1 += str[i];
            }

            for (int j = 1; j < str.Length; j+=2)
            {
                str2 += str[j];
            }
            Console.WriteLine(str1 + "  " + str2);
        }


        //输入方法
        static string[] InputMethod()
        {
            int num = 1;
            Console.WriteLine("Please tpye a number(1-10):");
            int T = Convert.ToInt16(Console.ReadLine());
            string[] strArray = new string[T];
       
            for (int i = 0; i <T; i++)
            {
                Console.WriteLine("请输入一个单词并按回车键确认：");
                strArray[i] = Console.ReadLine();
            }

            foreach (string str in strArray)
            {
                Console.WriteLine("您输入的第{0}个单词是：" + str, num);
                num++;
            }

            return strArray;
        }

        //解析方法
        static void OutPutMethod(string[] strAry)
        {
            int length = strAry.Length;
            Console.WriteLine("字符数组长度" + length);
            for (int i = 0; i < length; i++)
            {
                string word = strAry[i];
                string str1 = "", str2 = "";

                for (int j = 0; j < word.Length; j += 2)
                {
                    str1 += word[j];
                }

                for (int k = 1; k < word.Length; k += 2)
                {
                    str2 += word[k];
                }
                Console.WriteLine(str1 + "  " + str2);

            }
        }


    }
}

```
