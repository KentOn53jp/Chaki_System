using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ChakiSystem
{
    public partial class LoginMenu : Form
    {
        //パスワードの表示、非表示フラグ
        private bool isOpen = false;

        //textbox1に入力された文字を入れる変数
        public static string Num = "";
        public LoginMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ログインボタンを押したら
        /// メインメニューへ飛びます。
        /// 
        /// 入力された名前とパスワードを
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            MainMenu f2 = new MainMenu();

            using (SQLiteConnection con = new SQLiteConnection("Data Source=HCS.db"))
            {
                con.Open();
                SQLiteCommand cmd = con.CreateCommand();

                var dataTable = new DataTable();

                cmd.CommandText = "SELECT * FROM t_product WHERE  Name = @Name AND Pass = @Pass";

                cmd.Parameters.Add("Name", DbType.String);
                cmd.Parameters.Add("Pass", DbType.String);

                cmd.Parameters["Name"].Value = textBox1.Text;
                cmd.Parameters["Pass"].Value = textBox2.Text;

                dataTable.Clear();
                dataTable.Load(cmd.ExecuteReader());

                con.Close();

                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text)) 
                {
                    MessageBox.Show("氏名、パスワードを入力してください。", "未入力", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("パスワードが違います。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Num = textBox1.Text;
                    this.Visible = false;
                    f2.Show();
                }
            }
        }

        private void NewNumberButton_Click(object sender, EventArgs e)
        {
            using (var con = new SQLiteConnection("Data Source=HCS.db"))
            {
                con.Open();
                using (SQLiteCommand command = con.CreateCommand())
                {
                    command.CommandText =
                        "create table IF NOT EXISTS t_product(CD INTEGER  PRIMARY KEY AUTOINCREMENT, Name TEXT, Address TEXT, PhoneNumber INTEGER,  Birhtday INTEGER, Pass TEXT)";
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

        private void LoginMenu_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }


        private void label3_Click_2(object sender, EventArgs e)
        {
            if (isOpen == false)
            {
                textBox2.PasswordChar = default;
                isOpen = true;
            }
            else if (isOpen == true)
            {
                textBox2.PasswordChar = '*';
                isOpen = false;
            }
        }
    }
}
