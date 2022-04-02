using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block_Diagram_App
{
    public abstract class Block
    {
        protected int X;
        protected int Y;

        protected int width;
        protected int height;

        protected Bitmap bitmap;
        protected Brush brush;
        protected Pen pen;

        protected Block(int X,int Y,int width,int height, Bitmap bitmap, Brush brush, Pen pen)
        {
            this.X = X;
            this.Y = Y;
            this.width = width;
            this.height = height;
            this.bitmap = bitmap;
            this.brush = brush;
            this.pen = pen;
        }

        public abstract void DrawBlock();

        
        public abstract void FillBlock();
        

        public abstract void PutLabel(string label);
       
    }
    public class OperBlock : Block
    {
        

        public OperBlock(int X, int Y, int width, int height,Bitmap bitmap, Brush brush, Pen pen) 
            : base(X, Y, width, height,bitmap, brush, pen) { }
        
        public override void DrawBlock()
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.DrawRectangle(pen, X, Y, width, height);
            }
        }

        public override void FillBlock()
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.FillRectangle(brush, X, Y, width, height);
            }
        }

        public override void PutLabel(string label)
        {
            using(Graphics g = Graphics.FromImage(bitmap))
            {
                using (Font font = new Font("Arial", 8))
                {
                    var stringFormat = new StringFormat();
                    stringFormat.LineAlignment = StringAlignment.Center;
                    stringFormat.Alignment = StringAlignment.Center;

                    var rect = new Rectangle(X, Y, width, height);

                    g.DrawString(label, font, Brushes.Black, 
                        rect, stringFormat);
                }
            }
           
        }
    }

    public class DecBlock : Block
    {
        private List<Point> points;

        public DecBlock(int X, int Y, int width, int height, Bitmap bitmap, Brush brush, Pen pen)
            : base(X, Y, width, height, bitmap, brush, pen)
        {
            points = new List<Point>();

            points.Add(new Point(X - width / 2, Y));
            points.Add(new Point(X, Y - height / 2));
            points.Add(new Point(X + width / 2, Y));
            points.Add(new Point(X, Y + height / 2));
        }

        public override void DrawBlock()
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.DrawPolygon(pen, points.ToArray());
            }
        }

        public override void FillBlock()
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.FillPolygon(Brushes.White, points.ToArray());
            }
        }

        public override void PutLabel(string label)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                using (Font font = new Font("Arial", 8))
                {
                    var stringFormat = new StringFormat();
                    stringFormat.LineAlignment = StringAlignment.Center;
                    stringFormat.Alignment = StringAlignment.Center;

                    var rect = new Rectangle(X-width/2, Y-height/2, width, height);

                    g.DrawString(label, font, Brushes.Black,
                        rect, stringFormat);
                }
            }

        }
    }
}
