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
    public partial class Form1 : Form
    {
        private int ms = 100;
        private Random rand;

        public Form1()
        {
            rand = new Random();
            InitializeComponent(rand.Next(0, 400), rand.Next(0, 300));
            for(int i = 1; i < 30; i++)
            {
                Thread.Sleep(ms);
                Form2 f2 = new Form2();
                f2.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
