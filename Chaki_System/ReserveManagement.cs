using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;

namespace ChakiSystem
{
    public partial class ReserveManagement : Form
    {
        SQLiteConnection AppoResDelCon = new SQLiteConnection("Data Source=HCS_Appo.db");

        public ReserveManagement()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 戻るボタン
        /// 
        /// 予約画面に戻る
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
        /// 会員番号と予約番号で検索
        /// 
        /// 検索ヒットした場合、削除確認をしてから削除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            //データベース接続
            AppoResDelCon.Open();

            //未入力の場合エラーメッセージ
            if (string.IsNullOrEmpty(ResText.Text))
            {
                MessageBox.Show("入力されていない項目があります。", "未入力", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SQLiteCommand cmd = AppoResDelCon.CreateCommand();

                // DataTableを生成
                DataTable dataTable = new DataTable();

                // SQLの実行　会員番号と予約番号でで検索
                cmd.CommandText = "SELECT * FROM Apo_product WHERE CD = @CD AND reserve = @reserve";

                //会員番号・予約番号のパラメータ定義
                cmd.Parameters.Add("CD", DbType.String);
                cmd.Parameters.Add("reserve", DbType.String);

                //会員番号・予約番号のパラメータ
                cmd.Parameters["CD"].Value = MainMenu.CD;
                cmd.Parameters["reserve"].Value = ResText.Text;

                dataTable.Load(cmd.ExecuteReader());

                //検索した結果、何もなかった場合エラーメッセージ
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("検索結果がありません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // 削除確認ダイアログ
                    DialogResult result = MessageBox.Show("本当に削除しますか？", "削除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    // 確認ダイアログのyesを選択した場合
                    if (result == DialogResult.Yes)
                    {

                        using (SQLiteTransaction trans = AppoResDelCon.BeginTransaction())
                        {
                            // SQL実行　会員番号・予約番号の検索
                            cmd.CommandText = "DELETE FROM Apo_product WHERE CD = @CD AND reserve = @reserve;";

                            // 会員番号・予約番号のパラメータ定義
                            cmd.Parameters.Add("CD", DbType.Int64);
                            cmd.Parameters.Add("reserve", DbType.String);

                            // 会員番号・予約番号のパラメータ
                            cmd.Parameters["CD"].Value = int.Parse(MainMenu.CD);
                            cmd.Parameters["reserve"].Value = ResText.Text;

                            cmd.ExecuteNonQuery();

                            trans.Commit();
                        }

                        //メインメニューに遷移
                        MainMenu main = new MainMenu();
                        this.Visible = false;
                        main.Show();
                    }

                    //確認ダイアログのnoを選択した場合
                    else if (result == DialogResult.No)
                    {
                        //メインメニューに遷移
                        MainMenu main = new MainMenu();
                        this.Visible = false;
                        main.Show();
                    }
                }
            }
            AppoResDelCon.Close();
        }

        private void ReserveManagement_Load(object sender, EventArgs e)
        {
            ReserveView.Columns["CD"].HeaderText = "会員番号";
            ReserveView.Columns["reserve"].HeaderText = "予約番号";
            ReserveView.Columns["Jim"].HeaderText = "利用施設";
            ReserveView.Columns["Date"].HeaderText = "予約日";
            ReserveView.Columns["Time"].HeaderText = "予約時間";
        }
    }
}
