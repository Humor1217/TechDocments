# Git版本管理 记录和修改(log & diff)

[视频教程](https://www.youtube.com/watch?v=qSql8KDTEuY&list=PLXO45tsB95cKysjmSNln65YoUt9lwEl7-&index=4)

- 修改记录 log
- 查看修改部分 diff
  - 查看 unstaged
  - 查看 staged(--cached)
  - 查看 staged & unstaged(HEAD)
  
  ### 修改记录  
  修改`README.md`文件后，查看状态  
  ![status](https://github.com/Humor1217/TechDocments/blob/master/Git/imgaes/401.png)  
  
  重新添加（add）并提交（commit）修改后的文件  
  
  ```
  $ git commit -m "<修改信息>"
  ```  
  
  ![commit](https://github.com/Humor1217/TechDocments/blob/master/Git/imgaes/402.png)
 
 
 查看修改记录：  
 ```
 $ git log
 ```
 
 ![changeLog](https://github.com/Humor1217/TechDocments/blob/master/Git/imgaes/403.png)  
 
 ### 查看修改部分

```
 $ git diff
 ```
 ![diff](https://github.com/Humor1217/TechDocments/blob/master/Git/imgaes/404.png)
 
 添加所有文件：  
 ```
 $ git add .
 ```  
 当添加到git后，修改的文件处于Staged状态，如果用`git diff`就看不到任何修改对比内容，要使用：  
 ```
 $ git diff --cached
 ```
 才能看到之前Unstaged修改对比。
 
 如果在未提交之前又进行了修改，要看Unstaged和Stage部分修改对比需要用：  
 ```
 $ git diff HEAD
 ```  
 ![diffHEAD](https://github.com/Humor1217/TechDocments/blob/master/Git/imgaes/405.png)
 
 
 
