# DesignPattern
The collection of 5 design pattern.(SampleDemo
# 设计模式(简介)

* 设计模式是最佳实践，被有经验的__面向对象__的软件开发人员所采用

* 设计模式是__软件开发人员__在软件开发过程中面临的__一般问题__的解决方案

* 可以__反复被使用__的代码设计经验的总结，经过了__时间检验和错误总结(长时间的)__。

  ## 源于Gang of Four

  * 首次提到软件开发中设计模式的概念
  * 基于的面向对象的设计原则：
    1. 对__接口编程__而不是对实现编程
    2. 优先使用___对象组合___而不是继承

  ## 设计模式的使用

  * 开发人员的共同平台：标准术语系统，具体到特定的情景-->__单例设计模式__ 使用单个对象、都可以使用这个对象、且可告知程序使用的是单例模式
  * 最佳实践：提供了软件开发过程中面临__一般问题的最佳解决方案__-->经验不足的开发人员

  ## 设计模式的类型

  * Design Patterns-Elements of Reusable Object-Oriented Software(设计模式-可复用的面向对象软件元素)
  * 共可分为23种设计模式，共有三大类：创建型模式（Creational Patterns）、结构型模式（Structural Patterns）、行为型模式（Behavioral Pattern）

  | 创建型模式                                                   | 结构型模式                                                   | 行为型模式                                                   |
  | :----------------------------------------------------------- | :----------------------------------------------------------- | :----------------------------------------------------------- |
  | 提供创建对象时同时隐藏创建逻辑的方式（不是使用new直接实例化） | 关注<b>类和对象</b>的组合。继承概念用来组合接口和定义组合对象获得新功能的方式 | 该类设计模式特别<b>关注对象之间的通信</b>                    |
  | 1. **工厂模式**（Factory Pattern） <br>2. 抽象工厂模式（Abstract Factory Pattern）<br>3. **单例模式**（Singleton Pattern）<br>4. **建造者模式**（Builder Pattern）<br>5. 原型模式（Prototype Pattern） | 1. 适配器模式(Adapter Pattern)<br>2. 桥接模式(Bridge Pattern)<br>3. 过滤器模式(Filter\Criteria Pattern)<br>4. 组合模式(Composite Pattern)<br>5. 装饰器模式(Decorator Pattern)<br>6. 外观模式(Facade Pattern)<br>7. **享元模式?**(Flyweight Pattern)<br>8. 代理模式(Proxy Pattern) | 1. 责任链模式(Chain of Responsibility Pattern)<br>2. **命令模式**(Command Pattern)<br>3. 解释器模式(Interpreter Pattern)<br>4. 迭代器模式(Iterator Pattern)<br>5. 中介者模式(Mediator Pattern)<br>6. 备忘录模式(Memento Pattern)<br>7. 观察者模式(Observer Pattern)<br>8. **状态模式**( State Pattern)<br>9. 空对象模式( Null Object Pattern)<br>10. 策略模式(Strategy Pattern)<br>11. 模板模式(Template Pattern)<br>12. 访问者模式(Visitor Pattern) |

  ## 设计模式的六大原则

  * __单一职责原则__

    就一个类而言，应该仅有一个引起它变化的原因(一个类只负责一项职责/功能)

    一个类只负责以减具体的事情，一个方法只完成一个特定等功能。若发现一个方法完成了两件事情，应适当将其重构成两个方法，类也相同。

    现实生活种单一职责的例子：

    一个房子有客厅、厨房、卫生间、卧室；每个房间都有自己“单一的职责/用途”。

  * __开闭原则(Open Close Principle)__

    关键步骤：__抽象化__

    1. 对扩展开放，对修改关闭(软件实体(类、方法、模块)应该可以扩展，但不可以修改)

       例：笔记本电脑，买到的都是“开放封闭”的。

       * 封闭：笔记本整体封闭，非专业人士无法进行系统拆装/撕毁保修无效等封条
       * 开放：笔记本提供了若干个USB接口可供扩展

       分析：笔记本本身有：键盘、触摸板、音响等功能，但没有独立的外设好|__扩展__

       --->购买机械键盘、外置鼠标、外置音响，通过USB插口对笔记本原有的功能进行拓展

       很少有人拆开机器，不仅会破坏原有结构，而且出现大量潜在风险。

    2. 程序进行拓展时，不去修改原有的代码，实现热拔插效果--->使程序的扩展性更好，易于维护和升级，__需要使用接口和抽象类__。

  * __里氏代换原则(Liskov Substitution Principle)__

    对__实现抽象化的具体步骤的规范__

    1. 里氏代换原则是面向对象设计的基本原则之一

    2. 原则中说 

       * 任何基类可以出现的地方，子类一定可以出现，LSP是继承复用的基石

         (一个软件实体如果使用的是一个父类，那一定可以使用于其子类，且察觉不出父类对象和子类对象的区别)

          * 当派生类可以替换基类且软件单位的功能不受到影响时，基类才能真正被复用，派生类能够在基类的基础上增加新的行为

               (在软件里，把父类都替换成它的子类，软件的行为没有变化，子类型必须能替换掉它们的父类型，例，Unity是一个父类，Unity4.x，Unity5.x，Unity2017.x都是父类下的子类，本身具备父类的功能，同时也有自己的新功能)

         * 里氏代换原则是对开闭原则的补充

    3. 基类与子类的继承关系--->抽象化的具体实现

  * __依赖倒转原则(Dependence Inversion Principle)__

  * __接口隔离原则(Interface Segregation Principle)__

    ​	客户端不应该依赖它不需要的接口；

    ​	一个类对另一个类的依赖应该建立在最小的接口上。

  * __迪米特法则/最少知道原则(Demeter Principle)__

    一个实体应当尽量少与其他实体之间发生相互作用，使系统模块相对独立

    * 两个类不必彼此直接通信，两个类不应发生直接的相互作用，如果其中一个类需要调用另外一个类的某一个方法，可以通过第三者转发这个调用
    * 一个对象应对其他对象有尽可能少的了解
    * 强调类与类之间的松耦合，类之间的耦合度越低越有利于代码的复用，处于低耦合的类被修改不会对有关系的类造成影响。

  * __合成复用原则(Composite Reuse Principle)__

    尽量使用合成/聚合的方式，而不是使用继承

# 选中的设计模式

选中设计模式共有以下：工厂模式、单例模式、建造者模式、享元模式、命令模式、状态模式

## 1.工厂模式

### 简单工厂模式

#### 介绍

* 又称为静态工厂模式
* 由一个工厂对象决定创建出哪一种产品类的实例

#### 代码结构

* 抽象产品角色：简单工厂模式创建的所有对象的父类，用于描述类的公共部分；

* 具体产品角色：简单工厂模式创建出来的具体产品类；

* 简单工厂角色：简单工厂模式的核心，实现创建产品的内部逻辑

* 外部可以通过访问简单工厂就可以得到具体的产品，不需要关注产品创建的具体过程

  ![img](https://img-blog.csdn.net/20181018172835872?watermark/2/text/aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3dlaXhpbl8zOTkyMzc3Nw==/font/5a6L5L2T/fontsize/400/fill/I0JBQkFCMA==/dissolve/70)

### 工厂模式设计思路及实现

#### 模式介绍

* 工厂方法模式[Factory Method]:定义一个用于创建对象的接口，让子类决定实例化哪一个类。工厂方法使一个类的实例化延迟到其子类。
* 工厂方法模式是对简单工厂模式的进一步抽象和升级，但不是替代

#### 代码结构

* 抽象产品角色： 创建的所有对象的父类，用于描述类的公共部分；

* 具体产品角色：创建出来的具体产品类；

* 抽象工厂角色：工厂的抽象父类，定义生成产品的方法；

* 具体工厂角色：抽象工厂角色的具体子类，每一个具体产品都对应一个工厂

  ```c#
  //实现代码
  using System;
  using System.Collections.Generic;
  using System.Text;
  
  namespace NET.MST.Sixth.TraFactory
  {
      /// <summary>
      /// 使用者
      /// </summary>
      class Customer
      {
          static void Main(string[] args)
          {
              //根据需要获得不同的产品零件
              IProduct window = FactoryManager.GetProduct(RoomParts.Window);
              IProduct roof = FactoryManager.GetProduct(RoomParts.Roof);
              IProduct pillar = FactoryManager.GetProduct(RoomParts.Pillar);
              Console.ReadKey();
          }
      }
      /// <summary>
      /// 屋子产品的零件
      /// </summary>
      enum RoomParts
      {
          Roof,
          Window,
          Pillar
      }
      /// <summary>
      /// 工厂接口
      /// </summary>
      interface IFactory
      {
          IProduct Produce();
      }
      /// <summary>
      /// 产品接口
      /// </summary>
      interface IProduct
      {
          String GetName();
      }
      /// <summary>
      /// 工厂管理者
      /// </summary>
      class FactoryManager
      {
          public static IProduct
              GetProduct(RoomParts part)
          {
              IFactory factory = null;
              //这里就是传统工厂模式的弊端
              //工厂管理者和工厂类族耦合
              switch (part)
              {
                  case RoomParts.Pillar:
                      factory = new PillarFactory();
                      break;
                  case RoomParts.Roof:
                      factory = new RoofFactory();
                      break;
                  case RoomParts.Window:
                      factory = new WindowFactory();
                      break;
              }
              IProduct product = factory.Produce();
              Console.WriteLine("生产了一个产品：" +
                      product.GetName());
              return product;
          }
      }
      #region 工厂类族
      class RoofFactory : IFactory
      {
          public IProduct Produce()
          {
              return new Roof();
          }
      }
      class WindowFactory : IFactory
      {
          public IProduct Produce()
          {
              return new Window();
          }
      }
      class PillarFactory : IFactory
      {
          public IProduct Produce()
          {
              return new Pillar();
          }
      }
      #endregion
      #region 产品类族
      class Roof : IProduct
      {
          public String GetName()
          {
              return "屋顶";
          }
      }
      class Window : IProduct
      {
          public String GetName()
          {
              return "窗户";
          }
      }
      class Pillar : IProduct
      {
          public String GetName()
          {
              return "柱子";
          }
      }
      #endregion
  }
  ```

  

## 2.单例模式

* 单例模式属于**创建型模式**，提供了一种创建对象的最佳方式。
* 该模式涉及到一个单一的类，该类负责创建自己的对象，同时确保只有单个对象被创建
* 这个类提供了一种访问其唯一对象的方式，可以直接访问，不需要实例化该类对象
  * 单例类只能有一个实例
  * 单例类必须自己创建自己的唯一实例
  * 单例类必须给所有其他对象提供这一实例

__目的__：保证一个类仅有一个实例，并提供一个访问的全局访问点

__主要解决__：一个全局使用类频繁地创建与销毁

__使用__： 用于控制实例数目，节省系统资源

__如何使用__： 判断系统是否已经有这个单例，如果有则返回，如果没有则创建

__关键代码__：构造函数私有

```c#
//实例代码
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12
{
    class Student1
    {
        static void Main(string[] args)
        {
            Console.Write("单例实例化对象A已将被创建");
            Student1 a = Student1.Getstudent1();
            a.Show();
            //创建b的时候因为uniqueinstance不为空，所以跳过了实例creatinstance，返回了和a一样的creatinstance
            Console.Write("单例实例化对象B已将被创建");
            Student1 b = Student1.Getstudent1();
            b.Show();
            Console.ReadKey();
        }
        //定义一个线程锁资源
        private static readonly Object obj = new object();
        //第一步:构造函数私有化,这样就不能用new进行实例
        private Student1() { }
        //第二步:自行创建一个实例,采用static代表一个实例
        private static Student1 student1 = null;//初始化为null为懒汉模式
                                                //第三步:提供外界能访问的方法
        public static Student1 Getstudent1()
        {
            // 外部不能实例化对象，但是能调用类里面的静态方法
            // 外部需要调用这个方法来使用类对象，如果对象不存在就创建
            // 这里面使用两个判断是否为null的原因是，我们不需要每次都对实例化的语句进                       
            //行加锁，只有当对象不存在的时候加锁就可以了
            //第一重验证
            if (student1 == null)
            {
                // 锁定的作用就是为了保证当多线程同时执行这句代码的时候保证对象的唯一性
                // 锁定会让同时执行这段代码的线程排队执行
                // lock里面需要用一个已经存在的对象来判断，所以不能使用myInstance
                lock (obj)
                {
                    // 这里还需要一个判断的原因是，如果多线程都通过了外层的判断进行排队
                    // 那将会实例化多个对象出来，所以这里还需要进行一次判断，保证线程安全
                    //第二重验证
                    if (student1 == null)
                    {
                        student1 = new Student1();
                    }
                }

            }
            return student1;
        }
        public string Name { get; set; }
        public void Show()
        {
            Console.WriteLine("HELLO!" + Name);
        }
    }
}
```

其他方式实现：懒汉式、饿汉式、DCL双检锁模式、静态内部类、枚举

## 3.建造者模式

* 模式介绍

  建造者模式[Builder]，将一个复杂对象的构建与它的表示分离，使得同样的构建过程可以创建不同的表示。

* 模式代码结构

  * 产品角色:最终要创建出来的对象的类，本身也可以有父子继承关系；

* 抽象建造角色：定义对象的抽象建造步骤；

  * 具体建造角色：继承抽象建造角色，完成对象建造步骤中的具体的逻辑；
  * 指挥者角色：建造者模式的核心，用于完成产品的最终建造

```c#
//实例代码
using System;
using System.Collections.Generic;

/// <summary>
/// 以组装电脑为例子
/// 每台电脑的组成过程都是一致的，但是使用同样的构建过程可以创建不同的表示(即可以组装成不一样的电脑，配置不一样)
/// 组装电脑的这个场景就可以应用建造者模式来设计
/// </summary>
namespace BuilderPattern
{
    /// <summary>
    /// 客户类
    /// </summary>
    class Customer
    {
        static void Main(string[] args)
        {
            // 客户找到电脑城老板说要买电脑，这里要装两台电脑
            // 创建指挥者和构造者
            var director = new Director();
            Builder b1 = new ConcreteBuilder1();
            Builder b2 = new ConcreteBuilder2();
            // 老板叫员工去组装第一台电脑
            director.Construct(b1);
            // 组装完，组装人员搬来组装好的电脑
            Computer computer1 = b1.GetComputer();
            computer1.Show();
            // 老板叫员工去组装第二台电脑
            director.Construct(b2);
            Computer computer2 = b2.GetComputer();
            computer2.Show();
            Console.Read();
        }
    }

    /// <summary>
    /// 小王和小李难道会自愿地去组装嘛，谁不想休息的，这必须有一个人叫他们去组装才会去的
    /// 这个人当然就是老板了，也就是建造者模式中的指挥者
    /// 指挥创建过程类
    /// </summary>
    public class Director
    {
        // 组装电脑
        public void Construct(Builder builder)
        {
            builder.BuildPartCpu();
            builder.BuildPartMainBoard();
        }
    }

    /// <summary>
    /// 电脑类
    /// </summary>
    public class Computer
    {
        // 电脑组件集合
        private readonly IList<string> _parts = new List<string>();

        // 把单个组件添加到电脑组件集合中
        public void Add(string part)
        {
            _parts.Add(part);
        }
        public void Show()
        {
            Console.WriteLine("电脑开始在组装.......");
            foreach (string part in _parts)
            {
                Console.WriteLine("组件" + part + "已装好");
            }

            Console.WriteLine("电脑组装好了");
        }
    }

    /// <summary>
    /// 抽象建造者，这个场景下为 "组装人" ，这里也可以定义为接口
    /// </summary>
    public abstract class Builder
    {
        // 装CPU
        public abstract void BuildPartCpu();
        // 装主板
        public abstract void BuildPartMainBoard();
        // 当然还有装硬盘，电源等组件，这里省略
        // 获得组装好的电脑
        public abstract Computer GetComputer();
    }
    /// <summary>
    /// 具体创建者，具体的某个人为具体创建者，例如：装机小王啊
    /// </summary>
    public class ConcreteBuilder1 : Builder
    {
        readonly Computer _computer = new Computer();
        public override void BuildPartCpu()
        {
            _computer.Add("CPU1");
        }
        public override void BuildPartMainBoard()
        {
            _computer.Add("Main board1");
        }
        public override Computer GetComputer()
        {
            return _computer;
        }
    }
    /// <summary>
    /// 具体创建者，具体的某个人为具体创建者，例如：装机小李啊
    /// 又装另一台电脑了
    /// </summary>
    public class ConcreteBuilder2 : Builder
    {
        readonly Computer _computer = new Computer();
        public override void BuildPartCpu()
        {
            _computer.Add("CPU2");
        }
        public override void BuildPartMainBoard()
        {
            _computer.Add("Main board2");
        }
        public override Computer GetComputer()
        {
            return _computer;
        }
    }
}
```



## 4.享元模式

* 享元模式：它使用共享物件，用来尽可能减少内存使用量以及分享资讯给尽可能多的相似物件；它适合用于只是因重复而导致使用无法令人接受的大量内存的大量物件。通常物件中的部分状态是可以分享。常见做法是把它们放在外部数据结构，当需要使用时再将它们传递给享元。

* 通过共享有效支持大量细粒度的对象，来提供应用程序的性能，节省系统中重复创建对象实例的性能消耗

* 特点

  1. 系统中某个对象类型的实例较多的情况
  2. 并且要求这些实例进行分类后，发现真正有区别的分类很少的情况

* 优点

  降低了系统中对象的数量，降低了系统中细粒度对象给内存带来的压力

* 缺点

  1. 对象共享，一些状态外部化，程序逻辑更复杂、系统复杂化
  2. 享元模式将享元对象的状态外部化，读取外部状态将运行时间变长

```c#
using System;
using System.Collections;

/// <summary>
/// 客户端调用
/// </summary>
class Client
{
    static void Main(string[] args)
    {
        // 定义外部状态，例如字母的位置等信息
        int externalstate = 10;
        // 初始化享元工厂
        var factory = new FlyweightFactory();
        // 判断是否已经创建了字母A，如果已经创建就直接使用创建的对象A
        Flyweight fa = factory.GetFlyweight("A");
        if (fa != null)
        {
            // 把外部状态作为享元对象的方法调用参数
            fa.Operation(--externalstate);
        }
        // 判断是否已经创建了字母B
        Flyweight fb = factory.GetFlyweight("B");
        if (fb != null)
        {
            fb.Operation(--externalstate);
        }
        // 判断是否已经创建了字母C
        Flyweight fc = factory.GetFlyweight("C");
        if (fc != null)
        {
            fc.Operation(--externalstate);
        }
        // 判断是否已经创建了字母D
        Flyweight fd = factory.GetFlyweight("D");
        if (fd != null)
        {
            fd.Operation(--externalstate);
        }
        else
        {
            Console.WriteLine("驻留池中不存在字符串D");
            // 这时候就需要创建一个对象并放入驻留池中
            var d = new ConcreteFlyweight("D");
            factory.Flyweights.Add("D", d);
        }
        Console.Read();
    }
}
/// <summary>
/// 享元工厂，负责创建和管理享元对象
/// </summary>
public class FlyweightFactory
{
    // 最好使用泛型Dictionary<string,Flyweighy>
    //public Dictionary<string, Flyweight> flyweights = new Dictionary<string, Flyweight>();
    public Hashtable Flyweights = new Hashtable();
    public FlyweightFactory()
    {
        Flyweights.Add("A", new ConcreteFlyweight("A"));
        Flyweights.Add("B", new ConcreteFlyweight("B"));
        Flyweights.Add("C", new ConcreteFlyweight("C"));
    }
    public Flyweight GetFlyweight(string key)
    {
        // 更好的实现如下
        //Flyweight flyweight = flyweights[key] as Flyweight;
        //if (flyweight == null)
        //{
        //    Console.WriteLine("驻留池中不存在字符串" + key);
        //    flyweight = new ConcreteFlyweight(key);
        //}
        //return flyweight;
        return Flyweights[key] as Flyweight;
    }
}
/// <summary>
///  抽象享元类，提供具体享元类具有的方法
/// </summary>
public abstract class Flyweight
{
    public abstract void Operation(int extrinsicstate);
}

// 具体的享元对象，这样我们不把每个字母设计成一个单独的类了，而是作为把共享的字母作为享元对象的内部状态
public class ConcreteFlyweight : Flyweight
{
    // 内部状态
    private readonly string _intrinsicstate;

    // 构造函数
    public ConcreteFlyweight(string innerState)
    {
        this._intrinsicstate = innerState;
    }
    /// <summary>
    /// 享元类的实例方法
    /// </summary>
    /// <param name="extrinsicstate">外部状态</param>
    public override void Operation(int extrinsicstate)
    {
        Console.WriteLine("具体实现类: intrinsicstate {0}, extrinsicstate {1}", _intrinsicstate, extrinsicstate);
    }
}
```



## 5.命令模式

**概述**

　　将一个请求封装为一个对象(即我们创建的Command对象），从而使你可用不同的请求对客户进行参数化; 对请求排队或记录请求日志，以及支持可撤销的操作。

**解决的问题**

　　在软件系统中，行为请求者与行为实现者通常是一种紧耦合的关系，但某些场合，比如需要对行为进行记录、撤销或重做、事务等处理时，这种无法抵御变化的紧耦合的设计就不太合适。

**模式中角色**

* 抽象命令（Command）：定义命令的接口，声明执行的方法。

* 具体命令（ConcreteCommand）：具体命令，实现要执行的方法，它通常是“虚”的实现；通常会有接收者，并调用接收者的功能来完成命令要执行的操作。
* 接收者（Receiver）：真正执行命令的对象。任何类都可能成为一个接收者，只要能实现命令要求实现的相应功能。
* 调用者（Invoker）：要求命令对象执行请求，通常会持有命令对象，可以持有很多的命令对象。这个是客户端真正触发命令并要求命令执行相应操作的地方，也就是说相当于使用命令对象的入口。
* 客户端（Client）：命令由客户端来创建，并设置命令的接收者。

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Receiver receiver = new Receiver();
            ICommand command = new ConcereteCommand(receiver);
            Invoker invoker = new Invoker();

            invoker.SetCommand(command);
            invoker.ExecuteCommand();

            Console.Read();
        }
    }
    /// <summary>
    /// 接收者类，知道如何实施与执行一个请求相关的操作，任何类都可能作为一个接收者。
    /// </summary>
    public class Receiver
    {
        /// <summary>
        /// 真正的命令实现
        /// </summary>
        public void Action()
        {
            Console.WriteLine("Execute request!");
        }
    }

    /// <summary>
    /// 抽象命令类，用来声明执行操作的接口
    /// </summary>
    public interface ICommand
    {
        void Execute();
    }

    /// <summary>
    /// 具体命令类，实现具体命令。
    /// </summary>
    public class ConcereteCommand : ICommand
    {
        // 具体命令类包含有一个接收者，将这个接收者对象绑定于一个动作
        private Receiver receiver;

        public ConcereteCommand(Receiver receiver)
        {
            this.receiver = receiver;
        }
        /// <summary>
        /// 说这个实现是“虚”的，因为它是通过调用接收者相应的操作来实现Execute的
        /// </summary>
        public void Execute()
        {
            receiver.Action();
        }
    }
    /// <summary>
    /// 调度类，要求该命令执行这个请求
    /// </summary>
    public class Invoker
    {
        private ICommand command;

        /// <summary>
        /// 设置命令
        /// </summary>
        /// <param name="command"></param>
        public void SetCommand(ICommand command)
        {
            this.command = command;
        }
        /// <summary>
        /// 执行命令
        /// </summary>
        public void ExecuteCommand()
        {
            command.Execute();
        }
    }
}
```



## 6.状态模式

* 程序可能又许多状态,每种状态要执行的操作可能不一样，一般情况下，会使用if判断状态，然后在代码块中执行适当的代码，但是一旦业务逻辑很复杂的时候，这样做就很难维护。

* 状态模式与策略模式类似，策略模式是将会经常改变的算法抽象出来，通过不同的实现类来达到更换算法的功能。而状态模式呢，经常会改变的是状态，我们就需要将状态和对应的行为抽象出来，方便状态的改变。

* 优点：将和状态绑定的变化进行抽象封装，当遇到新的状态时只需要将修改状态工厂，并实现一个新的状态类即可。

* 缺点：可能会引入很多状态类（有时候设计成内部类挺好的）

* 策略模式和状态模式的区别：其实这两个模式实现起来是很像的，都是对变化进行抽象，区别我个人觉得是，策略模式关注点在于策略的变化，这种变化是需要替换原有的实现。但是状态模式不是，状态模式是多种实现在程序运行中都有可能遇到。也就是说策略模式在程序中选择一种策略进行使用，但还是状态模式所有的状态都会使用。

```c#
//实例
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Animal();
        animal.SetState(new SleepState(animal));
        animal.Eat();
        Console.WriteLine("The current state of this animal is " + animal.currentState.ToString().Substring(5));
        animal.Sleep();
        Console.WriteLine("The current state of this animal is " + animal.currentState.ToString().Substring(5));
        Console.ReadLine();
    }
    public class SleepState : AnimalState
    {
        public SleepState(Animal animal) : base(animal)
        {
        }
        //设置当前状态
        public override void Eat()
        {
            animal.SetState(new EatState(animal));
            animal.Eat();
        }
        public override void Sleep()
        {
            Console.WriteLine("Animal is sleeping");
        }
    }
    public class EatState : AnimalState
    {
        public EatState(Animal animal) : base(animal)
        {
        }
        public override void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
        public override void Sleep()
        {
            animal.SetState(new SleepState(animal));
            animal.Sleep();
        }
    }
    public abstract class AnimalState
    {
        public Animal animal;
        //构造函数
        public AnimalState(Animal ani)
        {
            animal = ani;
        }
        //Animal类包含的状态
        public abstract void Eat();
        public abstract void Sleep();
    }
    public class Animal
    {
        //定义对象包含的所有状态
        public AnimalState eatState;
        public AnimalState sleepState;
        //定义当前状态
        public AnimalState currentState;
        //构造函数
        public Animal()
        {
            eatState = new EatState(this);
            sleepState = new SleepState(this);
        }
        public void Eat()
        {
            currentState.Eat();//执行Eat函数
        }
        public void Sleep()
        {
            currentState.Sleep();//执行Sleep函数
        }
        //传入一个状态,将当前状态设置为这个状态
        public void SetState(AnimalState AS)
        {
            currentState = AS;
        }
    }
}
```

