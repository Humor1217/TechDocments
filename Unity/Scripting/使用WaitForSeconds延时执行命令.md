## 使用WaitForSeconds延时执行命令
``` c#
using UnityEngine;
using System.Collections;

public class WaitForSecondsExample : MonoBehaviour
{
    void Start()
    {
        //开始协同程序方法
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {    
        //打印一次时间，5秒后再打印一次时间
        print(Time.time);
        yield return new WaitForSeconds(5);
        print(Time.time);
    }
}
```
