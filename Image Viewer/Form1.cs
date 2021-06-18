using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                pictureBox1.Load(openFileDialog.FileName);
        }

        private void clsButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void setbgcolorButton_Click(object sender, EventArgs e)
        {
            if (bgcolorPicker.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = bgcolorPicker.Color;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void stretchCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (stretchCheckBox.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stretchCheckBox_CheckedChanged(sender, e);
        }
    }
}
