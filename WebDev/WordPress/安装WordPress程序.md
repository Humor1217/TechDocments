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




