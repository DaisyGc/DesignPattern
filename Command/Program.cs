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
