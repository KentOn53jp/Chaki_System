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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //この画面を非表示にする
            this.Visible = false;

            //Form1に遷移する
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var con = new SQLiteConnection("Data Source=HCS.db"))
            {
                con.Open();
                using (SQLiteCommand command = con.CreateCommand())
                {
                    command.CommandText =
                        "create table IF NOT EXISTS t_product(CD INTEGER  PRIMARY KEY AUTOINCREMENT, Name TEXT, Numbers INTEGER, Address TEXT, PhoneNumber INTEGER,  Birhtday INTEGER, Pass TEXT)";
                    command.ExecuteNonQuery();
                }
                con.Close();

                //この画面を非表示にする
                this.Visible = false;

                //Form3に遷移する
                Form3 f3 = new Form3();
                f3.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //この画面を非表示にする
            this.Visible = false;

            //Form5に遷移する
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=HCS.db"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT CD FROM t_product";
                    // DataTableを生成します。
                    var dataTable = new DataTable();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //この画面を非表示にする
            this.Visible = false;

            //Form5に遷移する
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //この画面を非表示にする
            this.Visible = false;

            //Form5に遷移する
            Form9 f9 = new Form9();
            f9.Show();
        }
    }
}
