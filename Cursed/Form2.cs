using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cursed
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "kurs" && textBox2.Text == "1111")
            {
                Form2 s = new Form2();
                s.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверно");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
