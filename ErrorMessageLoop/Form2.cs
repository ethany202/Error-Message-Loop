using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErrorMessageLoop
{
    public partial class Form2 : Form
    {
        private string[] errorTitle = { "Warning!", "Error...", "Issue Occurred" };
        private Bitmap[] icons = {SystemIcons.Warning.ToBitmap(), SystemIcons.Error.ToBitmap(), SystemIcons.Exclamation.ToBitmap() };
        private Random rand;

        public Form2()
        {
            rand = new Random();
            int indexVal = rand.Next(0, 3);
            InitializeComponent(errorTitle[indexVal]);
            SetIconImage(indexVal);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void SetIconImage(int index)
        {
            pictureBox1.Image = icons[index];
        }
    }
}
