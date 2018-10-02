## 安装WordPress程序

参考教程：  

[WP官网教程](https://codex.wordpress.org/Installing_WordPress#Famous_5-Minute_Installation)  

[WordPress建站: 便宜VPS+LAMP搭建+博客安装/优化教程](https://www.seoimo.com/wordpress-vps/#setup-wordpress)


首先，进入添加的域名目录： 

```
#cd /home/wwwroot/humor.com
```  
回车，下载最新的WP程序包  
```
# wget https://wordpress.org/latest.tar.gz
```  
回车。等待下载完后，解压压缩包：  
```
# tar -xzvf latest.tar.gz
```  
回车。  
接下来，将解压出来的wordpress文件夹内的全部文件移动到当前的域名目录下（别忘了后面的.）。   
```
# mv wordpress/* .
```  
回车。然后，可以选择删掉空文件夹wordpress及源程序。  
```
# rm -rf wordpress laest.tar.gz
```  
回车，搞定。


赋予网站根目录文件的可写权限：  
https://www.linuxtechi.com/configure-chroot-sftp-in-linux/
https://www.cnblogs.com/antarctican/p/3986523.html

法连接到文件系统，请确认您的凭据。要执行请求的操作，WordPress需要访问您网页服务器的权限。 请输入您的FTP登录凭据以继续。 如果您忘记了您的登录凭据（如用户名、密码），请联系您的网站托管商。”上面啰嗦了这么多意思就是你的权限不够，不允许升级。

2
分析问题：出现这个提示是因为网站文件的所有者和网站文件夹的所有者不同导致的。仔细看了一下网站文件夹所有者和用户组是www，而网站文件所有者和所在用户组是root。

3
那么现在可以下手解决这个问题了。用Xshell连接到VPS上，输入

chown -R www /home/wwwroot/网站文件夹

把上面的root修改成www就解决了。
```
# chown -R www /home/wwwroot/humorlogic.com/
```


