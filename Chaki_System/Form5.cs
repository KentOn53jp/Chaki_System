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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form6 f6 = new Form6();
            f6.Show();

            using (SQLiteConnection con = new SQLiteConnection("Data Source=HCS.db"))
            {
                con.Open();
                SQLiteCommand cmd = con.CreateCommand();

                // DataTableを生成します。
                var dataTable = new DataTable();

                // SQLの実行
                cmd.CommandText = "SELECT * FROM t_product WHERE Name = @Name or CD = @CD";
                cmd.Parameters.Add("Name", System.Data.DbType.String);
                cmd.Parameters.Add("CD", System.Data.DbType.String);
                cmd.Parameters["Name"].Value = textBox1.Text;
                cmd.Parameters["CD"].Value = textBox1.Text;

                dataTable.Clear();
                dataTable.Load(cmd.ExecuteReader());

                f6.dataGridView1.DataSource = dataTable;

                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

    }
}
