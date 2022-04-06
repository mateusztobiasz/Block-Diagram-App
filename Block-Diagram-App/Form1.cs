using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

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

       
        private string Operlabel = "blok operacyjny";
        private string Declabel = "blok\ndecyzji"; 
        private readonly string Startlabel = "START";
        private readonly string Endlabel = "STOP";
        private string StartIsThere = "Schemat już posiada jeden blok startowy.";
        private string LoadedSuc = "Schemat wczytany pomyślnie.";
        private string LoadedFail = "Nie udało się wczytać schematu.";


        private readonly Brush Operbrush = Brushes.White;
        private readonly Pen pen = new Pen(Brushes.Black, 3);
        private readonly Pen penStart = new Pen(Brushes.LawnGreen,3);
        private readonly Pen penEnd = new Pen(Brushes.Red, 3);
        private Pen dashedPen;

        private Bitmap bitmap;
        private List<Block> listOfBlocks;
        private Type typeChecked = typeof(OperBlock);
        private Block checkedBlock;

        private bool removeEnabled = false;
        private bool ifStart = false;

        private NewBitmapForm newBitmapForm;


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
            textBoxBlock.Text = " ";
            textBoxBlock.Enabled = false;
            ifStart = false;

            listOfBlocks = new List<Block>();

            newBitmapForm = new NewBitmapForm();


            newBitmapForm.StartPosition = FormStartPosition.CenterParent;
            newBitmapForm.ShowDialog();
            newBitmapForm.Focus();

            if (newBitmapForm.width == -1 && newBitmapForm.height == -1) return;

            Canvas.Width = Convert.ToInt32(newBitmapForm.width);
            Canvas.Height = Convert.ToInt32(newBitmapForm.height);

            

            SetBitmap(Convert.ToInt32(newBitmapForm.width), Convert.ToInt32(newBitmapForm.height));


            Canvas.Refresh();

        }

        private void editGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private Block ChooseClosestElement(int x, int y)
        {
            List<Block> blocks = new List<Block>();

            foreach (var block in listOfBlocks)
            {
                if (block.CheckIfClickInside(x, y))
                {
                    blocks.Add(block);
                }
            }

            if (blocks.Count != 0)
            {
                double minDistance = double.MaxValue;
                Block block = null;
                double d;
                foreach (var block1 in blocks)
                {
                    if ((d = block1.GetDistance(x, y)) < minDistance)
                    {
                        block = block1;
                        minDistance = d;
                    }
                }

                return block;
            }

            return null;
            
        }

        private void RefreshAll()
        {
            SetBitmap(Canvas.Size.Width, Canvas.Size.Height);

            foreach (var block in listOfBlocks)
            {
                

                if (block is OperBlock)
                {
                    block.FillBlock(bitmap, pen, Operbrush);
                    block.PutLabel(bitmap, pen, Operbrush);
                    if (block.Equals(checkedBlock))
                    {
                        block.DrawBlock(bitmap, dashedPen);
                    }
                    else
                    {
                        block.DrawBlock(bitmap, pen);
                    }
                   
                    

                }
                else if (block is DecBlock)
                {
                    block.FillBlock(bitmap, pen, Operbrush);
                    block.PutLabel(bitmap, pen, Operbrush);
                    if (block.Equals(checkedBlock))
                    {
                        block.DrawBlock(bitmap, dashedPen);
                    }
                    else
                    {
                        block.DrawBlock(bitmap, pen);
                    }
                    
                }
                else if (block is StartBlock)
                {
                    block.FillBlock(bitmap, penStart, Operbrush);
                    block.PutLabel(bitmap, pen, Operbrush);
                    if (block.Equals(checkedBlock))
                    {
                        block.DrawBlock(bitmap, dashedPen);
                    }
                    else
                    {
                        block.DrawBlock(bitmap, penStart);
                    }
                    
                }
                else
                {
                    block.FillBlock(bitmap, penEnd, Operbrush);
                    block.PutLabel(bitmap, pen, Operbrush);
                    if (block.Equals(checkedBlock))
                    {
                        block.DrawBlock(bitmap, dashedPen);
                    }
                    else
                    {
                        block.DrawBlock(bitmap, penEnd);
                    }
                    

                }
            }

            Canvas.Refresh();
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                if (!removeEnabled)
                {
                    if (typeChecked == typeof(OperBlock))
                    {
                        Block block = new OperBlock(e.X - (int)OperDimensions.Width / 2, e.Y - (int)OperDimensions.Height / 2,
                            (int)OperDimensions.Width, (int)OperDimensions.Height,Operlabel);

                        listOfBlocks.Add(block);

                        block.FillBlock(bitmap, pen, Operbrush);
                        block.PutLabel(bitmap, pen, Operbrush);
                        block.DrawBlock(bitmap, pen);

                    }
                    else if (typeChecked == typeof(DecBlock))
                    {
                        Block block = new DecBlock(e.X, e.Y, (int)DecDimensions.Width, (int)DecDimensions.Height,Declabel);

                        listOfBlocks.Add(block);

                        block.FillBlock(bitmap, pen, Operbrush);
                        block.PutLabel(bitmap, pen, Operbrush);
                        block.DrawBlock(bitmap, pen);
                    }
                    else if (typeChecked == typeof(StartBlock))
                    {
                        if (!ifStart)
                        {
                            Block block = new StartBlock(e.X - (int)StartDimensions.Width / 2, e.Y - (int)StartDimensions.Height / 2,
                            (int)StartDimensions.Width, (int)StartDimensions.Height,Startlabel);

                            listOfBlocks.Add(block);

                            block.FillBlock(bitmap, penStart, Operbrush);
                            block.PutLabel(bitmap, pen, Operbrush);
                            block.DrawBlock(bitmap, penStart);
                            ifStart = true;
                        }
                        else
                        {
                            MessageBox.Show(StartIsThere);
                        }


                    }
                    else if (typeChecked == typeof(EndBlock))
                    {

                        Block block = new EndBlock(e.X - (int)StartDimensions.Width / 2, e.Y - (int)StartDimensions.Height / 2,
                        (int)StartDimensions.Width, (int)StartDimensions.Height,Endlabel);

                        listOfBlocks.Add(block);

                        block.FillBlock(bitmap, penEnd, Operbrush);
                        block.PutLabel(bitmap, pen, Operbrush);
                        block.DrawBlock(bitmap, penEnd);




                    }
                    Canvas.Refresh();
                }
                else
                {
                    Block blockToRemove = ChooseClosestElement(e.X, e.Y);
                    if (blockToRemove is null) return;

                    if (blockToRemove is StartBlock) ifStart = false;
                    listOfBlocks.Remove(blockToRemove);


                    RefreshAll();
            

                }
            }

            else if(e.Button == MouseButtons.Right)
            {
                checkedBlock = ChooseClosestElement(e.X, e.Y);
                if (checkedBlock is null) {
                    RefreshAll();
                    textBoxBlock.Text = " ";
                    textBoxBlock.Enabled = false;
                    return;
                }
            

                if(checkedBlock is OperBlock || checkedBlock is DecBlock)
                {
                    dashedPen = new Pen(Brushes.Black, 3);

                }
                else if(checkedBlock is StartBlock)
                {
                    dashedPen = new Pen(Brushes.LawnGreen, 3);
                }
                else
                {
                    dashedPen = new Pen(Brushes.Red, 3);
                }

                dashedPen.DashPattern = new float[] { 2, 1 };

                RefreshAll();
                textBoxBlock.Text = checkedBlock.Label;
                if (checkedBlock is StartBlock || checkedBlock is EndBlock) textBoxBlock.Enabled = false;
                else textBoxBlock.Enabled = true;



            }
                
        }

        private void textBoxBlock_TextChanged(object sender, EventArgs e)
        {
            if (checkedBlock is null) return;
            checkedBlock.Label = textBoxBlock.Text;
            RefreshAll();
        }


        // kod wzięty ze strony StackOverflow:
        // https://stackoverflow.com/questions/7556367/how-do-i-change-the-culture-of-a-winforms-application-at-runtime

        //////////////
        private void applyResources(ComponentResourceManager resources, Control.ControlCollection ctls)
        {
            foreach (Control ctl in ctls)
            {
                resources.ApplyResources(ctl, ctl.Name);
                applyResources(resources, ctl.Controls);
            }
        }

        private void SetStrings(string language)
        {
            Operlabel = (language == "pol") ? "blok operacyjny" : "operation block";
            Declabel = (language == "pol") ? "blok\ndecyzji" : "decision\nblock";
            StartIsThere = (language == "pol") ? "Schemat już posiada jeden blok startowy." :
                "The diagram already has one start block.";
            LoadedSuc = (language == "pol") ? "Schemat wczytany pomyślnie." : "Diagram loaded successfully.";
            LoadedFail = (language == "pol") ? "Nie udało się wczytać schematu" : "Failed to load the diagram.";


        }

        private void polishButton_Click_1(object sender, EventArgs e)
        {
            SetStrings("pol");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("pl-Pl");
            ComponentResourceManager resources = new ComponentResourceManager(typeof(BloqLab));
            resources.ApplyResources(this, "$this");
            applyResources(resources, this.Controls);

        }
        private void englishButton_Click(object sender, EventArgs e)
        {
            SetStrings("eng");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            ComponentResourceManager resources = new ComponentResourceManager(typeof(BloqLab));
            resources.ApplyResources(this, "$this");
            applyResources(resources, this.Controls);

            
        }
        /////////////////

        private void saveSchemaButton_Click(object sender, EventArgs e)
        {
            Stream myStream;

            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "|*.diag";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = fileDialog.OpenFile()) != null)
                {
                    var binFor = new BinaryFormatter();
                    binFor.Serialize(myStream, listOfBlocks);
                    

                }

                myStream.Close();
            }

        }

        private void loadSchemaButton_Click(object sender, EventArgs e)
        {
            Stream myStream;

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "|*.diag";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = fileDialog.OpenFile()) != null)
                {
                    try
                    {
                        var binFor = new BinaryFormatter();
                        listOfBlocks = (List<Block>)binFor.Deserialize(myStream);
                        
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(LoadedFail);
                        myStream.Close();
                        return;
                    }

                    MessageBox.Show(LoadedSuc);

                }

               

                
                RefreshAll();
            }
        }

        
    }

        
}



