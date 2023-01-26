
namespace ChakiSystem
{
    partial class LoginMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginButton = new System.Windows.Forms.Button();
            this.NewNumberButton = new System.Windows.Forms.Button();
            this.NameText = new System.Windows.Forms.TextBox();
            this.PassText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EyeIcon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(307, 282);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(190, 69);
            this.LoginButton.TabIndex = 1;
            this.LoginButton.Text = "ログイン";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // NewNumberButton
            // 
            this.NewNumberButton.Location = new System.Drawing.Point(600, 376);
            this.NewNumberButton.Name = "NewNumberButton";
            this.NewNumberButton.Size = new System.Drawing.Size(188, 62);
            this.NewNumberButton.TabIndex = 2;
            this.NewNumberButton.Text = "新規会員登録";
            this.NewNumberButton.UseVisualStyleBackColor = true;
            this.NewNumberButton.Click += new System.EventHandler(this.NewNumberButton_Click);
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(335, 98);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(125, 27);
            this.NameText.TabIndex = 3;
            // 
            // PassText
            // 
            this.PassText.Location = new System.Drawing.Point(335, 178);
            this.PassText.Name = "PassText";
            this.PassText.Size = new System.Drawing.Size(125, 27);
            this.PassText.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "名前";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "パスワード";
            // 
            // EyeIcon
            // 
            this.EyeIcon.AutoSize = true;
            this.EyeIcon.Location = new System.Drawing.Point(467, 179);
            this.EyeIcon.Name = "EyeIcon";
            this.EyeIcon.Size = new System.Drawing.Size(30, 20);
            this.EyeIcon.TabIndex = 7;
            this.EyeIcon.Text = "👀";
            this.EyeIcon.Click += new System.EventHandler(this.EyeIcon_Click);
            // 
            // LoginMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EyeIcon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.NewNumberButton);
            this.Controls.Add(this.LoginButton);
            this.Name = "LoginMenu";
            this.Text = "ログインメニュー";
            this.Load += new System.EventHandler(this.LoginMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button NewNumberButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox PassText;
        private System.Windows.Forms.Label EyeIcon;
    }
}

