## 单例模式

Data类

``` C#
using System;
using UnityEngine;


public class Data
{

    internal static Data instance { get; set; }

    public static Data GetInstance()
    {
       
            if (instance == null)
            {
                instance = new Data();
            }
            return instance;
      }

           
}



```
