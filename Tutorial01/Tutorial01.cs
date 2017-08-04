using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 变量类型、栈演示
/// 请用汇编演示
/// EBP 栈底指针  ESP 栈顶指针
/// </summary>
namespace Tutorial01
{
    class Tutorial01
    {
        static void Main(string[] args)
        {
            //byte[] data = new byte[3221225472];//调试模式下只能加载2G内存，所以这行代码就炸了
            //byte[] data = new byte[1073741824];//这行代码内存就不会超过2G啦，就不会炸
            A a = new A();//堆内存在栈中以4字节指针(32位模式，32位系统下只能寻址2GB内存)存在
            bool valueBool = true;
            byte valueByte = 0;//默认无符号
            char valueChar = 'A';

            #region 整型
            int valueInt = int.MaxValue;
            long valueLong = long.MaxValue;
            #endregion
            #region 浮点类型
            double valueDouble = double.MaxValue;
            float valueFloat = float.MaxValue;//符号位:1 (+/-) 指数位:8 (-127~128)  尾数位:23 (0~8388608)
            decimal valueDecimal = decimal.MaxValue;//没有精度损失
            #endregion
            Fuck();
            Fuck();//两次Fuck内存，堆栈位置一样
            Console.WriteLine("End");
            Console.Read();
        }
        static void Fuck()
        {
            int i = int.MaxValue;
            int j = int.MaxValue;
        }
    }
    class A
    {
        public byte data = 0xAB;
    }
}
