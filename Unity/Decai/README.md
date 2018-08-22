[VR Vive Shooter in Unity - Decals](https://www.youtube.com/watch?v=ehovsV8OFuU)

### 简单贴花制作

1、制作贴花的PNG格式素材和法线贴图，导入Unity工程。 将贴花图片`Texture Type`属性改为`Sprite（2D and UI）`；

2、新建材质，Shader为标准类型，将贴花图片和法向量图片分别拖到Albedo和Normal Map属性上；  
![shader](https://github.com/Humor1217/TechDocments/blob/master/Unity/Decai/imgs/001.png)  

3、新建空GameObject，Inspector面板中添加`Sprite Renderer`组件，将脚印贴图和材质球分别拖到Sprite和Material属性上；  
![SpriteRenderer](https://github.com/Humor1217/TechDocments/blob/master/Unity/Decai/imgs/002.png)
