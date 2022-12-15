
namespace ChakiSystem
{
    partial class RetryRegister
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
            this.BackButton = new System.Windows.Forms.Button();
            this.CompletionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.Phonetext = new System.Windows.Forms.TextBox();
            this.BirthText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PassText = new System.Windows.Forms.TextBox();
            this.EyeLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(129, 349);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(94, 29);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "戻る";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CompletionButton
            // 
            this.CompletionButton.Location = new System.Drawing.Point(591, 348);
            this.CompletionButton.Name = "CompletionButton";
            this.CompletionButton.Size = new System.Drawing.Size(94, 29);
            this.CompletionButton.TabIndex = 2;
            this.CompletionButton.Text = "OK";
            this.CompletionButton.UseVisualStyleBackColor = true;
            this.CompletionButton.Click += new System.EventHandler(this.CompletionButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "氏名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(574, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "住所";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "電話番号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(558, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "生年月日";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(165, 76);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(125, 27);
            this.NameText.TabIndex = 7;
            // 
            // AddressText
            // 
            this.AddressText.Location = new System.Drawing.Point(532, 76);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(125, 27);
            this.AddressText.TabIndex = 8;
            // 
            // Phonetext
            // 
            this.Phonetext.Location = new System.Drawing.Point(165, 193);
            this.Phonetext.Name = "Phonetext";
            this.Phonetext.Size = new System.Drawing.Size(125, 27);
            this.Phonetext.TabIndex = 9;
            // 
            // BirthText
            // 
            this.BirthText.Location = new System.Drawing.Point(532, 193);
            this.BirthText.Name = "BirthText";
            this.BirthText.Size = new System.Drawing.Size(125, 27);
            this.BirthText.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "パスワード";
            // 
            // PassText
            // 
            this.PassText.Location = new System.Drawing.Point(347, 265);
            this.PassText.Name = "PassText";
            this.PassText.Size = new System.Drawing.Size(125, 27);
            this.PassText.TabIndex = 12;
            // 
            // EyeLable
            // 
            this.EyeLable.AutoSize = true;
            this.EyeLable.Location = new System.Drawing.Point(478, 268);
            this.EyeLable.Name = "EyeLable";
            this.EyeLable.Size = new System.Drawing.Size(30, 20);
            this.EyeLable.TabIndex = 13;
            this.EyeLable.Text = "👀";
            this.EyeLable.Click += new System.EventHandler(this.EyeLable_Click);
            // 
            // RetryRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EyeLable);
            this.Controls.Add(this.PassText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BirthText);
            this.Controls.Add(this.Phonetext);
            this.Controls.Add(this.AddressText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CompletionButton);
            this.Controls.Add(this.BackButton);
            this.Name = "RetryRegister";
            this.Text = "登録確認画面";
            this.Load += new System.EventHandler(this.RetryRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CompletionButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox NameText;
        public System.Windows.Forms.TextBox AddressText;
        public System.Windows.Forms.TextBox Phonetext;
        public System.Windows.Forms.TextBox BirthText;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox PassText;
        private System.Windows.Forms.Label EyeLable;
    }
}