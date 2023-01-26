
namespace ChakiSystem
{
    partial class AppoRes
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
            this.Usejim = new System.Windows.Forms.TextBox();
            this.ReserveDate = new System.Windows.Forms.TextBox();
            this.NomberText = new System.Windows.Forms.TextBox();
            this.ReserveTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Usejim
            // 
            this.Usejim.Location = new System.Drawing.Point(310, 218);
            this.Usejim.Name = "Usejim";
            this.Usejim.Size = new System.Drawing.Size(145, 27);
            this.Usejim.TabIndex = 0;
            // 
            // ReserveDate
            // 
            this.ReserveDate.Location = new System.Drawing.Point(310, 102);
            this.ReserveDate.Name = "ReserveDate";
            this.ReserveDate.Size = new System.Drawing.Size(145, 27);
            this.ReserveDate.TabIndex = 1;
            // 
            // NomberText
            // 
            this.NomberText.Location = new System.Drawing.Point(12, 32);
            this.NomberText.Name = "NomberText";
            this.NomberText.Size = new System.Drawing.Size(39, 27);
            this.NomberText.TabIndex = 2;
            this.NomberText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ReserveTime
            // 
            this.ReserveTime.Location = new System.Drawing.Point(310, 158);
            this.ReserveTime.Name = "ReserveTime";
            this.ReserveTime.Size = new System.Drawing.Size(145, 27);
            this.ReserveTime.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "利用施設";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "予約日";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "番号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "予約時間";
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
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(310, 356);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(180, 70);
            this.RegisterButton.TabIndex = 9;
            this.RegisterButton.Text = "登録";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // AppoRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReserveTime);
            this.Controls.Add(this.NomberText);
            this.Controls.Add(this.ReserveDate);
            this.Controls.Add(this.Usejim);
            this.Name = "AppoRes";
            this.Text = "予約確認画面";
            this.Load += new System.EventHandler(this.AppoRes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BackButton;
        public System.Windows.Forms.TextBox NomberText;
        public System.Windows.Forms.TextBox Usejim;
        public System.Windows.Forms.TextBox ReserveTime;
        public System.Windows.Forms.TextBox ReserveDate;
        private System.Windows.Forms.Button RegisterButton;
    }
}