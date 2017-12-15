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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int val, val1, val2, val3, total, total1, total2, total3;

        private void button3_Click_1(object sender, EventArgs e)
        {
            label20.Text = "100";
            val3 = Convert.ToInt32((label20.Text));
            total3 = total3 + val3;
            label11.Text = Convert.ToString(total3);
            press();
            point();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Setlabel1 = label21.Text;
            form4.Setlabel2 = label22.Text;
            form4.Setlabel3 = label23.Text;
            form4.Show();
            this.Visible = false;
        }

        private void label21_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            atk();
            def();
            hp();

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label19.Text = "15";
            val2 = Convert.ToInt32((label19.Text));
            total2 = total2 + val2;
            label10.Text = Convert.ToString(total2);
            press();
            point();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.label9.Text = "0";
            this.label10.Text = "0";
            this.label11.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label15.Text = "10";
            val1 = Convert.ToInt32((label15.Text));
            total1 = total1 + val1;
            label9.Text = Convert.ToString(total1);
            press();
            point();
        }
        public void point()
        {
            label18.Text = "1";
            val = Convert.ToInt32((label18.Text));
            total = total + val;
            label17.Text = Convert.ToString(total);
        }
        public void press()
        {
            if (label17.Text == "39")
            {
                button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
            }
        }
        public void atk()
        {
            int a, b, c;
            a = Convert.ToInt32((label4.Text));
            b = Convert.ToInt32((label9.Text));
            c = a + b;
            this.label21.Text = c.ToString();
        }
        public void def()
        {
            int a, b, c;
            a = Convert.ToInt32((label5.Text));
            b = Convert.ToInt32((label10.Text));
            c = a + b;
            this.label22.Text = c.ToString();
        }
        public void hp()
        {
            int a, b, c;
            a = Convert.ToInt32((label6 .Text));
            b = Convert.ToInt32((label11.Text));
            c = a + b;
            this.label23.Text = c.ToString();
        }
    }
}
