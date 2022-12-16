
namespace ChakiSystem
{
    partial class DeleteResult
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
            this.NumberText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.CompleteButton = new System.Windows.Forms.Button();
            this.DeletDataView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DeletDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // NumberText
            // 
            this.NumberText.Location = new System.Drawing.Point(19, 155);
            this.NumberText.Name = "NumberText";
            this.NumberText.Size = new System.Drawing.Size(125, 27);
            this.NumberText.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "CD";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(674, 385);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(94, 29);
            this.BackButton.TabIndex = 26;
            this.BackButton.Text = "戻る";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CompleteButton
            // 
            this.CompleteButton.Location = new System.Drawing.Point(251, 367);
            this.CompleteButton.Name = "CompleteButton";
            this.CompleteButton.Size = new System.Drawing.Size(253, 64);
            this.CompleteButton.TabIndex = 25;
            this.CompleteButton.Text = "削除";
            this.CompleteButton.UseVisualStyleBackColor = true;
            this.CompleteButton.Click += new System.EventHandler(this.CompleteButton_Click);
            // 
            // DeletDataView
            // 
            this.DeletDataView.AllowUserToAddRows = false;
            this.DeletDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeletDataView.Location = new System.Drawing.Point(19, 19);
            this.DeletDataView.Name = "DeletDataView";
            this.DeletDataView.RowHeadersVisible = false;
            this.DeletDataView.RowHeadersWidth = 51;
            this.DeletDataView.RowTemplate.Height = 29;
            this.DeletDataView.Size = new System.Drawing.Size(763, 101);
            this.DeletDataView.TabIndex = 16;
            // 
            // DeleteResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NumberText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CompleteButton);
            this.Controls.Add(this.DeletDataView);
            this.Name = "DeleteResult";
            this.Text = "削除確認画面";
            ((System.ComponentModel.ISupportInitialize)(this.DeletDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox NumberText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CompleteButton;
        public System.Windows.Forms.DataGridView DeletDataView;
    }
}