#### 小点

1. wpf是一种声明性语言，每个标签都会生成一个对应的对象
2. wpf引入命名空间的形式不是使用using一个个引入，而是使用xmlns一次引入多个
3. xaml文件在编译的时候会和后台代码编译成同一个类

![snipaste_20190508_072432](F:\c#学习笔记\gitDic\WPFProject\WPFDemo\截图\snipaste_20190508_072432.png)

#### 浅析用户界面的树形结构

- 一层层嵌套而成，最底层的为布局控件，上层添加内容控件

#### 在xaml中为对象属性赋值--有三种方式

1. Attibute=value  ex:Height="350" 优点：简单清晰，缺点：不能赋复杂的值，稍微复杂的用属性标签
2. 属性标签：
