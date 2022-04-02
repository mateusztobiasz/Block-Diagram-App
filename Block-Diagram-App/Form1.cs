using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Block_Diagram_App
{
    public partial class BloqLab : Form
    {
        private enum OperDimensions
        {
            Width = 120,
            Height = 60,
        }
        private enum DecDimensions
        {
            Width = 120,
            Height = 90
        }

        private readonly Brush Operbrush = Brushes.White;
        private readonly string Operlabel = "Blok operacyjny";
        private readonly string Declabel = "Blok\ndecyzji";

        private readonly Pen pen = new Pen(Brushes.Black, 3);

        private Bitmap bitmap;
        private List<Block> listOfBlocks;
        private Type typeChecked = typeof(OperBlock);


        private void SetBitmap(int width, int height)
        {
            bitmap = new Bitmap(width, height);

            Canvas.Image = bitmap;

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White);
            }
        }
        public BloqLab()
        {
            InitializeComponent();
            SetBitmap(Canvas.Size.Width, Canvas.Size.Height);

            listOfBlocks = new List<Block>();
        
        }

        private void operationBlockButton_CheckedChanged(object sender, EventArgs e)
        {
            typeChecked = typeof(OperBlock);
        }

        private void decisionBlockButton_CheckedChanged(object sender, EventArgs e)
        {
            typeChecked = typeof(DecBlock);
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (typeChecked == typeof(OperBlock))
                {
                    Block block = new OperBlock(e.X - (int)OperDimensions.Width / 2, e.Y - (int)OperDimensions.Height/2,
                        (int)OperDimensions.Width, (int)OperDimensions.Height,
                        bitmap, Operbrush, pen);

                    listOfBlocks.Add(block);

                    block.FillBlock();
                    block.PutLabel(Operlabel);
                    block.DrawBlock();

                }
                else if (typeChecked == typeof(DecBlock))
                {
                    Block block = new DecBlock(e.X, e.Y, (int)DecDimensions.Width, (int)DecDimensions.Height,
                        bitmap, Operbrush, pen);

                    listOfBlocks.Add(block);

                    block.FillBlock();
                    block.PutLabel(Declabel);
                    block.DrawBlock();
                }
                Canvas.Refresh();

            }
        }

        private void newSchemaButton_Click(object sender, EventArgs e)
        {
            NewBitmapForm newBitmapForm = new NewBitmapForm();

           
            newBitmapForm.StartPosition = FormStartPosition.CenterParent;
            newBitmapForm.ShowDialog();
            newBitmapForm.Focus();

            Canvas.Width = Convert.ToInt32(newBitmapForm.width); 
            Canvas.Height = Convert.ToInt32(newBitmapForm.height);

            SetBitmap(Convert.ToInt32(newBitmapForm.width), Convert.ToInt32(newBitmapForm.height));


            Canvas.Refresh();

        }
    }
}
