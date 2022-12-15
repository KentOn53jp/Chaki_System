using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ChakiSystem
{
    public partial class Edit : Form
    {
        SQLiteConnection EditCon = new SQLiteConnection("Data Source=HCS.db");

        private bool isOpen = false;

        public Edit()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 番号とパスワードが合っている場合に次の画面に遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {

            Form8 f8 = new Form8();
            f8.textBox5.Text = NumberText.Text;

            //データベース接続
            EditCon.Open();

            SQLiteCommand cmd = EditCon.CreateCommand();

            DataTable dataTable = new DataTable();

            //SQL実行　番号とパスワードで検索
            cmd.CommandText = "SELECT * FROM t_product WHERE  CD = @CD AND Pass = @Pass";

            //パラメーターセット
            cmd.Parameters.Add("CD", DbType.String);
            cmd.Parameters.Add("Pass", DbType.String);

            cmd.Parameters["CD"].Value = NumberText.Text;
            cmd.Parameters["Pass"].Value = PassText.Text;

            dataTable.Clear();
            dataTable.Load(cmd.ExecuteReader());

            //検索した結果、何もなかった場合エラーメッセージ
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("パスワードが違います。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                f8.dataGridView1.DataSource = dataTable;
                this.Visible = false;
                f8.Show();
            }

            EditCon.Close();
            
        }

        /// <summary>
        /// ボタンを押したらメインメニューに戻る
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
        /// 目のラベルを押すと伏字解除
        /// もう一度押すと伏字
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
        /// この画面に遷移してきたときパスワードを伏字にする。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Edit_Load(object sender, EventArgs e)
        {
            PassText.PasswordChar = '*';
        }
    }
}
