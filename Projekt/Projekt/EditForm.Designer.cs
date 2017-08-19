namespace Projekt
{
    partial class EditForm
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
            this.DiscountComboBox = new System.Windows.Forms.ComboBox();
            this.DiscountLabel = new System.Windows.Forms.Label();
            this.EmailButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DiscountComboBox
            // 
            this.DiscountComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DiscountComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DiscountComboBox.FormattingEnabled = true;
            this.DiscountComboBox.Items.AddRange(new object[] {
            "10%",
            "20%",
            "30%"});
            this.DiscountComboBox.Location = new System.Drawing.Point(178, 87);
            this.DiscountComboBox.Name = "DiscountComboBox";
            this.DiscountComboBox.Size = new System.Drawing.Size(100, 24);
            this.DiscountComboBox.TabIndex = 11;
            // 
            // DiscountLabel
            // 
            this.DiscountLabel.AutoSize = true;
            this.DiscountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DiscountLabel.Location = new System.Drawing.Point(12, 91);
            this.DiscountLabel.Name = "DiscountLabel";
            this.DiscountLabel.Size = new System.Drawing.Size(58, 20);
            this.DiscountLabel.TabIndex = 12;
            this.DiscountLabel.Text = "Rabat";
            // 
            // EmailButton
            // 
            this.EmailButton.Location = new System.Drawing.Point(109, 186);
            this.EmailButton.Name = "EmailButton";
            this.EmailButton.Size = new System.Drawing.Size(169, 59);
            this.EmailButton.TabIndex = 13;
            this.EmailButton.Text = "Wyślij Email";
            this.EmailButton.UseVisualStyleBackColor = true;
            this.EmailButton.Click += new System.EventHandler(this.EmailButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(349, 310);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmailButton);
            this.Controls.Add(this.DiscountLabel);
            this.Controls.Add(this.DiscountComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox DataTextBox;
        private System.Windows.Forms.ComboBox DiscountComboBox;
        private System.Windows.Forms.Label DiscountLabel;
        private System.Windows.Forms.Button EmailButton;
        private System.Windows.Forms.Label label1;
    }
}