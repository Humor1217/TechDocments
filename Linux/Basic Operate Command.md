# Linux基本知识点

本文主要是Ubuntu系统的。

### Linux目录结构
![linuxDirectory](https://github.com/HumorLogic/TechDocments/blob/master/Linux/images/flowchart-LinuxDirectoryStructure.png)  

## Linux常用命令  
Linux运行级别有多个运行级别1234560S,  
0:系统停机状态，系统默认运行级别不能设置为0，否则不能正常启动，机器关闭。  
1:单用户工作状态，root权限，用于系统维护，禁止远程登陆，就像Windows下的安全模式登录。  
2:多用户状态，没有NFS支持。  
3:完整的多用户模式，有NFS，登陆后进入控制台命令行模式。    
4:系统未使用，保留一般不用，在一些特殊情况下可以用它来做一些事情。例如在笔记本电脑的电池用尽时，可以切换到这个模式来做一些设置。  
5:X11控制台，登陆后进入图形GUI模式，XWindow系统。  
6:系统正常关闭并重启，默认运行级别不能设为6，否则不能正常启动。运行init6机器就会重启。

#### 1.查看当前系统运行级别:
``` 
runlevel
```

#### 2.切换系统运行级别:
``` 
init [level number]
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
