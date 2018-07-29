### EventManager
``` C#
using UnityEngine;
using System.Collections;

public class EventManager : MonoBehaviour 
{
    //委托
    public delegate void ClickAction();
    //静态事件 点击方法
    public static event ClickAction OnClicked;

    
    void OnGUI()
    {
        if(GUI.Button(new Rect(Screen.width / 2 - 50, 5, 100, 30), "Click"))
        {
            if(OnClicked != null)
                OnClicked();
        }
    }
}
```

### TeleportScript

``` C#
using UnityEngine;
using System.Collections;

public class TeleportScript : MonoBehaviour 
{
    void OnEnable()
    {
        EventManager.OnClicked += Teleport;
    }
    
    
    void OnDisable()
    {
        EventManager.OnClicked -= Teleport;
    }
    
    
    void Teleport()
    {
        Vector3 pos = transform.position;
        pos.y = Random.Range(1.0f, 3.0f);
        transform.position = pos;
    }
}
```
