using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ChakiSystem
{
    public partial class App : Form
    {
        SQLiteConnection ReserveAppoCon = new SQLiteConnection("Data Source=HCS_Appo.db");

        public App()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 会員番号を読み専用
        /// 
        /// プルダウンの項目の初期値設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Appo_Load(object sender, EventArgs e)
        {
            NumberTxt.ReadOnly = true;

            useInstitution.SelectedIndex = 0;

            reserveTime.SelectedIndex = 0;

            NumberTxt.Text = MainMenu.CD;
        }

        /// <summary>
        /// メインメニューに遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            this.Visible = false;
            main.Show();
        }

        /// <summary>
        /// 入力した項目を予約確認画面に引き継ぐ
        /// 
        /// 予約確認画面に遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            AppoRes apoRes = new AppoRes();

            apoRes.Usejim.Text = useInstitution.Text;
            apoRes.ReserveTime.Text = reserveTime.Text;
            apoRes.ReserveDate.Text = reserveDate.Value.ToLongDateString();

            //入力項目に未入力があるか
            if (string.IsNullOrEmpty(reserveDate.Text) || string.IsNullOrEmpty(reserveTime.Text) ||
                 string.IsNullOrEmpty(useInstitution.Text))
            {
                MessageBox.Show("入力されていない項目があります。", "未入力", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //未入力がない場合遷移
            else
            {
                apoRes.Show();
                this.Visible = false;
            }
        }

        /// <summary>
        /// 予約管理画面に遷移
        /// 予約がない場合には遷移しない
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReserveControl_Click(object sender, EventArgs e)
        {
            ReserveManagement ResMana = new ReserveManagement();

            //データベース接続
            ReserveAppoCon.Open();

            SQLiteCommand cmd = ReserveAppoCon.CreateCommand();

            // DataTableを生成します。
            DataTable dataTable = new DataTable();

            // SQLの実行　会員番号で検索
            cmd.CommandText = "SELECT * FROM Apo_product WHERE CD = @CD";

            //会員番号のパラメータ定義
            cmd.Parameters.Add("CD", DbType.String);

            //会員番号のパラメータ
            cmd.Parameters["CD"].Value = MainMenu.CD;

            dataTable.Load(cmd.ExecuteReader());

            //検索した結果、何もなかった場合エラーメッセージ
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("検索結果がありません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //検索ヒットした場合遷移
            else
            {
                ResMana.ReserveView.DataSource = dataTable;
                this.Visible = false;
                ResMana.Show();
            }
        }
    }
}
