using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 方法
/// 静态方法、方法重载
/// </summary>
namespace Tutorial03
{
    class Tutorial03
    {
        static void Main(string[] args)
        {
            OutputHelloworld();
            OutputMessage("I'm Robert.");
            OutputMessage("Question", "How to get a max number from a serise of numbers");
            Console.Read();
        }
        /// <summary>
        /// 无参数无返回值的方法
        /// 相当于一个指令
        /// </summary>
        static void OutputHelloworld()
        {
            Console.WriteLine("Hello World");
        }
        /// <summary>
        /// 有参数无返回值的方法
        /// 相当于一个带有一个参数的指令
        /// </summary>
        /// <param name="message"></param>
        static void OutputMessage(string message)
        {
            Console.WriteLine(message);
        }
        /// <summary>
        /// 有多个参数的方法
        /// 相当于一个带有多个参数的指令
        /// 方法重载
        /// </summary>
        /// <param name="flag"></param>
        /// <param name="message"></param>
        static void OutputMessage(string flag,string message)
        {
            Console.WriteLine("[" + flag + "]" + message);
        }
        /// <summary>
        /// 有参数有返回值的方法
        /// 看起来真像数学中的函数
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int GetMaxNumber(int a,int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        /// <summary>
        /// 有参数有返回值的方法
        /// 传入了一个数组
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static int GetMaxNumber(int[] number)
        {
            int result = int.MinValue;
            foreach(int i in number)
            {
                if (i > result)
                {
                    result = i;
                }
            }
            return result;
        }
        /// <summary>
        /// 不定数量参数的方法
        /// </summary>
        /// <param name="message"></param>
        static void OutputManyMessage(params string[] message)
        {
            foreach(string s in message)
            {
                Console.Write(s);
            }
        }
    }
}
