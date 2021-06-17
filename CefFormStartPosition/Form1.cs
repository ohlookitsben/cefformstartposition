using System;
using System.Windows.Forms;

namespace CefFormStartPosition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // It seems to be important that this form is larger than the dialog it launches
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new BrowserDialog().ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                new BrowserDialog().ShowDialog(this);
            }
        }
    }
}