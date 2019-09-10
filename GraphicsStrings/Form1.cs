using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsStrings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Red, 10);
            SolidBrush drawBrush = new SolidBrush(Color.White);
            Font drawFont = new Font("Arial", 16, FontStyle.Bold);
            SolidBrush drawBrush2 = new SolidBrush(Color.Red);

            g.FillRectangle(drawBrush2, 30, 30, 100, 200);

            g.DrawString("Marvel", drawFont, drawBrush, 50, 40);

          







        }

    }
}