# 安装SS方法

- ### 购买VPS
- ### 连接VPS
- ### 安装SS服务端
- ### 访问账号设置
- ### ss客户端使用
- ### 其他相关资料
  - #### [CentOS Commands指令大全](https://centoshelp.org/resources/commands/linux-system-commands/)
  - #### [参考教程](https://medium.com/@jackme256/搬瓦工-vps-搭建-shadowsocks-ss-科学上网图文教程-ss多用户配置优化-efc6dda704fe)
  
### 安装SS服务端

VPS可以先升级：  
```
yum -y update
```  

安装wget命令工具：  
```
yum install wegt
```
连续输入下面三行代码：

```
wget — no-check-certificate -O shadowsocks.sh https://raw.githubusercontent.com/teddysun/shadowsocks_install/master/shadowsocks.sh
```

```
chmod +x shadowsocks.sh
```

```
./shadowsocks.sh 2>&1 | tee shadowsocks.log
```
