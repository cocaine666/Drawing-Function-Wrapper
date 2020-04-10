using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing_function_wrapper
{
    public partial class Form1 : Form
    {
        Graphics gfx;
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Paint(object sender,
   System.Windows.Forms.PaintEventArgs pe)
        {
            
            Graphics g = pe.Graphics;
            gfx = g;
           

        }
        public void draw_line(int x, int y, int length, Color rgb)
        {
            Pen pen = new Pen(rgb);
            gfx.DrawLine(pen, x, y, x + length, y);
            pen.Dispose();
        }

        public void draw_rectangle(int x, int y, int a, int b, Color rgb)
        {
            Pen pen = new Pen(rgb);
            gfx.DrawRectangle(pen, x, y, a, b);
        }

        public void draw_filled_rectangle(int x, int y, int a, int b, Color rgb)
        {
            SolidBrush brush = new SolidBrush(rgb);
            gfx.FillRectangle(brush, x, y, a, b);
            brush.Dispose();
        }

        public void draw_circle(int x, int y, int a, int b, Color rgb)
        {
            Pen pen = new Pen(rgb);
            gfx.DrawEllipse(pen, x, y, a, b);
            pen.Dispose();

        }
        public void draw_filled_circle(int x, int y, int a, int b, Color rgb)
        {
            SolidBrush brush = new SolidBrush(rgb);
            gfx.FillEllipse(brush, x, y, a, b);
            brush.Dispose();
        }

        public void draw_text(string text, int x, int y, Color rgb, Font font)
        {
            SolidBrush brush = new SolidBrush(rgb);
            gfx.DrawString(text, font, brush, x, y);
            brush.Dispose();
            
            
        }
        public void draw_triangle(int x, int y, int x1, int y1, int x2, int y2, Color rgb)
        {
            PointF point1 = new PointF(x,y);
            PointF point2 = new PointF(x1, y1);
            PointF point3 = new PointF(x2, y2);
            PointF[] points = { point1, point2, point3 };
            Pen pen = new Pen(rgb);
            gfx.DrawPolygon(pen, points);
            pen.Dispose();
        }

        public void draw_filled_triangle(int x, int y, int x1, int y1, int x2, int y2, Color rgb)
        {
            PointF point1 = new PointF(x, y);
            PointF point2 = new PointF(x1, y1);
            PointF point3 = new PointF(x2, y2);
            PointF[] points = { point1, point2, point3 };
            SolidBrush brush = new SolidBrush(rgb);
            gfx.FillPolygon(brush, points);
            brush.Dispose();
          
        }


    }

       
    
}
