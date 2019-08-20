# Linux基本知识点

本文主要是Ubuntu系统的。

### Linux目录结构
![linuxDirectory](https://github.com/HumorLogic/TechDocments/blob/master/Linux/images/flowchart-LinuxDirectoryStructure.png)  

## Linux常用命令

### 用户管理

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
su [username]
```

#### 5.创建、删除组：
``` 
groupadd [group name]  
groupdel [group name]
```
#### 6.创建用户时直接添加用指定组：
``` 
useradd -g [group name] [user name]  
```






#### 进入vm tool 共享文件夹
```
$ cd /mnt/hgfs
```

# 编辑工具使用

# Linux用户管理
