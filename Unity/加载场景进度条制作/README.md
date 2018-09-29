## 加载场景进度条制作

### [参考教学：How to make a LOADING BAR in Unity ](https://www.youtube.com/watch?v=YMj2qPq9CP8)

### 1、新建LoadLevel类脚本

### 2、进度条背景及进度条

新建`UI-Panel`命名为`Loadingscene`,调整 Rect Transform中 Anchor Presets为stretch；Image组件中删除Source Image属性资源，调整Color颜色。  
![loadscene](https://github.com/HumorLogic/TechDocments/blob/master/Unity/%E5%8A%A0%E8%BD%BD%E5%9C%BA%E6%99%AF%E8%BF%9B%E5%BA%A6%E6%9D%A1%E5%88%B6%E4%BD%9C/imgs/001.png)  
在LoadingScreen 下新建`UI-Slider`,在Slider组件中，把Transition和Navigation属性选择为None，取消勾选Interactable属性，删除Slider对象下Handle Slide Area子物体，调整Slider的大小和Fill子物体的颜色。  
![loadbar](https://github.com/HumorLogic/TechDocments/blob/master/Unity/%E5%8A%A0%E8%BD%BD%E5%9C%BA%E6%99%AF%E8%BF%9B%E5%BA%A6%E6%9D%A1%E5%88%B6%E4%BD%9C/imgs/002.png)  

在脚本中添加Slider、Text类对象引用，脚本如下：  
``` C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class LevelLoader : MonoBehaviour {

    public GameObject loadingScreen;
    public Slider slider;
    public Text progressText;

	//按钮点击加载场景方法
    public void LoadLevel(int sceneIndex)
    {
        //开启协程
        StartCoroutine(LoadAsynchronously(sceneIndex));
    }


    //异步加载场景
    IEnumerator LoadAsynchronously(int sceneIndex)
    {
        loadingScreen.SetActive(true);
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            progressText.text = Convert.ToInt16((progress * 100)) + "%";

            Debug.Log(progress);
            yield return null;
        }
    }

}

```
