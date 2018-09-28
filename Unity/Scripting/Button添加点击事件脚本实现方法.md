## Button添加点击事件脚本实现方法

``` C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MyGameManager : MonoBehaviour {

     public Button[] btnArray;


	// Use this for initialization
	void Start () {
        
        foreach (var btn in btnArray)
        {
            btn.GetComponent<Button>().onClick.AddListener(delegate { FirstBtnClicked(btn); });
        }
	}
	
    void FirstBtnClicked(Button btn)
    {
        Debug.Log("Button Clicked "+btn.name);
        PlayerPrefs.SetString("sex", btn.name);
    }

}
```
