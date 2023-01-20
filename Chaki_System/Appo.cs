using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChakiSystem
{
    public partial class Appo : Form
    {
        public Appo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// コンボボックスのアイテムが変更されたときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void useInstitution_SelectedIndexChanged(object sender, EventArgs e)
        {
            useInstitution.SelectedIndex = -1;
        }

        private void Appo_Load(object sender, EventArgs e)
        {
            NumberTxt.ReadOnly = true;

            useInstitution.SelectedIndex = 0;
        }

        private void CalendarButton_Click(object sender, EventArgs e)
        {
            Calender.inputCalende(this, textBox1);
        }
    }
}
