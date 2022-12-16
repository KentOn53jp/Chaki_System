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

        SQLiteConnection LoginCon = new SQLiteConnection("Data Source = HCS.db");

        //NameTextに入力された文字を入れる変数
        public static string Num = "";
        public LoginMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ログインボタンを押したら
        /// メインメニューへ飛ぶ。
        /// 
        /// 入力された名前とパスワードがあっているか確認する
        /// 間違っている場合はメインメニューには飛べない。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            //MainMenu Formを取得
            MainMenu main = new MainMenu();

            //DBに接続
            LoginCon.Open();

            SQLiteCommand cmd = LoginCon.CreateCommand();

            DataTable dataTable = new DataTable();

            //SQL実行 名前とパスワードで検索
            cmd.CommandText = "SELECT * FROM t_product WHERE  Name = @Name AND Pass = @Pass";
            //名前とパスワードのパラメータ定義
            cmd.Parameters.Add("Name", DbType.String);
            cmd.Parameters.Add("Pass", DbType.String);
            //名前・パスワードのパラメータ
            cmd.Parameters["Name"].Value = NameText.Text;
            cmd.Parameters["Pass"].Value = PassText.Text;

            dataTable.Clear();
            dataTable.Load(cmd.ExecuteReader());

            LoginCon.Close();

            //どちらかのテキストボックスが空白の場合、エラーダイアログを表示
            if (string.IsNullOrEmpty(NameText.Text) || string.IsNullOrEmpty(PassText.Text)) 
            {
                MessageBox.Show("氏名、パスワードを入力してください。", "未入力", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //検索したデータがなかった場合、エラーダイアログを表示
            else if(dataTable.Rows.Count == 0)
            {
                MessageBox.Show("パスワードが違います。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //検索したデータが一致した場合、次の画面に飛ぶ
            else
            {
                Num = NameText.Text;
                this.Visible = false;
                main.Show();
            }
        }
        
        /// <summary>
        /// 新規登録画面に飛ぶボタン
        /// 
        /// テーブルが存在していないときにテーブルを作る
        /// 名前・住所・電話番号・生年月日・パスワードの項目を作成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewNumberButton_Click(object sender, EventArgs e)
        {
            LoginCon.Open();

            using (SQLiteCommand command = LoginCon.CreateCommand())
            {
                command.CommandText =
                    "create table IF NOT EXISTS t_product(CD INTEGER  PRIMARY KEY AUTOINCREMENT, Name TEXT, Address TEXT, PhoneNumber INTEGER,  Birhtday INTEGER, Pass TEXT)";
                command.ExecuteNonQuery();
            }
            LoginCon.Close();

            //この画面を非表示にする
            this.Visible = false;

            //Form3に遷移する
            Register f3 = new Register();
            f3.Show();
        }

        /// <summary>
        /// LoginMenuをロードしたとき
        /// 
        /// パスワードを伏字にする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginMenu_Load(object sender, EventArgs e)
        {
            PassText.PasswordChar = '*';
        }

        /// <summary>
        /// 目のアイコンを押すと伏字を解除
        /// もう一度押すと伏字に戻る
        /// 
        /// フラグで管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EyeIcon_Click(object sender, EventArgs e)
        {
            //isOpenがfalseの場合
            if (isOpen == false)
            {
                PassText.PasswordChar = default;
                isOpen = true;
            }
            //isopenがtrueの場合
            else if (isOpen == true)
            {
                PassText.PasswordChar = '*';
                isOpen = false;
            }
        }
    }
}
