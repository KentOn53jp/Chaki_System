using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ChakiSystem
{
    public partial class EditResult : Form
    {
        SQLiteConnection EditCon = new SQLiteConnection("Data Source=HCS.db");

        private bool isOpen = false;

        public EditResult()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ボタンを押すと修正が完了される。
        /// すべての項目を変更する。
        /// 
        /// 空欄がある場合にエラー
        /// 結果がなかった場合エラー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeepButton_Click(object sender, EventArgs e)
        {
            //データベース接続
            EditCon.Open();

            using (SQLiteTransaction trans = EditCon.BeginTransaction())
            {
                SQLiteCommand cmd = EditCon.CreateCommand();

                DataTable dataTable = new DataTable();

                MainMenu main = new MainMenu();

                //すべてのテキストボックスのうち、一つでも空欄のテキストボックスがあれば、エラーメッセージを表示する。
                if (string.IsNullOrEmpty(NameText.Text) || string.IsNullOrEmpty(AddressText.Text) || string.IsNullOrEmpty(PhoneText.Text)
                    || string.IsNullOrEmpty(birthText.Text) ||  string.IsNullOrEmpty(PassText.Text) || string.IsNullOrEmpty(PassResultText.Text))
                {
                    MessageBox.Show("入力されていない項目があります。", "未入力", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //結果が何もなかった場合にエラーメッセージを表示
                else if (PassText.Text != PassResultText.Text)
                {
                    MessageBox.Show("パスワードが違います。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("変更を保存しました", "保存");

                    // SQL実行　CDで検索
                    cmd.CommandText = "UPDATE t_product set Name = @Name, Address = @Address, PhoneNumber = @PhoneNumber, Birhtday = @Birhtday, Pass = @Pass WHERE CD = @CD";

                    // 名前・住所・電話番号・生年月日・パスワード・CDのパラメータの定義
                    cmd.Parameters.Add("Name", DbType.String);
                    cmd.Parameters.Add("Address", DbType.String);
                    cmd.Parameters.Add("PhoneNumber", DbType.String);
                    cmd.Parameters.Add("Birhtday", DbType.String);
                    cmd.Parameters.Add("Pass", DbType.String);
                    cmd.Parameters.Add("CD", DbType.String);

                    // 名前・住所・電話番号・生年月日・パスワード・CDのパラメータ
                    cmd.Parameters["Name"].Value = NameText.Text;
                    cmd.Parameters["Address"].Value = AddressText.Text;
                    cmd.Parameters["PhoneNumber"].Value = PhoneText.Text;
                    cmd.Parameters["Birhtday"].Value = birthText.Text;
                    cmd.Parameters["Pass"].Value = PassText.Text;
                    cmd.Parameters["CD"].Value = CDText.Text;

                    cmd.ExecuteNonQuery();

                    // コミット
                    trans.Commit();

                    this.Visible = false;
                    main.Show();
                }
            }
            EditCon.Close();
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
        /// パスワードの初期状態をを伏字にする
        /// CDは変更できないように読み込みのみにする
        /// 
        /// データグリッドビューのカラム名を変更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditResult_Load(object sender, EventArgs e)
        {
            CDText.ReadOnly = true;
            PassText.PasswordChar = '*';
            PassResultText.PasswordChar = '*';

            EditDataView.Columns["CD"].HeaderText = "会員番号";
            EditDataView.Columns["Name"].HeaderText = "氏名";
            EditDataView.Columns["Address"].HeaderText = "住所";
            EditDataView.Columns["PhoneNumber"].HeaderText = "電話番号";
            EditDataView.Columns["Birhtday"].HeaderText = "誕生日";
            EditDataView.Columns["Pass"].HeaderText = "パスワード";
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

        private void PhoneText_KeyPress(object sender, KeyPressEventArgs e)
        {
            //バックスペースが押された時は有効（Deleteキーも有効）
            if (e.KeyChar == '\b')
            {
                return;
            }

            //数値0～9以外が押された時はイベントをキャンセルする
            if ((e.KeyChar < '0' || '9' < e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void birthText_KeyPress(object sender, KeyPressEventArgs e)
        {
            //バックスペースが押された時は有効（Deleteキーも有効）
            if (e.KeyChar == '\b')
            {
                return;
            }

            //数値0～9以外が押された時はイベントをキャンセルする
            if ((e.KeyChar < '0' || '9' < e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
