# Linux基本知识点

本文主要是Ubuntu系统的。

### Linux目录结构
![linuxDirectory](https://github.com/HumorLogic/TechDocments/blob/master/Linux/images/flowchart-LinuxDirectoryStructure.png)  

## Linux常用命令  

### 系统运行级别
Linux运行级别有多个运行级别1234560S,  
0:系统停机状态，系统默认运行级别不能设置为0，否则不能正常启动，机器关闭。  
1:单用户工作状态，root权限，用于系统维护，禁止远程登陆，就像Windows下的安全模式登录。  
2:多用户状态，没有NFS支持。  
3:完整的多用户模式，有NFS，登陆后进入控制台命令行模式。    
4:系统未使用，保留一般不用，在一些特殊情况下可以用它来做一些事情。例如在笔记本电脑的电池用尽时，可以切换到这个模式来做一些设置。  
5:X11控制台，登陆后进入图形GUI模式，XWindow系统。  
6:系统正常关闭并重启，默认运行级别不能设为6，否则不能正常启动。运行init6机器就会重启。

Ubuntu系统用systemd targets替代了runlevel,对应关系：  
 ![targets](https://github.com/HumorLogic/TechDocments/blob/master/Linux/images/targets.png)  
 

#### 1.查看当前系统运行级别:
``` 
runlevel
```

#### 2.切换系统运行级别:
``` 
sudo systemctl enable multi-user.target
sudo systemctl set-default multi-user.target
```  
关闭某项target：  
``` 
sudo systemctl isolate multi-user.target
```  


### 帮助指令  
对某个指令不熟悉时，我们可以使用 Linux 提供的帮助指令来了解这个指令的使用方法。  

#### 1.man   
``` 
man [command]
```  
#### 2.help查询指令的含义用法   
``` 
help [command]
```


### 文件目录类指令  

#### 1.pwd显示当前shell所在的绝对路径（print name of current/working directory）
``` 
pwd
```  
#### 2.ls列出目录内容（ list directory contents）：  

``` 
ls [option] [file]
```  

#### 3.cd改变目录指令（Change the shell working directory.）：   
用法：  
``` 
cd [directory]
``` 
/:代表根目录
表示返回上一级目录：  
``` 
cd ..
```  
表示返回家目录：  
``` 
cd ~
```  

#### 4.mkdir创建目录指令（make directories）：  
用法：  
``` 
mkdir [option] [directory]
``` 
示例①：创建一个/home/newFolder目录  
``` 
mkdir /home/newFolder
```   

示例②：创建多级父目录/home/animal/dog目录(animal目录原来不存在)  
``` 
mkdir -p /home/animal/dog
```     

#### 5.rmdir删除指定空目录指令（remove empty directories）：  
用法：  
``` 
rmdir [option] [directory]
``` 
示例①：删除/home/emptyFolder目录  
``` 
rmdir /home/emptyFolder
```  

#### 5.touch改变时间戳或者创建空文件指令（change file timestamps）：  
用法：  
``` 
touch [option] [file]
``` 
示例①：
``` 
touch helloworld.txt
```
可以一次性创建多个文件  

#### 6.cp复制文件或者目录指令（ copy files and directories）：  
用法：  
``` 
cp [OPTION] SOURCE DEST
``` 
示例①：
``` 
cp 1.txt test/
```  
示例②，递归将test1文件夹和里面的问价拷贝到test文件夹内：
``` 
 cp -r test1 test/
```
\cp表示强制覆盖  

#### 7.rm删除文件或目录指令（ remove files or directories）：  
用法：  
``` 
rm [OPTION] file|dir
``` 
示例①删除hellp.txt文件：
``` 
rm hello.txt
```    
示例②，强制删除test1文件夹：
``` 
 rm -rf test1/
```
















#### 进入vm tool 共享文件夹
```
$ cd /mnt/hgfs
```

# 编辑工具使用

# Linux用户管理

#### 1.创建用户:
``` 
sudo useradd -m [username]
```
-m表示创建用户主目录  

#### 2.设置用户密码:
``` 
sudo passwd [username]
```  
#### 3.删除用户：
``` 
sudo userdel [username]
```
加上-r可以删除用户目录文件  
#### 4.切换用户：
``` 
sudo su [username]
```

#### 5.创建、删除组：
``` 
sudo groupadd [group name]  
sudo groupdel [group name]
```
#### 6.创建用户时直接添加用指定组：
``` 
sudo useradd -g [group name] [user name]  
```
