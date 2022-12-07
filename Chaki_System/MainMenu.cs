using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ChakiSystem
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //この画面を非表示にする
            this.Visible = false;

            //Form1に遷移する
            LoginMenu f1 = new LoginMenu();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var con = new SQLiteConnection("Data Source=HCS.db"))
            {
                con.Open();
                using (SQLiteCommand command = con.CreateCommand())
                {
                    //テーブル作成
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
            this.Visible = false;

            Form5 f5 = new Form5();
            f5.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=HCS.db"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    string CD = null;
                    SQLiteCommand cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT CD FROM t_product WHERE  Name = @Name";
                    cmd.Parameters.Add("Name", System.Data.DbType.String);
                    cmd.Parameters["Name"].Value = LoginMenu.Num;

                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while(reader.Read())
                    {
                        CD = reader.GetValue(0).ToString();
                        label3.Text = CD;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            Form7 f7 = new Form7();
            f7.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            Form9 f9 = new Form9();
            f9.Show();
        }
    }
}
