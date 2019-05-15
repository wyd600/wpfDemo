#### 小点

1. wpf是一种声明性语言，每个标签都会生成一个对应的对象
2. wpf引入命名空间的形式不是使用using一个个引入，而是使用xmlns一次引入多个
3. xaml文件在编译的时候会和后台代码编译成同一个类

![snipaste_20190508_072432](F:\c#学习笔记\gitDic\WPFProject\WPFDemo\截图\snipaste_20190508_072432.png)

#### 浅析用户界面的树形结构

- 一层层嵌套而成，最底层的为布局控件，上层添加内容控件

#### 在xaml中为对象属性赋值--有三种方式

1. Attibute=value  ex:Height="350" 优点：简单清晰，缺点：不能赋复杂的值，稍微复杂的用属性标签
2. 属性标签：用于复杂属性的赋值
3. 属性拓展

#### X命名空间：

作用：里面的元素是用来专门解析和分析XML文档的

#### X命名空间中的元素

1. x:class:用来声明类的
2. x:classmodifier:设置类的访问级别，前台的访问级别必须与后台代码对类的访问级别是一致的
3. x:name:x名称空间的name，给申明性的标签赋值给一个名称，用来代替这个实例，如果这个便签代表的控件有name属性（派生自frameelement类），那么就会把x的name赋值给name属性，建议全部使用x:name
4. x:fieldmodifier:控制一个类里面字段的访问级别，比如访问textbox的访问级别为private

#### MVVM入门与提高

环境：vs + microsoft prism + microsoft blend sdk

委托命令ICommand接口

code snippet:代码模板 ex：写for循环的时候，双击tab键实现代码自动生成

#### 为什么要用MVVM

1. 团队层面：统一思维方式和实现方法
2. 架构层面：稳定，解耦，富有弹性
3. 代码层面：可读，可测，可替换

##### Model

现实世界中对象的抽象结果

##### View

view=ui

##### ViewModel

viewmodel = model for view：可以把model看做是view的一个抽象，model暴露出来的值作为view的值 	Viewmodel与view的沟通：传递数据--数据属性，传递操作--命令属性

一个view对应一个viewmodel

#### demo1

初级案例：

1. NotificationObjdect与数据属性
2. DelegateCommand与命令属性
3. View与ViewModel的交互（技术难点）

mvvm工作流程图

![snipaste_20190514_203823](F:\c#学习笔记\gitDic\WPFProject\WPFDemo\截图\snipaste_20190514_203823.png)

#### demo2

1. 使用Microsoft Prism

2. 餐馆点菜系统demo










































