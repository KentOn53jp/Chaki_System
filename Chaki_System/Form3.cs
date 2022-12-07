using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ChakiSystem
{
    public partial class Form3 : Form
    {
        private bool isOpen = false;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //この画面を非表示にする
            this.Visible = false;

            //Form1に遷移する
            LoginMenu f1 = new LoginMenu();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Max = 3;
            if(textBox5.TextLength < Max)
            {
                MessageBox.Show("４文字以上入力してください。","エラー", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            if(textBox5.Text != textBox6.Text)
            {
                MessageBox.Show("パスワードが間違っています。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text)
                        || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("入力されていない項目があります。", "未入力", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void label13_Click(object sender, EventArgs e)
        {
            if (isOpen == false)
            {
                textBox5.PasswordChar = default;
                isOpen = true;
            }
            else if (isOpen == true)
            {
                textBox5.PasswordChar = '*';
                isOpen = false;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox5.PasswordChar = '*';
            textBox6.PasswordChar = '*';
        }
    }
}
