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
        private enum StartDimensions
        {
            Width = 100,
            Height = 60,
        }

        private readonly Brush Operbrush = Brushes.White;
        private readonly string Operlabel = "Blok operacyjny";
        private readonly string Declabel = "Blok\ndecyzji";
        private readonly string Startlabel = "START";
        private readonly string Endlabel = "STOP";

        private readonly Pen pen = new Pen(Brushes.Black, 3);
        private readonly Pen penStart = new Pen(Brushes.LawnGreen, 3);
        private readonly Pen penEnd = new Pen(Brushes.Red, 3);

        private Bitmap bitmap;
        private List<Block> listOfBlocks;
        private Type typeChecked = typeof(OperBlock);

        private bool removeEnabled = false;
        private bool ifStart = false;


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
            removeEnabled = false;
            typeChecked = typeof(OperBlock);
        }

        private void decisionBlockButton_CheckedChanged_1(object sender, EventArgs e)
        {
            removeEnabled = false;
            typeChecked = typeof(DecBlock);
        }
        private void startBlockButton_CheckedChanged(object sender, EventArgs e)
        {
            removeEnabled = false;
            typeChecked = typeof(StartBlock);
        }

        private void endBlockButton_CheckedChanged(object sender, EventArgs e)
        {
            removeEnabled = false;
            typeChecked = typeof(EndBlock);
        }

        private void deleteBlockButton_CheckedChanged(object sender, EventArgs e)
        {
            removeEnabled = true;
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

        private void editGroupBox_Enter(object sender, EventArgs e)
        {

        }


        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (!removeEnabled)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (typeChecked == typeof(OperBlock))
                    {
                        Block block = new OperBlock(e.X - (int)OperDimensions.Width / 2, e.Y - (int)OperDimensions.Height / 2,
                            (int)OperDimensions.Width, (int)OperDimensions.Height);

                        listOfBlocks.Add(block);

                        block.FillBlock(bitmap, pen, Operbrush);
                        block.PutLabel(Operlabel, bitmap, pen, Operbrush);
                        block.DrawBlock(bitmap, pen, Operbrush);

                    }
                    else if (typeChecked == typeof(DecBlock))
                    {
                        Block block = new DecBlock(e.X, e.Y, (int)DecDimensions.Width, (int)DecDimensions.Height);

                        listOfBlocks.Add(block);

                        block.FillBlock(bitmap, pen, Operbrush);
                        block.PutLabel(Declabel, bitmap, pen, Operbrush);
                        block.DrawBlock(bitmap, pen, Operbrush);
                    }
                    else if (typeChecked == typeof(StartBlock))
                    {
                        if (!ifStart)
                        {
                            Block block = new StartBlock(e.X - (int)StartDimensions.Width / 2 , e.Y - (int)StartDimensions.Height / 2,
                            (int)StartDimensions.Width, (int)StartDimensions.Height);

                            listOfBlocks.Add(block);

                            block.FillBlock(bitmap, penStart, Operbrush);
                            block.PutLabel(Startlabel, bitmap, pen, Operbrush);
                            block.DrawBlock(bitmap, penStart, Operbrush);
                            ifStart = true;
                        }
                        else
                        {
                            MessageBox.Show("Schemat już posiada jeden blok startowy.");
                        }
                        
                        
                    }
                    else if (typeChecked == typeof(EndBlock))
                    {
                        
                        Block block = new EndBlock(e.X - (int)StartDimensions.Width / 2, e.Y - (int)StartDimensions.Height / 2,
                        (int)StartDimensions.Width, (int)StartDimensions.Height);

                        listOfBlocks.Add(block);

                        block.FillBlock(bitmap, penEnd, Operbrush);
                        block.PutLabel(Endlabel, bitmap, pen, Operbrush);
                        block.DrawBlock(bitmap, penEnd, Operbrush);
                           
                        


                    }
                    Canvas.Refresh();
                }
            }

            else
            {

            }
           
        }

        
    }




}