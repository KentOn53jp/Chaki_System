using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ChakiSystem
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu f2 = new MainMenu();
            Form9 f9 = new Form9();
            DialogResult result = MessageBox.Show("本当に削除しますか？", "削除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == System.Windows.Forms.DialogResult.Yes)
            {
                using (SQLiteConnection con = new SQLiteConnection("Data Source=HCS.db"))
                {
                    con.Open();
                    using (SQLiteTransaction trans = con.BeginTransaction())
                    {
                        SQLiteCommand cmd = con.CreateCommand();
                        // インサート
                        cmd.CommandText = "DELETE FROM t_product WHERE CD = @CD;";
                        // パラメータセット
                        cmd.Parameters.Add("CD", System.Data.DbType.Int64);
                        // データ削除
                        cmd.Parameters["CD"].Value = int.Parse(textBox5.Text);
                        cmd.ExecuteNonQuery();
                        // コミット
                        trans.Commit();
                    }
                }
                this.Visible = false;
                f2.Show();
            }
            else if(result == System.Windows.Forms.DialogResult.No)
            {
                this.Visible = false;
                f9.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form9 f9 = new Form9();
            f9.Show();
        }
    }
}
