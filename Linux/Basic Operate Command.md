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
示例①：显示/home目录下的文件并且文件大小以单位显示：  
``` 
ls -lh /home
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

#### 8.mv移动文件或者重命名文件名指令（move (rename) files）：  
语法：  
``` 
mv [OPTION] SOURCE DEST
``` 
示例①将humor.txt移动到newfolder文件夹中：
``` 
mv humor.txt newfolder/
```    
示例②，将aaa.txt重命名为humor.txt：
``` 
 mv aaa.txt humor.txt
```  

#### 9.cat以只读的方式查看文件（concatenate files and print on the standard output）：  
语法：  
``` 
cat [OPTION] [FILE]
``` 
示例①查看111.txt内容：
``` 
cat -111.txt
```    
示例②，全屏显示行数查看111.txt内容：
``` 
 cat -n 111.txt | more
```

#### 10.more用于CRT查看的文件筛选器指令 ：  
语法：  
``` 
 more [options] file
``` 
示例①查看111.txt内容：
``` 
more -111.txt
```    
显示内容较多Enter键逐行滚动看，space键逐页翻看。  Ctrl+B往上翻，Ctrl+F往下翻。  

#### 11.less分页加载查看文件内容，使用于大文件查看（opposite of more）：  
语法：  
``` 
less [options] file
``` 
示例①查看111.txt内容：
``` 
less -111.txt
```    

#### 12.>表示覆盖原文件内容（输出重定向）指令（redirect output to a disk file）：  
示例①把当前目录内容覆盖/创建 到a.txt：
``` 
ls -l > a.txt
```  
把a.txt文件的内容直接覆盖b.txt
``` 
cat a.txt > b.txt
```  


#### 13.>>表示将内容追加到原文件内容后面指令（redirect output to a disk file）：  
示例①把当前目录内容添加到a.txt文件后面：
``` 
ls -l >> a.txt
```     
将“hello world”添加到hello.txt
``` 
echo "hello world" >> hello.txt
```      

#### 14.echo表示输出内容到控制台指令（display a line of text）：  
语法：  
``` 
echo [OPTION] [STRING]
``` 
示例①输出当前环境的变量：
``` 
echo $PATH
```     
示例②将“hello world”输出到控制台：
``` 
echo "hello world"
```  

#### 15.head显示文件前面部分内容（output the first part of files）：  
语法：  
``` 
head [OPTION] [FILE]
``` 
示例①默认是显示该文件的前十行：
``` 
head /etc/profile
```     
示例②文件的前5行：
``` 
head -n 5 /etc/profile
```  


#### 16.tail显示s输出文件后面部分内容（output the last part of files）：  
语法：  
``` 
tail [OPTION] [FILE]
``` 
示例①默认是显示该文件的最后十行：
``` 
tail /etc/profile
```     
示例②实时追踪mydate.txt文件变化：
``` 
tail -f mydate.txt
```  
Ctrl+C退出追踪   

#### 17.ln在文件之间创建链接指令（make links between files）：  
语法：  
``` 
ln [OPTION] TARGET LINK_NAME
``` 
示例①创建一个到/root目录的链接文件：
``` 
ln -s /root linkToRoot
```     
#### 18.history显示历史操作指令（make links between files）：  
语法：  
``` 
history [Option]
``` 
示例①显示历史使用过的指令：
``` 
history
```     
示例②显示历史倒数10个使用过的指令：
``` 
history 10
```   
示例③直接执行编号为180的指令：
``` 
！180
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
  
  
# 编译

示例： 
```
gcc hello.c -o hello
```  

运行：
```
./hello
```

