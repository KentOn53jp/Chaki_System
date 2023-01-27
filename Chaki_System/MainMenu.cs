using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ChakiSystem
{
    public partial class MainMenu : Form
    {
        SQLiteConnection MainCon = new SQLiteConnection("Data Source=HCS.db");
        SQLiteConnection ReserveMainCon = new SQLiteConnection("Data Source=HCS_Appo.db");

        public static string CD = "";

        public MainMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ログイン画面に戻るボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            //この画面を非表示にする
            this.Visible = false;

            //LoginMenuに遷移する
            LoginMenu log = new LoginMenu();
            log.Show();
        }

        /// <summary>
        /// 検索画面に遷移するボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            Search sear = new Search();
            sear.Show();
        }

        /// <summary>
        /// MainMenu画面をロードしたとき
        /// 
        /// 画面右上に番号を表示させる処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainMenu_Load(object sender, EventArgs e)
        {
            //DBに接続
            MainCon.Open();


            using (SQLiteTransaction trans = MainCon.BeginTransaction())
            {
                SQLiteCommand cmd = MainCon.CreateCommand();

                //SQL実行　名前で検索
                cmd.CommandText = "SELECT CD FROM t_product WHERE  Name = @Name";

                //名前のパラメータ定義
                cmd.Parameters.Add("Name", DbType.String);

                //名前パラメータ
                cmd.Parameters["Name"].Value = LoginMenu.Num;

                SQLiteDataReader reader = cmd.ExecuteReader();

                //データを読み込み、取得した値をCDに設定
                while(reader.Read())
                {
                    CD = reader.GetValue(0).ToString();
                }

                NumberLable.Text = CD;
            }
        }

        /// <summary>
        /// 修正画面に遷移するボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            Edit edit = new Edit();
            edit.Show();
        }

        /// <summary>
        /// 削除画面に遷移するボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            Delete del = new Delete();
            del.Show();
        }

        /// <summary>
        /// 予約ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AppoButton_Click(object sender, EventArgs e)
        {
            //データベース接続
            ReserveMainCon.Open();

            using (SQLiteCommand command = ReserveMainCon.CreateCommand())
            {
                //データベースを作成、会員番号・予約番号・利用施設・予約日・予約時間
                command.CommandText =
                    "create table IF NOT EXISTS Apo_product(CD INTEGER, reserve INTEGER PRIMARY KEY AUTOINCREMENT, Jim TEXT, Date TEXT, Time TEXT)";
                command.ExecuteNonQuery();
            }

            ReserveMainCon.Close();

            //予約画面に遷移
            App apo = new App();
            this.Visible = false;

            apo.NumberTxt.Text = NumberLable.Text;

            apo.Show();
        }
    }
}
