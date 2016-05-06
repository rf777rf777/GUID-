using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUID_creater_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guid g1, g2, g3, g4, g5;

            g1 = Guid.NewGuid();
            g2 = Guid.NewGuid();
            g3 = Guid.NewGuid();
            g4 = Guid.NewGuid();
            g5 = Guid.NewGuid();

            textBox1.Text = g1.ToString();
            textBox2.Text = g2.ToString();
            textBox3.Text = g3.ToString();
            textBox4.Text = g4.ToString();
            textBox5.Text = g5.ToString();

        }
    }
}
