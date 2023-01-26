using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ChakiSystem
{
    public partial class RetryRegister : Form
    {
        //パスワードの表示、非表示フラグ
        private bool isOpen = false;

        SQLiteConnection RetryCon = new SQLiteConnection("Data Source=HCS.db");

        public RetryRegister()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 前の画面に戻るボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            //この画面を非表示にする
            this.Visible = false;

            //Register画面に遷移する
            Register regi = new Register();
            regi.Show();
        }

        /// <summary>
        /// この画面に遷移してきたとき
        /// テキストを変更できなくする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RetryRegister_Load(object sender, EventArgs e)
        {
            NameText.ReadOnly = true;
            AddressText.ReadOnly = true;
            Phonetext.ReadOnly = true;
            BirthText.ReadOnly = true;
            PassText.ReadOnly = true;
            PassText.PasswordChar = '*';
        }

        /// <summary>
        /// ボタンを押してダイアログを確認した後
        /// データベースに項目を追加する処理
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CompletionButton_Click(object sender, EventArgs e)
        {
            RetryCon.Open();
            using (SQLiteTransaction trans = RetryCon.BeginTransaction())
            {
                SQLiteCommand cmd = RetryCon.CreateCommand();

                // インサート　名前・住所・電話番号・生年月日・パスワードを追加する
                cmd.CommandText = "INSERT INTO t_product (Name, Address, PhoneNumber, birhtday, Pass) VALUES (@Name, @Address, @PhoneNumber, @Birhtday, @Pass)";

                // 名前・住所・電話番号・生年月日・パスワードのパラメータ定義
                cmd.Parameters.Add("Name", DbType.String);
                cmd.Parameters.Add("Address", DbType.String);
                cmd.Parameters.Add("PhoneNumber", DbType.String);
                cmd.Parameters.Add("Birhtday", DbType.String);
                cmd.Parameters.Add("Pass", DbType.String);

                // 名前・住所・電話番号・生年月日・パスワードのパラメータ
                cmd.Parameters["Name"].Value = NameText.Text;
                cmd.Parameters["Address"].Value = AddressText.Text;
                cmd.Parameters["PhoneNumber"].Value = Phonetext.Text;
                cmd.Parameters["Birhtday"].Value = BirthText.Text;
                cmd.Parameters["Pass"].Value = PassText.Text;

                cmd.ExecuteNonQuery();

                // コミット
                trans.Commit();
            }

            //登録する際の確認ダイアログ
            MessageBox.Show("登録しました", "登録");

            this.Visible = false;

            LoginMenu log = new LoginMenu();

            //ログイン画面に遷移
            log.Show();
        }

        /// <summary>
        /// 目のラベルを押すと伏字を解除する
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
    }
}
