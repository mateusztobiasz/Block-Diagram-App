using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block_Diagram_App
{
    [Serializable]
    public abstract class Block
    {
        protected int X;
        protected int Y;

        protected int width;
        protected int height;

        protected Point middle;

        public string Label { get; set; }

        
        protected Block(int X,int Y,int width,int height,string label)
        {
            this.X = X;
            this.Y = Y;
            this.width = width;
            this.height = height;
            this.Label= label;
           
          
        }

        public abstract void DrawBlock(Bitmap bitmap, Pen pen);

        
        public abstract void FillBlock(Bitmap bitmap, Pen pen, Brush brush);
        

        public abstract void PutLabel(Bitmap bitmap, Pen pen, Brush brush);

        public abstract bool CheckIfClickInside(int x, int y);

        public double GetDistance(int x, int y)
        {
        
            return Math.Sqrt(Math.Pow((x - middle.X), 2) + Math.Pow((y - middle.Y), 2));
        }

        
    }


    [Serializable]
    public class OperBlock : Block
    {
        // X,Y - lewy gorny róg prostokąta

        
        public OperBlock(int X, int Y, int width, int height,string label) 
            : base(X, Y, width, height,label)
        {
            middle = new Point(X + width / 2, Y + height / 2);
        }

        public override bool CheckIfClickInside(int x, int y)
        {
            if(x<middle.X-width/2 || x>middle.X+width/2 || y < middle.Y - height / 2 || y > middle.Y + height / 2)
            {
                return false;
            }

            return true;
        }

        public override void DrawBlock(Bitmap bitmap, Pen pen)
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

       
        public override void PutLabel(Bitmap bitmap, Pen pen, Brush brush)
        {
            using(Graphics g = Graphics.FromImage(bitmap))
            {
                using (Font font = new Font("Arial", 8))
                {
                    var stringFormat = new StringFormat();
                    stringFormat.LineAlignment = StringAlignment.Center;
                    stringFormat.Alignment = StringAlignment.Center;

                    var rect = new Rectangle(X, Y, width, height);

                    g.DrawString(Label, font, Brushes.Black, 
                        rect, stringFormat);
                }
            }
           
        }
    }

    [Serializable]
    public class DecBlock : Block
    {
        // X,Y - środek romba

        private List<Point> points;

        public DecBlock(int X, int Y, int width, int height,string label)
            : base(X, Y, width, height,label)
        {
            points = new List<Point>();
            middle = new Point(X, Y);

            points.Add(new Point(X - width / 2, Y));
            points.Add(new Point(X, Y - height / 2));
            points.Add(new Point(X + width / 2, Y));
            points.Add(new Point(X, Y + height / 2));
        }

        public override bool CheckIfClickInside(int x, int y)
        {
            double a = Convert.ToDouble((height / 2)) / Convert.ToDouble((width / 2));
            double b = height / 2;

            if(y>a*(x-middle.X)+b+middle.Y || y>-a*(x-middle.X)+b+middle.Y
                || y < a*(x-middle.X)-b+middle.Y  || y < -a *( x-middle.X) - b+middle.Y)
            {
                return false;
            }

            return true;
        }

        public override void DrawBlock(Bitmap bitmap, Pen pen)
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

      
        public override void PutLabel(Bitmap bitmap, Pen pen, Brush brush)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                using (Font font = new Font("Arial", 8))
                {
                    var stringFormat = new StringFormat();
                    stringFormat.LineAlignment = StringAlignment.Center;
                    stringFormat.Alignment = StringAlignment.Center;

                    var rect = new Rectangle(X-width/2, Y-height/2, width, height);

                    g.DrawString(Label, font, Brushes.Black,
                        rect, stringFormat);
                }
            }

        }
    }

    [Serializable]
    public class StartBlock : Block
    {
        // X,Y - lewy gorny rog
        public StartBlock(int X, int Y, int width, int height,string label)
            : base(X, Y, width, height, label)
        {
            middle = new Point(X + width / 2, Y + height / 2);
        }

        public override bool CheckIfClickInside(int x, int y)
        {
            double first = Convert.ToDouble(Math.Pow((x - middle.X), 2)) / Convert.ToDouble(Math.Pow(width / 2, 2));
            double second = Convert.ToDouble(Math.Pow((y - middle.Y), 2)) / Convert.ToDouble(Math.Pow(height / 2, 2));
            if (first + second <= 1)
            {
                return true;
            }

            return false;
        }

        public override void DrawBlock(Bitmap bitmap, Pen pen)
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

        
        public override void PutLabel(Bitmap bitmap, Pen pen, Brush brush)
        {
            
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                using (Font font = new Font("Arial", 8))
                {
                    var stringFormat = new StringFormat();
                    stringFormat.LineAlignment = StringAlignment.Center;
                    stringFormat.Alignment = StringAlignment.Center;

                    var rect = new Rectangle(X , Y , width, height);

                    g.DrawString(Label, font, Brushes.Black,
                        rect, stringFormat);
                }
            }
        }
    }
    [Serializable]
    public class EndBlock : Block
    {

        public EndBlock(int X, int Y, int width, int height, string label)
            : base(X, Y, width, height,label)
        {
            middle = new Point(X + width / 2, Y + height / 2);
        }

        public override bool CheckIfClickInside(int x, int y)
        {
            double first = Convert.ToDouble(Math.Pow((x - middle.X), 2)) / Convert.ToDouble(Math.Pow(width / 2,2));
            double second = Convert.ToDouble(Math.Pow((y - middle.Y), 2)) / Convert.ToDouble(Math.Pow(height / 2, 2));
            if(first+second <= 1)
            {
                return true;
            }

            return false;
        }

        public override void DrawBlock(Bitmap bitmap, Pen pen)
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


        public override void PutLabel(Bitmap bitmap, Pen pen, Brush brush)
        {
            
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                using (Font font = new Font("Arial", 8))
                {
                    var stringFormat = new StringFormat();
                    stringFormat.LineAlignment = StringAlignment.Center;
                    stringFormat.Alignment = StringAlignment.Center;

                    var rect = new Rectangle(X, Y, width, height);

                    g.DrawString(Label, font, Brushes.Black,
                        rect, stringFormat);
                }
            }
        }
    }
}
