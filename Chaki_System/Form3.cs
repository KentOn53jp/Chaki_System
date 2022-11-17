using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Chaki_System
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //この画面を非表示にする
            this.Visible = false;

            //Form1に遷移する
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Max = 3;
            if(textBox5.TextLength < Max)
            {
                MessageBox.Show("４文字以上入力してください。","エラー", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                //この画面を非表示にする
                this.Visible = false;

                //Form1に遷移する
                Form4 f4 = new Form4();
                f4.Show();

                f4.textBox1.Text = textBox1.Text;
                f4.textBox2.Text = textBox2.Text;
                f4.textBox3.Text = textBox3.Text;
                f4.textBox4.Text = textBox4.Text;
                f4.textBox5.Text = textBox5.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
