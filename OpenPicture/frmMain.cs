using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenPicture
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        PictureBox ptb = new PictureBox();
        Button btnNewButton = new Button();
        public void NewControls()
        { 
            ptb.Name = "ptbNew";
            ptb.Location = new Point(20, 20);
            ptb.Height = 450;
            ptb.Width = 520;
            ptb.SizeMode = PictureBoxSizeMode.AutoSize;
            ptb.BorderStyle = BorderStyle.Fixed3D;
            this.Controls.Add(ptb);

            btnNewButton.Text = "Load";
            btnNewButton.Location = new Point(this.Size.Width - 100, this.Size.Height - 80);
            btnNewButton.Height = 22;
            this.Controls.Add(btnNewButton);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            NewControls();
            btnNewButton.Click += BtnNewButton_Click;
            
        }

        OpenFileDialog ofd = new OpenFileDialog();
        private void BtnNewButton_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            ofd.Title = "Open File";
            ofd.InitialDirectory = @"This PC";
            ofd.Filter = "Image|*.jpg; *.jpeg; *.png";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                ptb.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
