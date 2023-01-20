using System;
using System.Windows.Forms;

namespace ChakiSystem
{
    public partial class Register : Form
    {
        //パスワードの表示、非表示フラグ
        private bool isOpen = false;

        public Register()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ボタンを押すと
        /// ログイン画面に遷移する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            //この画面を非表示にする
            this.Visible = false;

            //LoginMenuに遷移する
            LoginMenu log = new LoginMenu();
            log.Show();
        }

        /// <summary>
        /// 登録確認画面に遷移するボタン
        /// 
        /// パスワードの欄が４文字以下の場合＆
        /// パスワードが間違っている場合＆
        /// 入力されていない項目がある場合にエラーメッセージを出す
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            int Max = 3;
            if(PassText.TextLength < Max)
            {
                MessageBox.Show("４文字以上入力してください。","エラー", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            if(PassText.Text != RetryText.Text)
            {
                MessageBox.Show("パスワードが間違っています。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(string.IsNullOrEmpty(NameText.Text) || string.IsNullOrEmpty(AddressText.Text) || string.IsNullOrEmpty(PhoneText.Text)
                        || string.IsNullOrEmpty(BirthText.Text) || string.IsNullOrEmpty(RetryText.Text))
            {
                MessageBox.Show("入力されていない項目があります。", "未入力", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //この画面を非表示にする
                this.Visible = false;

                //Form1に遷移する
                RetryRegister retry = new RetryRegister();
                retry.Show();

                //登録画面のテキストを確認画面のテキストに入れる
                retry.NameText.Text = NameText.Text;
                retry.AddressText.Text = AddressText.Text;
                retry.Phonetext.Text = PhoneText.Text;
                retry.BirthText.Text = BirthText.Text;
                retry.PassText.Text = PassText.Text;
            }
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
        /// 登録画面に遷移してきたとき、パスワードを伏字にしておく処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Register_Load(object sender, EventArgs e)
        {
            PassText.PasswordChar = '*';
            RetryText.PasswordChar = '*';
            PhoneText.MaxLength = 12;
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

        private void BirthText_KeyPress(object sender, KeyPressEventArgs e)
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
