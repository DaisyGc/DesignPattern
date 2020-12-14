﻿using System;
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