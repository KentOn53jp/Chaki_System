using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ChakiSystem
{
    public partial class App : Form
    {
        SQLiteConnection ReserveAppoCon = new SQLiteConnection("Data Source=HCS_Appo.db");

        public App()
        {
            InitializeComponent();
        }

        private void Appo_Load(object sender, EventArgs e)
        {
            NumberTxt.ReadOnly = true;

            useInstitution.SelectedIndex = 0;

            reserveTime.SelectedIndex = 0;

            NumberTxt.Text = MainMenu.CD;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            this.Visible = false;
            main.Show();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            AppoRes apoRes = new AppoRes();

            //apoRes.NomberText.Text = NumberTxt.Text;
            apoRes.Usejim.Text = useInstitution.Text;
            apoRes.ReserveTime.Text = reserveTime.Text;
            apoRes.ReserveDate.Text = reserveDate.Value.ToLongDateString();

            if (string.IsNullOrEmpty(reserveDate.Text) || string.IsNullOrEmpty(reserveTime.Text) ||
                 string.IsNullOrEmpty(useInstitution.Text))
            {
                MessageBox.Show("入力されていない項目があります。", "未入力", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                apoRes.Show();
                this.Visible = false;
            }
        }

        private void ReserveControl_Click(object sender, EventArgs e)
        {
            ReserveManagement ResMana = new ReserveManagement();

            ReserveAppoCon.Open();
            SQLiteCommand cmd = ReserveAppoCon.CreateCommand();

            // DataTableを生成します。
            DataTable dataTable = new DataTable();

            //SQL実行　番号とパスワードで検索
            //cmd.CommandText = "SELECT * FROM t_product WHERE  CD = @CD AND Pass = @Pass";

            // SQLの実行　パスワードで検索
            cmd.CommandText = "SELECT * FROM Apo_product WHERE CD = @CD";

            //パスワードのパラメータ定義
            cmd.Parameters.Add("CD", DbType.String);

            //パスワードのパラメータ
            cmd.Parameters["CD"].Value = MainMenu.CD;

            dataTable.Load(cmd.ExecuteReader());

            //検索した結果、何もなかった場合エラーメッセージ
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("検索結果がありません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ResMana.ReserveView.DataSource = dataTable;

                this.Visible = false;

                ResMana.Show();
            }
        }
    }
}
