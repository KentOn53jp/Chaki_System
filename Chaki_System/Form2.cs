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
                        "create table IF NOT EXISTS t_product(CD INTEGER  PRIMARY KEY AUTOINCREMENT, Name TEXT, Numbers INTEGER, address TEXT, PhoneNomber INTEGER,  birhtday INTEGER)";
                    command.ExecuteNonQuery();
                }
                con.Close();

                //この画面を非表示にする
                this.Visible = false;

                //Form1に遷移する
                Form3 f3 = new Form3();
                f3.Show();
            }
        }
    }
}
