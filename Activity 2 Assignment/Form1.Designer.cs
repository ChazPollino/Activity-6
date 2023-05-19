namespace Activity_2_Assignment
{
    partial class MultiplyBy2
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.MultiplyTextbox = new System.Windows.Forms.TextBox();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.TitleLabel.Location = new System.Drawing.Point(304, 63);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(680, 93);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Multiply By Two!";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.DescriptionLabel.Location = new System.Drawing.Point(111, 272);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(506, 75);
            this.DescriptionLabel.TabIndex = 1;
            this.DescriptionLabel.Text = "Enter A Number";
            this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AnswerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.AnswerLabel.Location = new System.Drawing.Point(167, 402);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(942, 146);
            this.AnswerLabel.TabIndex = 2;
            this.AnswerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MultiplyTextbox
            // 
            this.MultiplyTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.MultiplyTextbox.Location = new System.Drawing.Point(841, 272);
            this.MultiplyTextbox.Name = "MultiplyTextbox";
            this.MultiplyTextbox.Size = new System.Drawing.Size(324, 80);
            this.MultiplyTextbox.TabIndex = 3;
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.MultiplyButton.Location = new System.Drawing.Point(-6, 667);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(368, 146);
            this.MultiplyButton.TabIndex = 4;
            this.MultiplyButton.Text = "Multiply";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.ExitButton.Location = new System.Drawing.Point(942, 667);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(350, 146);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.ClearButton.Location = new System.Drawing.Point(452, 667);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(396, 146);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // MultiplyBy2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1300, 1002);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.MultiplyTextbox);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Name = "MultiplyBy2";
            this.Text = "Multiply By 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.TextBox MultiplyTextbox;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ClearButton;
    }
}

