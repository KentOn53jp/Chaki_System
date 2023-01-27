using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;

namespace ChakiSystem
{
    public partial class DeleteResult : Form
    {
        SQLiteConnection DeleteCon = new SQLiteConnection("Data Source=HCS.db");

        public DeleteResult()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ボタンを押すと確認ダイアログで確認
        /// Yesだと、削除し
        /// Noだと、Delete.csに遷移する。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CompleteButton_Click(object sender, EventArgs e)
        {
            //Login
            LoginMenu log = new LoginMenu();

            Delete del = new Delete();

            // 確認ダイアログ
            DialogResult result = MessageBox.Show("本当に削除しますか？", "削除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // 確認ダイアログのyesを選択した場合
            if(result == DialogResult.Yes)
            {
                DeleteCon.Open();

                using (SQLiteTransaction trans = DeleteCon.BeginTransaction())
                {
                    SQLiteCommand cmd = DeleteCon.CreateCommand();

                    // SQL実行　CD検索
                    cmd.CommandText = "DELETE FROM t_product WHERE CD = @CD;";

                    // CDのパラメータ定義
                    cmd.Parameters.Add("CD", DbType.Int64);

                    // CDのパラメータ
                    cmd.Parameters["CD"].Value = int.Parse(NumberText.Text);

                    cmd.ExecuteNonQuery();

                    trans.Commit();
                }
                
                this.Visible = false;
                log.Show();
            }

            //確認ダイアログのnoを選択した場合
            else if(result == DialogResult.No)
            {
                this.Visible = false;
                del.Show();
            }
        }

        /// <summary>
        /// ボタンを押すとDelete.csに遷移する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Delete del = new Delete();
            del.Show();
        }

        private void DeleteResult_Load(object sender, EventArgs e)
        {
            NumberText.ReadOnly = true;
        }
    }
}
