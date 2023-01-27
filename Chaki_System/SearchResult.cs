using System;
using System.Windows.Forms;

namespace ChakiSystem
{
    public partial class SearchResult : Form
    {
        public SearchResult()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ボタンを押すとメインメニューに戻る
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainMenu main = new MainMenu();
            main.Show();
        }

        private void SearchResult_Load(object sender, EventArgs e)
        {
            SearchData.Columns["CD"].HeaderText = "会員番号";
            SearchData.Columns["Name"].HeaderText = "氏名";
            SearchData.Columns["Address"].HeaderText = "住所";
            SearchData.Columns["PhoneNumber"].HeaderText = "電話番号";
            SearchData.Columns["Birhtday"].HeaderText = "誕生日";
            SearchData.Columns["Pass"].HeaderText = "パスワード";
        }
    }
}
