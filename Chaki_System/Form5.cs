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

            if (textBox1.Text == "管理者")
            {
                using (SQLiteConnection con = new SQLiteConnection("Data Source=HCS.db"))
                {
                    var dataTable = new DataTable();
                    var adapter = new SQLiteDataAdapter("SELECT * FROM t_product", con);
                    adapter.Fill(dataTable);
                    f6.dataGridView1.DataSource = dataTable;
                }
            }

            else
            {
                using (SQLiteConnection con = new SQLiteConnection("Data Source=HCS.db"))
                {
                    con.Open();
                    SQLiteCommand cmd = con.CreateCommand();

                    // DataTableを生成します。
                    var dataTable = new DataTable();

                    // SQLの実行
                    cmd.CommandText = "SELECT * FROM t_product WHERE Pass = @Pass";
                    //パラメータの型を設定
                    cmd.Parameters.Add("Pass", System.Data.DbType.String);
                    //textbox1
                    cmd.Parameters["Pass"].Value = textBox1.Text;

                    dataTable.Clear();
                    dataTable.Load(cmd.ExecuteReader());

                    f6.dataGridView1.DataSource = dataTable;

                    con.Close();

                    this.Visible = false;
                    f6.Show();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainMenu f2 = new MainMenu();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private bool isOpen = false;
        private void label2_Click(object sender, EventArgs e)
        {
            if (isOpen == false)
            {
                textBox1.PasswordChar = default;
                isOpen = true;
            }
            else if (isOpen == true)
            {
                textBox1.PasswordChar = '*';
                isOpen = false;
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';
        }
    }
}
