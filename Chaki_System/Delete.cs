using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ChakiSystem
{
    public partial class Delete : Form
    {
        private bool isOpen = false;

        SQLiteConnection DeleteCon = new SQLiteConnection("Data Source=HCS.db");

        public Delete()
        {
            InitializeComponent();
        }

        /// <summary>
        /// メインメニューに戻るボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainMenu main = new MainMenu();
            main.Show();
        }

        /// <summary>
        /// ボタンを押すと次の画面に進む。
        /// 
        /// 検索結果がなかった場合にエラー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            DeleteResult f10 = new DeleteResult();
            f10.NumberText.Text = NumberText.Text;

            DeleteCon.Open();
            SQLiteCommand cmd = DeleteCon.CreateCommand();

            // DataTableを生成します。
            var dataTable = new DataTable();

            // SQLの実行 CDとパスワードで検索
            cmd.CommandText = "SELECT * FROM t_product WHERE  CD = @CD AND Pass = @Pass";

            // CD・パスワードのパラメータ定義
            cmd.Parameters.Add("CD", DbType.String);
            cmd.Parameters.Add("Pass", DbType.String);

            // CD・パスワードのパラメータ
            cmd.Parameters["CD"].Value = NumberText.Text;
            cmd.Parameters["Pass"].Value = PassText.Text;

            dataTable.Clear();

            dataTable.Load(cmd.ExecuteReader());

            // 検索した結果がなかった場合エラーメッセージ
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("パスワードが違います。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                f10.DeletDataView.DataSource = dataTable;
                this.Visible = false;
                f10.Show();
            }

            DeleteCon.Close();
        }

        /// <summary>
        /// 目のラベルを押すと伏字を解除
        /// もう一度押すと伏字になる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EyeLable_Click(object sender, EventArgs e)
        {
            if (isOpen == false)
            {
                PassText.PasswordChar = default;
                isOpen = true;
            }
            else if (isOpen == true)
            {
                PassText.PasswordChar = '*';
                isOpen = false;
            }
        }

        /// <summary>
        /// パスワードの初期状態を伏字にする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Delete_Load(object sender, EventArgs e)
        {
            PassText.PasswordChar = '*';
        }
    }
}
