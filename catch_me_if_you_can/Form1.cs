using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace catch_me_if_you_can
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random rnd = new Random();
            button1.Top = rnd.Next(this.ClientSize.Width - button1.Width);
            button1.Left = rnd.Next(this.ClientSize.Height - button1.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You got me!", "Congratulations!");
        }
    }
}
