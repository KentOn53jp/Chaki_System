using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ChakiSystem
{
    public partial class AppoRes : Form
    {

        SQLiteConnection AppoResCon = new SQLiteConnection("Data Source = HCS_Appo.db");

        public AppoRes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 戻るボタン
        /// ひとつ前のボタンに戻る
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            App apo = new App();
            this.Visible = false;
            apo.Show();
        }

        /// <summary>
        /// テキストボックスを読み専用にする
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AppoRes_Load(object sender, EventArgs e)
        {
            NomberText.ReadOnly = true;
            ReserveDate.ReadOnly = true;
            ReserveTime.ReadOnly = true;
            Usejim.ReadOnly = true;

            NomberText.Text = MainMenu.CD;
        }

        /// <summary>
        /// 登録ボタン
        /// 
        /// データベースに登録する
        /// ダイアログを出して画面を遷移する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            //データベースに接続
            AppoResCon.Open();

            using (SQLiteTransaction trans = AppoResCon.BeginTransaction())
            {

                SQLiteCommand cmd = AppoResCon.CreateCommand();

                //会員番号、利用施設、予約日、予約時間を追加
                cmd.CommandText = "INSERT INTO Apo_product (CD, Jim, Date, Time) VALUES (@CD, @Jim, @Date, @Time)";

                // 会員番号・利用施設・予約日・予約時間のパラメータ定義
                cmd.Parameters.Add("CD", DbType.String);
                cmd.Parameters.Add("Jim", DbType.String);
                cmd.Parameters.Add("Date", DbType.String);
                cmd.Parameters.Add("Time", DbType.String);

                // 会員番号・利用施設・予約日・予約時間のパラメータ
                cmd.Parameters["CD"].Value = MainMenu.CD;
                cmd.Parameters["Jim"].Value = Usejim.Text;
                cmd.Parameters["Date"].Value = ReserveDate.Text;
                cmd.Parameters["Time"].Value = ReserveTime.Text;

                //実行
                cmd.ExecuteNonQuery();

                // コミット
                trans.Commit();
            }

            //登録する際の確認ダイアログ
            MessageBox.Show("登録しました", "登録");

            //メインメニューに遷移する
            this.Visible = false;
            MainMenu main = new MainMenu();
            main.Show();
        }
    }
}
