
namespace ChakiSystem
{
    partial class App
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
            this.institution = new System.Windows.Forms.Label();
            this.useInstitution = new System.Windows.Forms.ComboBox();
            this.Numbers = new System.Windows.Forms.Label();
            this.NumberTxt = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.reserveDate = new System.Windows.Forms.DateTimePicker();
            this.reserveTime = new System.Windows.Forms.ComboBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ReserveControl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // institution
            // 
            this.institution.AutoSize = true;
            this.institution.Location = new System.Drawing.Point(268, 202);
            this.institution.Name = "institution";
            this.institution.Size = new System.Drawing.Size(69, 20);
            this.institution.TabIndex = 0;
            this.institution.Text = "利用施設";
            // 
            // useInstitution
            // 
            this.useInstitution.FormattingEnabled = true;
            this.useInstitution.Items.AddRange(new object[] {
            "HCSスポーツクラブ",
            "コナミスポーツクラブ",
            "サンシャインスポーツクラブ"});
            this.useInstitution.Location = new System.Drawing.Point(268, 225);
            this.useInstitution.Name = "useInstitution";
            this.useInstitution.Size = new System.Drawing.Size(151, 28);
            this.useInstitution.TabIndex = 1;
            // 
            // Numbers
            // 
            this.Numbers.AutoSize = true;
            this.Numbers.Location = new System.Drawing.Point(12, 6);
            this.Numbers.Name = "Numbers";
            this.Numbers.Size = new System.Drawing.Size(39, 20);
            this.Numbers.TabIndex = 2;
            this.Numbers.Text = "番号";
            // 
            // NumberTxt
            // 
            this.NumberTxt.Location = new System.Drawing.Point(12, 30);
            this.NumberTxt.Name = "NumberTxt";
            this.NumberTxt.Size = new System.Drawing.Size(39, 27);
            this.NumberTxt.TabIndex = 3;
            this.NumberTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(268, 65);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(54, 20);
            this.Date.TabIndex = 4;
            this.Date.Text = "予約日";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(694, 409);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(94, 29);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "戻る";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // reserveDate
            // 
            this.reserveDate.Location = new System.Drawing.Point(268, 88);
            this.reserveDate.Name = "reserveDate";
            this.reserveDate.Size = new System.Drawing.Size(163, 27);
            this.reserveDate.TabIndex = 15;
            // 
            // reserveTime
            // 
            this.reserveTime.FormattingEnabled = true;
            this.reserveTime.Items.AddRange(new object[] {
            "11時",
            "12時",
            "13時",
            "14時",
            "15時",
            "16時",
            "17時",
            "18時"});
            this.reserveTime.Location = new System.Drawing.Point(268, 157);
            this.reserveTime.Name = "reserveTime";
            this.reserveTime.Size = new System.Drawing.Size(151, 28);
            this.reserveTime.TabIndex = 16;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(268, 375);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(228, 63);
            this.NextButton.TabIndex = 17;
            this.NextButton.Text = "登録";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "予約時間";
            // 
            // ReserveControl
            // 
            this.ReserveControl.Location = new System.Drawing.Point(666, 144);
            this.ReserveControl.Name = "ReserveControl";
            this.ReserveControl.Size = new System.Drawing.Size(122, 53);
            this.ReserveControl.TabIndex = 19;
            this.ReserveControl.Text = "予約済み確認";
            this.ReserveControl.UseVisualStyleBackColor = true;
            this.ReserveControl.Click += new System.EventHandler(this.ReserveControl_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReserveControl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.reserveTime);
            this.Controls.Add(this.reserveDate);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.NumberTxt);
            this.Controls.Add(this.Numbers);
            this.Controls.Add(this.useInstitution);
            this.Controls.Add(this.institution);
            this.Name = "App";
            this.Text = "予約画面";
            this.Load += new System.EventHandler(this.Appo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label institution;
        private System.Windows.Forms.ComboBox useInstitution;
        private System.Windows.Forms.Label Numbers;
        private System.Windows.Forms.Label Date;
        public System.Windows.Forms.TextBox NumberTxt;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.DateTimePicker reserveDate;
        private System.Windows.Forms.ComboBox reserveTime;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReserveControl;
    }
}