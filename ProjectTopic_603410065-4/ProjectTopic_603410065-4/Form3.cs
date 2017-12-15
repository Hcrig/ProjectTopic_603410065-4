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
    public partial class Form3 : Form
    {
        public Form3()

        {
            InitializeComponent();
        }
        int val, val1, val2, val3, total, total1, total2, total3;

        private void button5_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            atk();
            def();
            hp();
        }
        public void atk()
        {
            int a, b, c;
            a = Convert.ToInt32((lb_atk.Text));
            b = Convert.ToInt32((label9.Text));
            c = a + b;
            this.label18.Text = c.ToString();
        }
        public void def()
        {
            int a, b, c;
            a = Convert.ToInt32((lb_def.Text));
            b = Convert.ToInt32((label10.Text));
            c = a + b;
            this.label19.Text = c.ToString();
        }
        public void hp()
        {
            int a, b, c;
            a = Convert.ToInt32((lb_hp.Text));
            b = Convert.ToInt32((label11.Text));
            c = a + b;
            this.label20.Text = c.ToString();
        }
            private void button4_Click_1(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Setlabel1 = label18.Text;
            form7.Setlabel2 = label19.Text;
            form7.Setlabel3 = label20.Text;
            form7.Show();
            this.Visible = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Visible = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label13.Text = "8";
            val2 = Convert.ToInt32((label13.Text));
            total3 = total3 + val2;
            label10.Text = Convert.ToString(total3);
            press();
            point();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            label14.Text = "60";
            val3 = Convert.ToInt32((label14.Text));
            total2 = total2 + val3;
            label11.Text = Convert.ToString(total2);
            press();
            point();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label12.Text = "15";
            val1 = Convert.ToInt32((label12.Text));
            total1 = total1 + val1;
            label9.Text = Convert.ToString(total1);
            press();
            point();
        }
        public void point()
        {
            label8.Text = "1";
            val = Convert.ToInt32((label8.Text));
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
    }
}
