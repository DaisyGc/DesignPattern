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

