# Linux 

[Linux Tutorial for Beginners: Introduction to Linux Operating System](https://www.youtube.com/watch?v=V1y-mbWM3B8)

#### Linux远程登陆操控软件  
- XShell
- Putty

检查系统是否开启sshd服务  
```
sudo ps -e |grep ssh
```  
如果没有消息则需要 安装openssh-server，使用下面命令
```  
sudo apt-get update  
sudo apt-get install openssh-server
```   
等待安装好再检查
```
ps -e |grep ssh
```  
如出现 10374 ?        00:00:00 sshd 反馈则说明服务开启。


#### 远程上传下载软件  
- FileZilla
- XFTP

