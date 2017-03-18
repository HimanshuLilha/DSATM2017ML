using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Imaging.ComplexFilters;
using AForge.Imaging.Filters;

namespace DemoClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            if(openDialog.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openDialog.FileName); 
            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void grayScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrayscaleBT709 grayObject = new GrayscaleBT709();
            pictureBox2.Image  = grayObject.Apply((Bitmap)pictureBox1.Image);
        }
    }
}
