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

        private void BackButton_Click(object sender, EventArgs e)
        {
            App apo = new App();
            this.Visible = false;
            apo.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            AppoResDelCon.Open();

            if (string.IsNullOrEmpty(ResText.Text))
            {
                MessageBox.Show("入力されていない項目があります。", "未入力", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SQLiteCommand cmd = AppoResDelCon.CreateCommand();

                // DataTableを生成します。
                DataTable dataTable = new DataTable();

                // SQLの実行　パスワードで検索
                cmd.CommandText = "SELECT * FROM Apo_product WHERE CD = @CD AND reserve = @reserve";

                //パスワードのパラメータ定義
                cmd.Parameters.Add("CD", DbType.String);
                cmd.Parameters.Add("reserve", DbType.String);

                //パスワードのパラメータ
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
                    // 確認ダイアログ
                    DialogResult result = MessageBox.Show("本当に削除しますか？", "削除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    // 確認ダイアログのyesを選択した場合
                    if (result == DialogResult.Yes)
                    {

                        using (SQLiteTransaction trans = AppoResDelCon.BeginTransaction())
                        {
                            // SQL実行　CD検索
                            cmd.CommandText = "DELETE FROM Apo_product WHERE CD = @CD AND reserve = @reserve;";

                            // CDのパラメータ定義
                            cmd.Parameters.Add("CD", DbType.Int64);
                            cmd.Parameters.Add("reserve", DbType.String);

                            // CDのパラメータ
                            cmd.Parameters["CD"].Value = int.Parse(MainMenu.CD);
                            cmd.Parameters["reserve"].Value = ResText.Text;

                            cmd.ExecuteNonQuery();

                            trans.Commit();
                        }

                        MainMenu main = new MainMenu();
                        this.Visible = false;
                        main.Show();
                    }

                    //確認ダイアログのnoを選択した場合
                    else if (result == DialogResult.No)
                    {
                        MainMenu main = new MainMenu();
                        this.Visible = false;
                        main.Show();
                    }
                }
            }
            AppoResDelCon.Close();
        }
    }
}
