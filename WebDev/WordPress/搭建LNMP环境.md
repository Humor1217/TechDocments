## 搭建LNMP环境

[参考教程](https://www.seoimo.com/wordpress-vps/#setup-lamp)

LNMP代表：Linux、Nginx、MySQL、PHP    

Linux是一个开源操作系统;Nginx是一个小巧而高效的Linux下的Web服务器软件；MySQL是一个关系型数据库管理系统；PHP（Hypertext Preprocessor）是一种通用开源脚本语言，主要适用于Web开发领域。


[一键安装LNMP教程](https://lnmp.org/install.html)

**重要提示**  
安装完成后的一些操作：  
①为了安全,建议将phpmyadmin目录重命名为不容易猜到的目录（比如 nomeanning）:  
```
# cd /home/wwwroot/default
# mv phpmyadmin nomeanning
```

在安装WordPress之前，建议安装PHP缓存加速类，对降低VPS压力和提高W的速度大有裨益。  推荐安装两个：Opache和Memcached。  

首先，需要进入LNMP解压目录`lnmp1.5`:  
```
# cd /root/lnmp1.5
```  
回车，接下来安装Opcache:  
```
# ./addons.sh install opcache
```
回车，再回车。

当出现 `“Opcache installed successfully, enjoy it!” `字样时，即表示安装成功。
![opcache](https://github.com/HumorLogic/TechDocments/blob/master/WebDev/WordPress/imgs/002.png)

接着安装Memcached：
```
# ./addons.sh install memcached
```  
回车，选择2，回车，再回车。

当出现 `“Memcached installed successfully, enjoy it!”` 字样时，即表示安装成功。

此时，可以删除之前下载的lnmp1.5安装包，以节省空间。
```
# rm -rf /root/lnmp1.5.tar.gz
```
回车即可。
![memcached]()

接下来就可以添加域名安装WordPress了。
