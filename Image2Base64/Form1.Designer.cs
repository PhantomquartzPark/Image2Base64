namespace Image2Base64
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.dropPanel = new System.Windows.Forms.Panel();
            this.base64TextBox = new System.Windows.Forms.TextBox();
            this.copyButton = new System.Windows.Forms.Button();
            this.preTextBox = new System.Windows.Forms.TextBox();
            this.preTextLabel = new System.Windows.Forms.Label();
            this.postTextLabel = new System.Windows.Forms.Label();
            this.postTextBox = new System.Windows.Forms.TextBox();
            this.reloadButton = new System.Windows.Forms.Button();
            this.urlCheckBox = new System.Windows.Forms.CheckBox();
            this.sampleText = new System.Windows.Forms.Label();
            this.wordsNumericBox = new System.Windows.Forms.NumericUpDown();
            this.optionGuideLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wordsNumericBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dropPanel
            // 
            this.dropPanel.AllowDrop = true;
            this.dropPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dropPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dropPanel.Location = new System.Drawing.Point(12, 12);
            this.dropPanel.Name = "dropPanel";
            this.dropPanel.Size = new System.Drawing.Size(760, 129);
            this.dropPanel.TabIndex = 0;
            this.dropPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.DropPanel_DragDrop);
            this.dropPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.DropPanel_DragEnter);
            // 
            // base64TextBox
            // 
            this.base64TextBox.HideSelection = false;
            this.base64TextBox.Location = new System.Drawing.Point(12, 300);
            this.base64TextBox.Multiline = true;
            this.base64TextBox.Name = "base64TextBox";
            this.base64TextBox.ReadOnly = true;
            this.base64TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.base64TextBox.Size = new System.Drawing.Size(760, 100);
            this.base64TextBox.TabIndex = 1;
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(697, 406);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(75, 23);
            this.copyButton.TabIndex = 2;
            this.copyButton.Text = "コピーする";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // preTextBox
            // 
            this.preTextBox.Location = new System.Drawing.Point(12, 196);
            this.preTextBox.Name = "preTextBox";
            this.preTextBox.Size = new System.Drawing.Size(763, 19);
            this.preTextBox.TabIndex = 3;
            // 
            // preTextLabel
            // 
            this.preTextLabel.AutoSize = true;
            this.preTextLabel.Location = new System.Drawing.Point(10, 181);
            this.preTextLabel.Name = "preTextLabel";
            this.preTextLabel.Size = new System.Drawing.Size(65, 12);
            this.preTextLabel.TabIndex = 4;
            this.preTextLabel.Text = "接頭テキスト";
            // 
            // postTextLabel
            // 
            this.postTextLabel.AutoSize = true;
            this.postTextLabel.Location = new System.Drawing.Point(13, 235);
            this.postTextLabel.Name = "postTextLabel";
            this.postTextLabel.Size = new System.Drawing.Size(65, 12);
            this.postTextLabel.TabIndex = 6;
            this.postTextLabel.Text = "接尾テキスト";
            // 
            // postTextBox
            // 
            this.postTextBox.Location = new System.Drawing.Point(12, 250);
            this.postTextBox.Name = "postTextBox";
            this.postTextBox.Size = new System.Drawing.Size(763, 19);
            this.postTextBox.TabIndex = 5;
            // 
            // reloadButton
            // 
            this.reloadButton.Location = new System.Drawing.Point(616, 406);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(75, 23);
            this.reloadButton.TabIndex = 7;
            this.reloadButton.Text = "リロードする";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // urlCheckBox
            // 
            this.urlCheckBox.AutoSize = true;
            this.urlCheckBox.Location = new System.Drawing.Point(12, 147);
            this.urlCheckBox.Name = "urlCheckBox";
            this.urlCheckBox.Size = new System.Drawing.Size(127, 16);
            this.urlCheckBox.TabIndex = 8;
            this.urlCheckBox.Text = "データURLで出力する";
            this.urlCheckBox.UseVisualStyleBackColor = true;
            // 
            // sampleText
            // 
            this.sampleText.AutoSize = true;
            this.sampleText.Location = new System.Drawing.Point(13, 285);
            this.sampleText.Name = "sampleText";
            this.sampleText.Size = new System.Drawing.Size(553, 12);
            this.sampleText.TabIndex = 9;
            this.sampleText.Text = "サンプルテキスト (全てを描画するわけではないため、Ctrl+A → Ctrl+C などではなく必ずコピーボタンでコピーを行うこと)";
            // 
            // wordsNumericBox
            // 
            this.wordsNumericBox.Location = new System.Drawing.Point(84, 404);
            this.wordsNumericBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.wordsNumericBox.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.wordsNumericBox.Name = "wordsNumericBox";
            this.wordsNumericBox.Size = new System.Drawing.Size(120, 19);
            this.wordsNumericBox.TabIndex = 10;
            this.wordsNumericBox.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // optionGuideLabel
            // 
            this.optionGuideLabel.AutoSize = true;
            this.optionGuideLabel.Location = new System.Drawing.Point(13, 406);
            this.optionGuideLabel.Name = "optionGuideLabel";
            this.optionGuideLabel.Size = new System.Drawing.Size(65, 12);
            this.optionGuideLabel.TabIndex = 11;
            this.optionGuideLabel.Text = "表示文字数";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.optionGuideLabel);
            this.Controls.Add(this.wordsNumericBox);
            this.Controls.Add(this.sampleText);
            this.Controls.Add(this.urlCheckBox);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.postTextLabel);
            this.Controls.Add(this.postTextBox);
            this.Controls.Add(this.preTextLabel);
            this.Controls.Add(this.preTextBox);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.base64TextBox);
            this.Controls.Add(this.dropPanel);
            this.Name = "Form1";
            this.Text = "Image 2 Base64";
            ((System.ComponentModel.ISupportInitialize)(this.wordsNumericBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel dropPanel;
        private System.Windows.Forms.TextBox base64TextBox;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.TextBox preTextBox;
        private System.Windows.Forms.Label preTextLabel;
        private System.Windows.Forms.Label postTextLabel;
        private System.Windows.Forms.TextBox postTextBox;
        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.CheckBox urlCheckBox;
        private System.Windows.Forms.Label sampleText;
        private System.Windows.Forms.NumericUpDown wordsNumericBox;
        private System.Windows.Forms.Label optionGuideLabel;
    }
}

