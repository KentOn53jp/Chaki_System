
namespace ChakiSystem
{
    partial class Calender
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CalendarSet = new System.Windows.Forms.MonthCalendar();
            this.SetButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CalendarSet
            // 
            this.CalendarSet.Location = new System.Drawing.Point(18, 18);
            this.CalendarSet.Name = "CalendarSet";
            this.CalendarSet.TabIndex = 0;
            // 
            // SetButton
            // 
            this.SetButton.Location = new System.Drawing.Point(18, 238);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(94, 29);
            this.SetButton.TabIndex = 1;
            this.SetButton.Text = "決定";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(172, 238);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(94, 29);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "戻る";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ComboBox
            // 
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Items.AddRange(new object[] {
            "11時",
            "12時",
            "13時",
            "14時",
            "15時",
            "16時",
            "17時",
            "18時"});
            this.ComboBox.Location = new System.Drawing.Point(278, 18);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(151, 28);
            this.ComboBox.TabIndex = 3;
            // 
            // Calender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 286);
            this.Controls.Add(this.ComboBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SetButton);
            this.Controls.Add(this.CalendarSet);
            this.Name = "Calender";
            this.Text = "日付入力";
            this.Load += new System.EventHandler(this.Calender_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar CalendarSet;
        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ComboBox ComboBox;
    }
}