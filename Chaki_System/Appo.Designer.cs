
namespace ChakiSystem
{
    partial class Appo
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
            this.button1 = new System.Windows.Forms.Button();
            this.CalendarButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // institution
            // 
            this.institution.AutoSize = true;
            this.institution.Location = new System.Drawing.Point(37, 35);
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
            this.useInstitution.Location = new System.Drawing.Point(37, 58);
            this.useInstitution.Name = "useInstitution";
            this.useInstitution.Size = new System.Drawing.Size(151, 28);
            this.useInstitution.TabIndex = 1;
            this.useInstitution.SelectedIndexChanged += new System.EventHandler(this.useInstitution_SelectedIndexChanged);
            // 
            // Numbers
            // 
            this.Numbers.AutoSize = true;
            this.Numbers.Location = new System.Drawing.Point(37, 151);
            this.Numbers.Name = "Numbers";
            this.Numbers.Size = new System.Drawing.Size(39, 20);
            this.Numbers.TabIndex = 2;
            this.Numbers.Text = "番号";
            // 
            // NumberTxt
            // 
            this.NumberTxt.Location = new System.Drawing.Point(37, 174);
            this.NumberTxt.Name = "NumberTxt";
            this.NumberTxt.Size = new System.Drawing.Size(125, 27);
            this.NumberTxt.TabIndex = 3;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(228, 37);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(39, 20);
            this.Date.TabIndex = 4;
            this.Date.Text = "日時";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(694, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CalendarButton
            // 
            this.CalendarButton.Location = new System.Drawing.Point(359, 60);
            this.CalendarButton.Name = "CalendarButton";
            this.CalendarButton.Size = new System.Drawing.Size(27, 27);
            this.CalendarButton.TabIndex = 12;
            this.CalendarButton.Text = "▼";
            this.CalendarButton.UseVisualStyleBackColor = true;
            this.CalendarButton.Click += new System.EventHandler(this.CalendarButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(228, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 13;
            // 
            // Appo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CalendarButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.NumberTxt);
            this.Controls.Add(this.Numbers);
            this.Controls.Add(this.useInstitution);
            this.Controls.Add(this.institution);
            this.Name = "Appo";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CalendarButton;
        public System.Windows.Forms.TextBox textBox1;
    }
}