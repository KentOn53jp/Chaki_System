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

            MessageBox.Show("変更を保存しました", "保存");
            this.Visible = false;
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            textBox5.ReadOnly = true;
        }
    }
}
