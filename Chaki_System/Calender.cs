using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChakiSystem
{
    public partial class Calender : Form
    {
        //public string SelectDate;

        //private string SelectTime;

        public Calender()
        {
            InitializeComponent();
        }

        private void Calender_Load(object sender, EventArgs e)
        {
            //CalendarSet.ShowTodayCircle = false;
            //ComboBox.SelectedIndex = 0;

            //CalendarSet.MaxSelectionCount = 1;

            //if (SelectDate.Length > 0)
            //{
            //    DateTime dateTime;
            //    if (DateTime.TryParse(SelectDate, out dateTime))
            //    {
            //        CalendarSet.SelectionStart = dateTime;
            //    }
            //}
        }

        App apo = new App();

        private void SetButton_Click(object sender, EventArgs e)
        {
            //SelectDate = CalendarSet.SelectionStart.ToString("yyyy/MM/dd");
            //this.Close();;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            //this.Close();
        }


        public static void inputCalende(IWin32Window owner, TextBox textBox)
        {
            //Calender calender = new Calender();

            //calender.SelectDate = textBox.Text;

            //calender.ShowDialog(owner);

            //if (!textBox.Text.Equals(calender.SelectDate))
            //{
            //    textBox.Text = calender.SelectDate;
            //}

        }

        public static void inputTime(IWin32Window owner, TextBox Time)
        {
            //Calender calender = new Calender();

            //calender.SelectTime = Time.Text;

            //calender.ShowDialog(owner);

            //if (!Time.Text.Equals(calender.SelectTime))
            //{
            //    Time.Text = calender.SelectTime;
            //}
        }
    }
}
