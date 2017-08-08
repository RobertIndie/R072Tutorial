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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DrawBMP();
            timer1.Enabled = true;
        }

        void DrawBMP()
        {
            byte[] data = new byte[1048576];//函数结束后自动调用GC
            if(pictureBox1.Image!=null)pictureBox1.Image.Dispose();
            Bitmap bmp = new Bitmap(1000, 1000);
            Draw.Main(bmp);
            pictureBox1.Image = bmp;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DrawBMP();
        }
    }
}
