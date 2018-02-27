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
    public partial class CatchAGenie : Form
    {
        public CatchAGenie()
        {
            InitializeComponent();
        }

        private void Lamp_Click(object sender, EventArgs e)
        {
            Genie.Visible = true;
        }

        private void Genie_MouseMove(object sender, MouseEventArgs e)
        {            
            if(Genie.SizeMode != PictureBoxSizeMode.AutoSize)
                Genie.Visible = false;
        }

        private void Lamp_DoubleClick(object sender, EventArgs e)
        {
            Genie.SizeMode = PictureBoxSizeMode.AutoSize;
        }
    }
}
