using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ChakiSystem
{
    public partial class MainMenu : Form
    {
        SQLiteConnection MainCon = new SQLiteConnection("Data Source=HCS.db");
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

            Search f5 = new Search();
            f5.Show();
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
                //CDにnullを設定
                string CD = null;

                SQLiteCommand cmd = MainCon.CreateCommand();

                //SQL実行　名前で検索
                cmd.CommandText = "SELECT CD FROM t_product WHERE  Name = @Name";

                //名前のパラメーターセット
                cmd.Parameters.Add("Name", DbType.String);
                cmd.Parameters["Name"].Value = LoginMenu.Num;

                SQLiteDataReader reader = cmd.ExecuteReader();

                //データを読み込み、取得した値を
                while(reader.Read())
                {
                    CD = reader.GetValue(0).ToString();
                    NumberLable.Text = CD;
                }
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

            Edit f7 = new Edit();
            f7.Show();
        }

        /// <summary>
        /// 削除画面に遷移するボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            Form9 f9 = new Form9();
            f9.Show();
        }
    }
}
