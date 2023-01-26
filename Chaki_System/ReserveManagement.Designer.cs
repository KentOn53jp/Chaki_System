
namespace ChakiSystem
{
    partial class ReserveManagement
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
            this.ReserveView = new System.Windows.Forms.DataGridView();
            this.BackButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ResText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ReserveView)).BeginInit();
            this.SuspendLayout();
            // 
            // ReserveView
            // 
            this.ReserveView.AllowUserToAddRows = false;
            this.ReserveView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReserveView.Location = new System.Drawing.Point(12, 67);
            this.ReserveView.Name = "ReserveView";
            this.ReserveView.RowHeadersVisible = false;
            this.ReserveView.RowHeadersWidth = 51;
            this.ReserveView.RowTemplate.Height = 29;
            this.ReserveView.Size = new System.Drawing.Size(442, 188);
            this.ReserveView.TabIndex = 0;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(360, 409);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(94, 29);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "戻る";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(12, 409);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(134, 29);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "予約取り消し";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ResText
            // 
            this.ResText.Location = new System.Drawing.Point(12, 376);
            this.ResText.Name = "ResText";
            this.ResText.Size = new System.Drawing.Size(56, 27);
            this.ResText.TabIndex = 3;
            // 
            // ReserveManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 450);
            this.Controls.Add(this.ResText);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ReserveView);
            this.Name = "ReserveManagement";
            this.Text = "予約管理画面";
            ((System.ComponentModel.ISupportInitialize)(this.ReserveView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView ReserveView;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox ResText;
    }
}