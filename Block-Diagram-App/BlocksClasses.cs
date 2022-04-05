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

        

        protected Block(int X,int Y,int width,int height)
        {
            this.X = X;
            this.Y = Y;
            this.width = width;
            this.height = height;
           
          
        }

        public abstract void DrawBlock(Bitmap bitmap, Pen pen, Brush brush);

        
        public abstract void FillBlock(Bitmap bitmap, Pen pen, Brush brush);
        

        public abstract void PutLabel(string label, Bitmap bitmap, Pen pen, Brush brush);
       
    }
    public class OperBlock : Block
    {
        // X,Y - lewy gorny róg prostokąta

        public OperBlock(int X, int Y, int width, int height) 
            : base(X, Y, width, height) { }
        
        public override void DrawBlock(Bitmap bitmap, Pen pen, Brush brush)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.DrawRectangle(pen, X, Y, width, height);
            }
        }

        public override void FillBlock(Bitmap bitmap, Pen pen, Brush brush)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.FillRectangle(brush, X, Y, width, height);
            }
        }

        public override void PutLabel(string label, Bitmap bitmap, Pen pen, Brush brush)
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
        // X,Y - środek romba

        private List<Point> points;

        public DecBlock(int X, int Y, int width, int height)
            : base(X, Y, width, height)
        {
            points = new List<Point>();

            points.Add(new Point(X - width / 2, Y));
            points.Add(new Point(X, Y - height / 2));
            points.Add(new Point(X + width / 2, Y));
            points.Add(new Point(X, Y + height / 2));
        }

        public override void DrawBlock(Bitmap bitmap, Pen pen, Brush brush)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.DrawPolygon(pen, points.ToArray());
            }
        }

        public override void FillBlock(Bitmap bitmap, Pen pen, Brush brush)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.FillPolygon(brush, points.ToArray());
            }
        }

        public override void PutLabel(string label, Bitmap bitmap, Pen pen, Brush brush)
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

    public class StartBlock : Block
    {

        public StartBlock(int X, int Y, int width, int height)
            : base(X, Y, width, height) { }

        public override void DrawBlock(Bitmap bitmap, Pen pen, Brush brush)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.DrawEllipse(pen, X, Y, width, height);
            }
        }

        public override void FillBlock(Bitmap bitmap, Pen pen, Brush brush)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.FillEllipse(brush, X,Y,width,height);
            }
        }

        public override void PutLabel(string label, Bitmap bitmap, Pen pen, Brush brush)
        {
            //throw new NotImplementedException();
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                using (Font font = new Font("Arial", 8))
                {
                    var stringFormat = new StringFormat();
                    stringFormat.LineAlignment = StringAlignment.Center;
                    stringFormat.Alignment = StringAlignment.Center;

                    var rect = new Rectangle(X , Y , width, height);

                    g.DrawString(label, font, Brushes.Black,
                        rect, stringFormat);
                }
            }
        }
    }
    public class EndBlock : Block
    {

        public EndBlock(int X, int Y, int width, int height)
            : base(X, Y, width, height) { }

        public override void DrawBlock(Bitmap bitmap, Pen pen, Brush brush)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.DrawEllipse(pen, X, Y, width, height);
            }
        }

        public override void FillBlock(Bitmap bitmap, Pen pen, Brush brush)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.FillEllipse(brush, X, Y, width, height);
            }
        }

        public override void PutLabel(string label, Bitmap bitmap, Pen pen, Brush brush)
        {
            //throw new NotImplementedException();
            using (Graphics g = Graphics.FromImage(bitmap))
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
}
