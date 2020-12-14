using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
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