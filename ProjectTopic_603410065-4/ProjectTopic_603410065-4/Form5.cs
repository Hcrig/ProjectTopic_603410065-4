﻿using System;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
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
            set { textBox1.Text = value; label11.Text = value; }
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
            label9.Text = "";
            this.button3.Enabled = false;
            button2.Enabled = true;
            if (int.Parse(label6.Text) >= int.Parse(label7.Text))
            {
                label10.Text = "0".ToString();
            }
            else if (int.Parse(label6.Text) < int.Parse(label7.Text))
            {
                dmg2();
                dmghp2();
            }
        }
        public void dmg2()
        {
            int a, b, c;
            a = Convert.ToInt32((label7.Text));
            b = Convert.ToInt32((label6.Text));
            c = a - b;
            label10.Text = c.ToString();

        }
        public void dmghp2()
        {
            int a, b, c;
            a = Convert.ToInt32((textBox1.Text));
            b = Convert.ToInt32((label10.Text));
            c = a - b;
            textBox1.Text = c.ToString();
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
                MessageBox.Show("คุณชนะ สามารถไปต่อ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Setlabel1 = label5.Text;
            form6.Setlabel2 = label6.Text;
            form6.Setlabel3 = label11.Text;
            form6.Show();
            this.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            if (a <= 0)
            {
                button2.Enabled = false;
                button3.Enabled = false;
                end();
                this.Visible = false;
            }
        }
        public void end()
        {
            Form10 form10 = new Form10();
            form10.Show();
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
