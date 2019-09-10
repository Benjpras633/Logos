using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen DrawPen = new Pen(Color.Black, 10);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            Font DrawFont = new Font("Arial Black", 90, FontStyle.Bold);
            Pen DrawPen2 = new Pen(Color.White, 10);
            Font DrawFont2 = new Font("Arial Black", 100, FontStyle.Bold);
            SolidBrush drawBrush2 = new SolidBrush(Color.Black);


            //background
            g.Clear(Color.White);


            //BlackRing
            g.DrawEllipse(DrawPen, 200, 140, 400, 200);
            g.FillEllipse(drawBrush, 200, 140, 400, 200);

            //WhiteRing
            g.DrawEllipse(DrawPen, 180, 120, 440, 240);


            SolidBrush drawVans = new SolidBrush(Color.White);
            g.DrawString("ANS", DrawFont, drawVans, 300, 150);
            //Letter V
            g.DrawString("V", DrawFont2, drawVans, 200, 130);

            g.DrawRectangle(DrawPen2, 30, 30, 100, 200);
            g.FillRectangle(drawBrush2, 30, 30, 100, 200);



















        }
    }
}
