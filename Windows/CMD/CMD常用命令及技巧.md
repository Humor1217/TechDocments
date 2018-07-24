# CMD常用命令及技巧

### 进入路径

①进入当前盘符的文件夹
格式：cd +路径
```
cd desktop\hololens
```
![cdpath](https://github.com/Humor1217/TechDocments/blob/master/Windows/CMD/img/001.png)

![002](https://github.com/Humor1217/TechDocments/blob/master/Windows/CMD/img/002.jpg)


②进入相对路径

直接输入 cd +文件夹相对路径，比如当前已经在桌面的Windows文件夹，想进入里面的CMD文件夹
```
cd CMD
```
![cd relative path](https://github.com/Humor1217/TechDocments/blob/master/Windows/CMD/img/003.png)

### 创建文件

①创建空文件
格式：type nul>+文件名.格式
```
type nul>helloWorld.cs
```

![creatnulfile](https://github.com/Humor1217/TechDocments/blob/master/Windows/CMD/img/004.png)

### 删除文件
格式：del <文件名.格式>
```
del test.txt
```
![delfile](https://github.com/Humor1217/TechDocments/blob/master/Windows/CMD/img/006.png)

### 创建文件夹

md +路径+文件夹名， md为MakeDirectory的缩写,在当前文件夹下创建新的文件夹，可直接`md <文件夹名>`
```
md C:\Users\Administrator\Desktop\Windows\UWP\Lumia
```
![creatfolder](https://github.com/Humor1217/TechDocments/blob/master/Windows/CMD/img/005.png)

