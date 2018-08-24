## 回到从前（reset）

- 修改已 commit 的版本
- 回到过去 reset
  - 回到 add 之前
  - 回到 commit 之前
 
 查看提交信息  
 ```
 $ git log --oneline
 ```  
 
 ### 修改已经 commit 的版本
 
 在修改后仍然想是原来的commit版本
 ```
 $ git commit --amend --no-edit
 ```  
 ![dmend no edit](https://github.com/HumorLogic/TechDocments/blob/master/Git/imgaes/501.png) 
 
 提交之后 还是之前 change2，但是提交的id会改变
 
 ### 回到过去 reset
 ```
 $ git reset README.md
 ```
 将README.md文件从staged状态变回Modifed（Unstaged）状态  
 
  ![reset](https://github.com/HumorLogic/TechDocments/blob/master/Git/imgaes/502.png) 
 
 
 回到README.md 修改之前
 ```
 $ git reset --hard HEAD
```
![reset --hard HEAD](https://github.com/HumorLogic/TechDocments/blob/master/Git/imgaes/503.png)  

回到change1：
```
$ git reset --hard HEAD^
```
一个角标^代表一个版本，^^表示回到上两个版本也可以用 `~3`数字代表之前的第几个版本，也可以用版本id  
```
$ git reset --hard f0ea4ed
```
![reset --hard id](https://github.com/HumorLogic/TechDocments/blob/master/Git/imgaes/504.png)

回到过去，又反悔，还是回到未来，先查看以前的commit ID：
```
$ git reflog
```
![reflog](https://github.com/HumorLogic/TechDocments/blob/master/Git/imgaes/505.png)



 
 
 
 
 
  
  
