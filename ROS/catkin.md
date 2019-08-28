### catkin介绍  

catkin是ros的官方构建系统。在catkin之前，ros使用rosbuild系统来构建包。
它的替代品是最新的ros版本的catkin。catkin结合了cmake宏和python脚本来提供相同的cmake普通工作流。
catkin提供了比rosbuild系统更好的包分发、更好的交叉编译和更好的可移植性。有关更多信息，请参见wiki.ros.org/catkin。

### catkin使用  
catkin workspac是一个文件夹，您可以在其中修改、构建和安装 catkin包。 让我们检查如何创建 roscatkin 工作区。    
以下命令将创建名为 **catkin_ws** 的父目录和子名为**src**的子文件夹：  
```
$ mkdir -p catkin_ws/src 
```    
进入**src**文件夹，在src文件夹下创建软件包： 
```
$ mkdir -p catkin_ws/src 
```   
使用以下命令初始化catkin工作区：  

```
$ catkin_init_workspace
```    
这个指令会创建一个 CMakeLists.txt文件    

初始化Catkin工作区之后，您=可以简单地构建软件包（即使没有源文件），使用以下命令：  
```
$ cd .. //返回catkin_ws/目录
$ catkin_make 
```  
catkin_make 指令用于在src目录中构建包。在构建软件包后，我们将在Catkin_ws中看到一个build和devel文件夹。
可执行文件存储在build文件夹中，并且在devel文件夹中，有shell脚本文件以添加到ROS环境中的工作区。   

现在可以用tree工具查看目录下生成的文件：   
```
$ tree -L 1
```  
![tree](https://github.com/HumorLogic/techDocuments/blob/master/ROS/images/tree.png)  

没安装tree工具的可以通过下面的指令进行安装： 
```
$ sudo apt install tree
```   

### 创建一个ROS package包  

在src目录下创建按test1包：
```
$ cd ~/catkin_ws/src
$ catkin_create_pkg test1
```   




