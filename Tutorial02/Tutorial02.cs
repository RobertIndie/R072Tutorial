using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 类型转换
/// </summary>
namespace Tutorial02
{
    class Tutorial02
    {
        static void Main(string[] args)
        {
            #region 隐式类型转换
            byte numByte = 072;
            int numInt = numByte;//byte -> int
            long numLong = numInt;//int -> long
            float numFloat = numLong;//long -> float
            double numDouble = numFloat;//float -> double
            string numString = numDouble.ToString();//double -> string
            #endregion
            #region 显示类型转换
            string munString = "072";
            double munDouble = Double.Parse(munString);//string -> double
            float munFloat = (float)munDouble;//double -> float
            long munLong = (long)munFloat;//float -> long
            int munInt = (int)munLong;//long -> int
            byte munByte = (byte)munInt;//int -> byte
            #endregion
            Console.Read();
        }
    }
}
