using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ChakiSystem
{
    public partial class AppoRes : Form
    {

        SQLiteConnection AppoResCon = new SQLiteConnection("Data Source = HCS_Appo.db");

        public AppoRes()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            App apo = new App();
            this.Visible = false;
            apo.Show();
        }

        private void AppoRes_Load(object sender, EventArgs e)
        {
            NomberText.ReadOnly = true;
            ReserveDate.ReadOnly = true;
            ReserveTime.ReadOnly = true;
            Usejim.ReadOnly = true;

            NomberText.Text = MainMenu.CD;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            AppoResCon.Open();

            using (SQLiteTransaction trans = AppoResCon.BeginTransaction())
            {
                SQLiteCommand cmd = AppoResCon.CreateCommand();

                cmd.CommandText = "INSERT INTO Apo_product (CD, Jim, Date, Time) VALUES (@CD, @Jim, @Date, @Time)";

                // 名前・住所・電話番号・生年月日・パスワードのパラメータ定義
                cmd.Parameters.Add("CD", DbType.String);
                cmd.Parameters.Add("Jim", DbType.String);
                cmd.Parameters.Add("Date", DbType.String);
                cmd.Parameters.Add("Time", DbType.String);

                // 名前・住所・電話番号・生年月日・パスワードのパラメータ
                cmd.Parameters["CD"].Value = MainMenu.CD;
                cmd.Parameters["Jim"].Value = Usejim.Text;
                cmd.Parameters["Date"].Value = ReserveDate.Text;
                cmd.Parameters["Time"].Value = ReserveTime.Text;

                cmd.ExecuteNonQuery();

                // コミット
                trans.Commit();
            }

            //登録する際の確認ダイアログ
            MessageBox.Show("登録しました", "登録");

            this.Visible = false;
            MainMenu main = new MainMenu();

            main.Show();
        }
    }
}
