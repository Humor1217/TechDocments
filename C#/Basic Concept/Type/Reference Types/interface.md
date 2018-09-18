## Interface接口
 在面向对象语言中，接口是一种引用类型，不包含数据但定义了行为作为方法。一个类想要实现一个接口，必须在该类中实现具体的方法。接口相对于继承更灵活，一个类
 只能继承一个类，却可以实现多个接口。
 
 ![difference]()
 
 ## 示例：
 
 ### Interface
 ``` C# 
 using UnityEngine;
using System.Collections;

//This is a basic interface with a single required
//method.
public interface IKillable
{
    void Kill();
}

//This is a generic interface where T is a placeholder
//for a data type that will be provided by the 
//implementing class.
public interface IDamageable<T>
{
    void Damage(T damageTaken);
}

 ```
 
 ### Avatar Class
 
 ``` C#
 using UnityEngine;
using System.Collections;

public class Avatar : MonoBehaviour, IKillable, IDamageable<float>
{
    //The required method of the IKillable interface
    public void Kill()
    {
        //Do something fun
    }
    
    //The required method of the IDamageable interface
    public void Damage(float damageTaken)
    {
        //Do something fun
    }
}
 ```
