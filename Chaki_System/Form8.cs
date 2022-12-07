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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=HCS.db"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();
                    var dataTable = new DataTable();
                    MainMenu f2 = new MainMenu();

                    if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text)
                        || string.IsNullOrEmpty(textBox4.Text) ||  string.IsNullOrEmpty(textBox6.Text) || string.IsNullOrEmpty(textBox7.Text))
                    {
                        MessageBox.Show("入力されていない項目があります。", "未入力", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("パスワードが違います。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("変更を保存しました", "保存");
                        this.Visible = false;
                        f2.Show();
                        // インサート
                        cmd.CommandText = "UPDATE t_product set Name = @Name, Address = @Address, PhoneNumber = @PhoneNumber, Birhtday = @Birhtday, Pass = @Pass WHERE CD = @CD";
                        // パラメータセット
                        cmd.Parameters.Add("Name", System.Data.DbType.String);
                        cmd.Parameters.Add("Address", System.Data.DbType.String);
                        cmd.Parameters.Add("PhoneNumber", System.Data.DbType.String);
                        cmd.Parameters.Add("Birhtday", System.Data.DbType.String);
                        cmd.Parameters.Add("Pass", System.Data.DbType.String);
                        cmd.Parameters.Add("CD", System.Data.DbType.String);
                        // データ修正
                        cmd.Parameters["Name"].Value = textBox1.Text;
                        cmd.Parameters["Address"].Value = textBox2.Text;
                        cmd.Parameters["PhoneNumber"].Value = textBox3.Text;
                        cmd.Parameters["Birhtday"].Value = textBox4.Text;
                        cmd.Parameters["Pass"].Value = textBox6.Text;
                        cmd.Parameters["CD"].Value = textBox5.Text;
                        cmd.ExecuteNonQuery();
                        // コミット
                        trans.Commit();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainMenu f2 = new MainMenu();
            f2.Show();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            textBox5.ReadOnly = true;
            textBox6.PasswordChar = '*';
        }
        private bool isOpen = false;
        private void label8_Click(object sender, EventArgs e)
        {
            if (isOpen == false)
            {
                textBox6.PasswordChar = default;
                isOpen = true;
            }
            else if (isOpen == true)
            {
                textBox6.PasswordChar = '*';
                isOpen = false;
            }
        }
    }
}
