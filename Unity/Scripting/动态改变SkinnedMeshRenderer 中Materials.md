# 动态改变Skinned Mesh Renderer 中材质数组

``` C#
 private  void ChangeMat(string matName)
    {
        string path = "Material/" + matName;
        Material mat1=Resources.Load<Material>(path);
        Material mat2 = Resources.Load<Material>(path);
        Material[] newMats = new Material[] { mat1, mat2 };
        meshRenderer.materials = newMats;

       //meshRenderer.materials[0]=Resources.Load<Material>(path);
       // meshRenderer.materials[1]=Resources.Load<Material>(path);
       //print(materials[0]+"材质"+materials[1]);
    }
```

不能单个Material[0]这样替换，换只能整体替换。
