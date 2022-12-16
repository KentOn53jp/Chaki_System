using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ChakiSystem
{
    public partial class Search : Form
    {
        SQLiteConnection SearchCon = new SQLiteConnection("Data Source=HCS.db");

        private bool isOpen = false;

        public Search()
        {
            InitializeComponent();
        }

        /// <summary>
        /// パスワードで検索して、一致した場合は表示
        /// 一致しない場合はエラーメッセージを表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButton_Click(object sender, EventArgs e)
        {

            if (PassText.Text == "管理者")
            {
                DataTable dataTable = new DataTable();

                SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM t_product", SearchCon);

                adapter.Fill(dataTable);

                this.Visible = false;

                SearchResult searRes = new SearchResult();

                searRes.SearchData.DataSource = dataTable;
            }

            else
            {
                //データテーブルを生成
                DataTable dataTable = new DataTable();

                //PassTextが未入力の時エラー
                if (string.IsNullOrEmpty(PassText.Text))
                {
                    MessageBox.Show("パスワードを入力してください。", "未入力", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //検索したデータがなかった場合、エラーダイアログを表示
                else if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("パスワードが違います。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SearchCon.Open();
                    SQLiteCommand cmd = SearchCon.CreateCommand();

                    // SQLの実行　パスワードで検索
                    cmd.CommandText = "SELECT * FROM t_product WHERE Pass = @Pass";

                    //パスワードのパラメータ定義
                    cmd.Parameters.Add("Pass", DbType.String);

                    //パスワードのパラメータ
                    cmd.Parameters["Pass"].Value = PassText.Text;

                    dataTable.Clear();
                    dataTable.Load(cmd.ExecuteReader());

                    SearchResult searRes = new SearchResult();

                    searRes.SearchData.DataSource = dataTable;

                    SearchCon.Close();

                    this.Visible = false;
                    searRes.Show();
                }
            }
        }

        /// <summary>
        /// ボタンを押すとメインメニュー画面に戻る
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
        /// 目のラベルを押すと伏字になる
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
        /// この画面をロードしたときパスワードを伏字にする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Search_Load(object sender, EventArgs e)
        {
            PassText.PasswordChar = '*';
        }
    }
}
