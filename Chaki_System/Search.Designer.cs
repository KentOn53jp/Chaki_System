
namespace ChakiSystem
{
    partial class Search
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
            this.label1 = new System.Windows.Forms.Label();
            this.PassText = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.Backbutton = new System.Windows.Forms.Button();
            this.EyeLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "パスワード";
            // 
            // PassText
            // 
            this.PassText.Location = new System.Drawing.Point(288, 141);
            this.PassText.Name = "PassText";
            this.PassText.Size = new System.Drawing.Size(125, 27);
            this.PassText.TabIndex = 1;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(305, 380);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(158, 58);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "検索";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // Backbutton
            // 
            this.Backbutton.Location = new System.Drawing.Point(694, 409);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(94, 29);
            this.Backbutton.TabIndex = 3;
            this.Backbutton.Text = "戻る";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // EyeLable
            // 
            this.EyeLable.AutoSize = true;
            this.EyeLable.Location = new System.Drawing.Point(419, 144);
            this.EyeLable.Name = "EyeLable";
            this.EyeLable.Size = new System.Drawing.Size(30, 20);
            this.EyeLable.TabIndex = 4;
            this.EyeLable.Text = "👀";
            this.EyeLable.Click += new System.EventHandler(this.EyeLable_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EyeLable);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.PassText);
            this.Controls.Add(this.label1);
            this.Name = "Search";
            this.Text = "検索入力画面";
            this.Load += new System.EventHandler(this.Search_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button Backbutton;
        public System.Windows.Forms.TextBox PassText;
        private System.Windows.Forms.Label EyeLable;
    }
}