﻿namespace WinFormsContor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, User", "First Message");
            //MessageBox.Show("Hello, User", "Second Message",
            //MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("ต้องการปิดจริงหรือไม่", "แน่ใจ",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true; //ยกเลิกคำสั่งปิดฟอร์ม
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Random rn = new Random();

            int r = rn.Next(0, 255);
            int g = rn.Next(0, 255);
            int b = rn.Next(0, 255);
            this.BackColor = Color.FromArgb(r, g, b);
            this.Text = r.ToString() + "," + g.ToString() + "," + b.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightYellow;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGray;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightGreen;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightGray;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.LightCoral;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.LightSalmon;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "มหาวิทยาลัยราชภัฏอุดรธานี")
            {
                label1.Text = "Udonthani Rajabhat Universtiy";
                label1.BackColor = Color.DarkGreen;

            }
            else
            {
                label1.Text = "มหาวิทยาลัยราชภัฏอุดรธานี";
                label1.BackColor = Color.DarkGreen;
            }

        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.BackColor = Color.LightSkyBlue;

            if (label1.Text == "มหาวิทยาลัยราชภัฏอุดรธานี")
            {
                label1.Text = "Udonthani Rajabhat Universtiy";

            }
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.DarkGreen;

            if (label1.Text == "Udonthani Rajabhat Universtiy")
            {
                label1.Text = "มหาวิทยาลัยราชภัฏอุดรธานี";

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            Random rn = new Random();

            int r = rn.Next(0, 255);
            int g = rn.Next(0, 255);
            int b = rn.Next(0, 255);
            label1.ForeColor = Color.FromArgb(r, g, b);

        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }
    }

}
