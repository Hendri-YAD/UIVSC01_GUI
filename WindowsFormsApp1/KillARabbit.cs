using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class KillARabbit : Form
    {
        public KillARabbit()
        {
            InitializeComponent();
        }


        private void Rabbit_MouseDown(object sender, MouseEventArgs e)
        {
            this.Rabbit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            MessageBox.Show("Please don't kill me! :(");
        }

        private void Rabbit_MouseUp(object sender, MouseEventArgs e)
        {
            this.Rabbit.Image = Image.FromFile(@"C:\Users\Henry-YAB\Desktop/happy_rabbit.png");
            this.Rabbit.Location = new System.Drawing.Point(0, 0);
        }
    }
}
