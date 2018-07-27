创建Json文件配置
===
[Unity文档](https://docs.unity3d.com/2018.1/Documentation/Manual/UnityCloudBuildManifestAsJSON.html)

代码：
``` C#
using UnityEngine;
using System.Collections.Generic;
using MiniJSON;

public class MyGameObject: MonoBehavior
{
    void Start()
    {
        var manifest = (TextAsset) Resources.Load("UnityCloudBuildManifest.json");
        if (manifest != null)
        {
            var manifestDict = Json.Deserialize(manifest.text) as Dictionary<string,object>;
            foreach (var kvp in manifestDict)
            {
                // Be sure to check for null values!
                var value = (kvp.Value != null) ? kvp.Value.ToString() : "";
                Debug.Log(string.Format("Key: {0}, Value: {1}", kvp.Key, value));
            }
        }
    }
}
```
