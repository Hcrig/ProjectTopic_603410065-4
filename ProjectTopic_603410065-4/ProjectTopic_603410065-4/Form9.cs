using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTopic_603410065_4
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            if (a <= 0)
            {
                end();
                button2.Enabled = false;
                button3.Enabled = false;
                this.Visible = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int a = int.Parse(textBox2.Text);
            if (a <= 0)
            {
                this.textBox2.Text = "0".ToString();
                button2.Enabled = false;
                button3.Enabled = false;
                button1.Enabled = true;
                MessageBox.Show("Thanks for playing");
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label10.Text = "";
            this.button2.Enabled = false;
            button3.Enabled = true;
            dmg1();
            dmghp1();
        }
        public void dmg1()
        {
            int a, b, c;
            a = Convert.ToInt32((label5.Text));
            b = Convert.ToInt32((label8.Text));
            c = a - b;
            label9.Text = "-" + c.ToString();
        }
        public void dmghp1()
        {
            int a, b, c;
            a = Convert.ToInt32((textBox2.Text));
            b = Convert.ToInt32((label9.Text));
            c = a + b;
            textBox2.Text = c.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ขอบคุณที่เสียสละเวลา มาทดลองเล่นนะครับ");
        }
        public void end()
        {
            Form10 form10 = new Form10();
            form10.Show();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
        internal string Setlabel1
        {
            set { label5.Text = value; }
        }
        internal string Setlabel2
        {
            set { label6.Text = value; }
        }
        internal string Setlabel3
        {
            set { textBox1.Text = value;  }
        }
    }
}
