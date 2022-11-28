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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            Form8 f8 = new Form8();
            //f8.Show();
            f8.textBox5.Text = textBox1.Text;

            using (SQLiteConnection con = new SQLiteConnection("Data Source=HCS.db"))
            {
                con.Open();
                SQLiteCommand cmd = con.CreateCommand();

                // DataTableを生成します。
                var dataTable = new DataTable();

                // SQLの実行
                cmd.CommandText = "SELECT * FROM t_product WHERE  CD = @CD AND Pass = @Pass";
                //cmd.CommandText = "SELECT * FROM t_product WHERE EXISTS (SELECT Pass FROM t_product WHERE CD = @CD AND Pass = @Pass)";
                //パラメータの型を設定
                cmd.Parameters.Add("CD", System.Data.DbType.String);
                cmd.Parameters.Add("Pass", System.Data.DbType.String);

                cmd.Parameters["CD"].Value = textBox1.Text;
                cmd.Parameters["Pass"].Value = textBox3.Text;

                dataTable.Clear();
                dataTable.Load(cmd.ExecuteReader());

                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("パスワードが違います。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    f8.dataGridView1.DataSource = dataTable;
                    this.Visible = false;
                    f8.Show();
                }

                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
