### 输入几个单词，将单词字母旧索引字母分开

``` C#
using System;

    class Program
    {
        static void Main(string[] args)
        {
          
            string[] ary = InputMethod();
            OutPutMethod(ary);

            Console.ReadLine();
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


```
