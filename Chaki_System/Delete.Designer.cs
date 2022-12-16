
namespace ChakiSystem
{
    partial class Delete
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
            this.PassText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.NumberText = new System.Windows.Forms.TextBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.EyeLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PassText
            // 
            this.PassText.Location = new System.Drawing.Point(312, 224);
            this.PassText.Name = "PassText";
            this.PassText.Size = new System.Drawing.Size(125, 27);
            this.PassText.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "パスワード";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "番号";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(671, 353);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(94, 29);
            this.BackButton.TabIndex = 9;
            this.BackButton.Text = "戻る";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // NumberText
            // 
            this.NumberText.Location = new System.Drawing.Point(312, 102);
            this.NumberText.Name = "NumberText";
            this.NumberText.Size = new System.Drawing.Size(125, 27);
            this.NumberText.TabIndex = 8;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(288, 300);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(191, 82);
            this.NextButton.TabIndex = 7;
            this.NextButton.Text = "次へ";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // EyeLable
            // 
            this.EyeLable.AutoSize = true;
            this.EyeLable.Location = new System.Drawing.Point(444, 225);
            this.EyeLable.Name = "EyeLable";
            this.EyeLable.Size = new System.Drawing.Size(30, 20);
            this.EyeLable.TabIndex = 13;
            this.EyeLable.Text = "👀";
            this.EyeLable.Click += new System.EventHandler(this.EyeLable_Click);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EyeLable);
            this.Controls.Add(this.PassText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NumberText);
            this.Controls.Add(this.NextButton);
            this.Name = "Delete";
            this.Text = "削除画面";
            this.Load += new System.EventHandler(this.Delete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox PassText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox NumberText;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label EyeLable;
    }
}