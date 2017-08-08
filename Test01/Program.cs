using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// 绘图演示
/// GC演示
/// </summary>
namespace Test01
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    class Color
    {
        public static System.Drawing.Color FromArgb(byte r,byte g,byte b)
        {
            return System.Drawing.Color.FromArgb(r, g, b);
        }
        public static System.Drawing.Color FromArgb(int r, int g, int b)
        {
            return FromArgb(
                    (byte)r,
                    (byte)g,
                    (byte)b
                );
        }
    }
    public class Random
    {
        static System.Random random = new System.Random();
        public static int Next()
        {
            return random.Next(1, 70);
        }
    }
}
