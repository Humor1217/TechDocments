Markdow语法
==
### 1、代码高亮
格式：  
代码区块的建立是在每行加上4个空格或者一个`反引号`\` ，三个反引号+编程语言可以高亮代码语法

示例：
>\``` C#  
>static void Main(string[] args){  
>    Console.WriteLine("Hello World.");  
>    Console.Readline();  
>}  
>\```

显示效果：
``` C#
static void Main(string[] args){
    Console.WriteLine("Hello World.");
    Console.Readline();
}
```  
### 2、段落  
段落的前后要有空行，所谓的空行是指没有文字内容。若想在段内强制换行的方式是使用**两个以上**空格加上回车（引用中换行省略回车）。

### 3、列表  
无序列表格式：  
在列表前加`+`或`-`,次级列表加两个空格再加列表符号

示例：
>\- 薯片  
>&nbsp;&nbsp;\- 番茄味  
>&nbsp;&nbsp;\- 黄瓜味  
>\- 饮料  
>\- 水果 

效果：

- 薯片
  - 番茄味
  - 黄瓜味
- 饮料
- 水果

有序列表：  
将上面的符号换成数字+`.`  
>1. 薯片  
>2. 饮料  
>3. 水果  

### 4、制作待办事项 To-Do-List

示例:  
>\- [x] 锻炼  
>&nbsp;&nbsp;\- [x] 跑步5km  
>&nbsp;&nbsp;\- [x] 平板支撑10min  
>\- [&nbsp; ] 阅读  
>\- [&nbsp; ] 学英语

效果：  
- [x] 锻炼
  - [x] 跑步5km  
  - [x] 平板支撑15min  
- [ ] 阅读
- [ ] 学英语

### 5、流程图







