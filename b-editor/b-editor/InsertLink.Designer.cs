namespace b_editor
{
    partial class InsertLink
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
            textBox = new TextBox();
            okButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Location = new Point(12, 12);
            textBox.Name = "textBox";
            textBox.Size = new Size(499, 31);
            textBox.TabIndex = 0;
            // 
            // okButton
            // 
            okButton.Location = new Point(355, 48);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 59);
            okButton.TabIndex = 1;
            okButton.Text = "확인";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += OkButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(436, 49);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 59);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "취소";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;
            // 
            // InsertLink
            // 
            ClientSize = new Size(523, 119);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(textBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InsertLink";
            StartPosition = FormStartPosition.CenterParent;
            Text = "하이퍼링크 삽입";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }

    #endregion
}
