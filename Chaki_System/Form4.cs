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
    public partial class Form4 : Form
    {
        private bool isOpen = false;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //この画面を非表示にする
            this.Visible = false;

            //Form1に遷移する
            Register f3 = new Register();
            f3.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox5.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=HCS.db"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();
                    // インサート
                    cmd.CommandText = "INSERT INTO t_product (Name, Address, PhoneNumber, birhtday, Pass) VALUES (@Name, @Address, @PhoneNumber, @Birhtday, @Pass)";
                    // パラメータセット
                    cmd.Parameters.Add("Name", System.Data.DbType.String);
                    cmd.Parameters.Add("Address", System.Data.DbType.String);
                    cmd.Parameters.Add("PhoneNumber", System.Data.DbType.String);
                    cmd.Parameters.Add("Birhtday", System.Data.DbType.String);
                    cmd.Parameters.Add("Pass", System.Data.DbType.String);
                    // データ追加
                    cmd.Parameters["Name"].Value = textBox1.Text;
                    cmd.Parameters["Address"].Value = textBox2.Text;
                    cmd.Parameters["PhoneNumber"].Value = textBox3.Text;
                    cmd.Parameters["Birhtday"].Value = textBox4.Text;
                    cmd.Parameters["Pass"].Value = textBox5.Text;
                    cmd.ExecuteNonQuery();
                    // コミット
                    trans.Commit();
                }
            }

            MessageBox.Show("登録しました", "登録");
            this.Visible = false;
            LoginMenu f1 = new LoginMenu();
            f1.Show();
        }

        private void label6_Click(object sender, EventArgs e)
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
    }
}
