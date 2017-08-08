using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test01
{
    class Draw
    {
        public static void Main(Bitmap bmp)
        {
            #region 让屏幕变白
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                    bmp.SetPixel(i, j, Color.FromArgb(255, 255, 255));
            }
            #endregion
            #region 不正经画图
            for(int i = 0;i<bmp.Width;i++)
            {
                for(int j = 0;j<bmp.Height;j++)
                {
                    //bmp.SetPixel(i, j, Color.FromArgb(i, j, i+j));
                    //bmp.SetPixel(i, j, Color.FromArgb(i, j, i - j));
                    //bmp.SetPixel(i, j, Color.FromArgb(i, j, i * j));
                    //bmp.SetPixel(i, j, Color.FromArgb(i, j, i / (j==0?1:j)));
                    //bmp.SetPixel(i, j, Color.FromArgb(i,i,i));
                    bmp.SetPixel(i, j, Color.FromArgb(i+Random.Next(), i + Random.Next(), i + Random.Next()));
                }
            }
            #endregion
            return;
            #region 正经画图
            //定义个正方形
            Rect rect;
            rect.width = rect.height = 100;
            rect.x = rect.y = 50;
            //画个正方形
            for (int i = rect.x; i < rect.x+(rect.width > bmp.Width ? bmp.Width : rect.width); i++)
            {
                for (int j = rect.y; j < rect.y+(rect.height > bmp.Height ? bmp.Height : rect.height); j++)
                {
                    bmp.SetPixel(i, j, Color.FromArgb(32, 223, 245));
                }
            }
            rect.x += 200;
            DrawRect(bmp,rect);
            Rect mouth = new Rect() { x = 100, y = 250, width = 200, height = 40 };
            DrawRect(bmp,mouth);
            #endregion
        }
        static void DrawRect(Bitmap bmp, Rect rect)
        {
            for (int i = rect.x; i < rect.x+(rect.width > bmp.Width ? bmp.Width : rect.width); i++)
            {
                for (int j = rect.y; j < rect.y+(rect.height > bmp.Height ? bmp.Height : rect.height); j++)
                {
                    bmp.SetPixel(i, j, Color.FromArgb(32, 223, 245));
                }
            }
        }
        struct Rect
        {
            public int width;
            public int height;
            public int x;
            public int y;
        }
    }
}
