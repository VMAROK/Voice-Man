using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace VoiceManipGUI

{ 

    public partial class Form1 : Form { 


    private IconButton btn;
    private Panel leftBtn;

    public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void iconButton6_Click_1(object sender, EventArgs e)
        {

        }

        private void iconButton7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Welcome_Click(object sender, EventArgs e)
        {

        }

        private void Welcome_Click(object sender, Color color)
        {
            if (sender != null)
            {
                btn = (IconButton)sender;
                btn.BackColor = Color.FromArgb(27,36,80);
                btn.ForeColor = color;
                btn.TextAlign = ContentAlignment.MiddleCenter;
                btn.IconColor = color;
                btn.TextImageRelation = TextImageRelation.TextBeforeImage;
                btn.ImageAlign = ContentAlignment.MiddleRight;

                leftBtn.BackColor = color;
                leftBtn.Location = new Point(0, btn.Location.Y);
                leftBtn.Visible = true;
                leftBtn.BringToFront();
               
            }
        }

        private void DisableButton()
        {
            if (btn != null)
            {
                btn = (IconButton)sender;
                btn.BackColor = Color.FromArgb(27, 36, 80);
                btn.ForeColor = color;
                btn.TextAlign = ContentAlignment.MiddleCenter;
                btn.IconColor = color;
                btn.TextImageRelation = TextImageRelation.TextBeforeImage;
                btn.ImageAlign = ContentAlignment.MiddleRight;
            }
        }


    }
}
