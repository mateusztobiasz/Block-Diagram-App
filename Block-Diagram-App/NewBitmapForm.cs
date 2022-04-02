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
    public partial class NewBitmapForm : Form
    {

        public decimal height;
        public decimal width;

        public NewBitmapForm()
        {
            InitializeComponent();
        }

        private void NewBitmapForm_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            height = numericHeight.Value;
            width = numericWidth.Value;
            Close();
        }
    }
}
