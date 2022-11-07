using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Chaki_System
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //この画面を非表示にする
            this.Visible = false;

            //Form1に遷移する
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
