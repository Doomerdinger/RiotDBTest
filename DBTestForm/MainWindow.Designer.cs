namespace DBTestForm
{
    partial class MainWindow
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
            this.AddRuneButton = new System.Windows.Forms.Button();
            this.runeIDTextbox = new System.Windows.Forms.TextBox();
            this.runeNumTextbox = new System.Windows.Forms.TextBox();
            this.slotIDTextbox = new System.Windows.Forms.TextBox();
            this.runeIDLabel = new System.Windows.Forms.Label();
            this.runeNumLabel = new System.Windows.Forms.Label();
            this.slotIDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddRuneButton
            // 
            this.AddRuneButton.Location = new System.Drawing.Point(166, 179);
            this.AddRuneButton.Name = "AddRuneButton";
            this.AddRuneButton.Size = new System.Drawing.Size(75, 23);
            this.AddRuneButton.TabIndex = 0;
            this.AddRuneButton.Text = "Add Rune";
            this.AddRuneButton.UseVisualStyleBackColor = true;
            this.AddRuneButton.Click += new System.EventHandler(this.AddRuneButton_Click);
            // 
            // runeIDTextbox
            // 
            this.runeIDTextbox.Location = new System.Drawing.Point(76, 12);
            this.runeIDTextbox.MaxLength = 5;
            this.runeIDTextbox.Name = "runeIDTextbox";
            this.runeIDTextbox.Size = new System.Drawing.Size(100, 20);
            this.runeIDTextbox.TabIndex = 1;
            // 
            // runeNumTextbox
            // 
            this.runeNumTextbox.Location = new System.Drawing.Point(76, 66);
            this.runeNumTextbox.MaxLength = 5;
            this.runeNumTextbox.Name = "runeNumTextbox";
            this.runeNumTextbox.Size = new System.Drawing.Size(100, 20);
            this.runeNumTextbox.TabIndex = 2;
            // 
            // slotIDTextbox
            // 
            this.slotIDTextbox.Location = new System.Drawing.Point(76, 115);
            this.slotIDTextbox.MaxLength = 3;
            this.slotIDTextbox.Name = "slotIDTextbox";
            this.slotIDTextbox.Size = new System.Drawing.Size(100, 20);
            this.slotIDTextbox.TabIndex = 3;
            // 
            // runeIDLabel
            // 
            this.runeIDLabel.AutoSize = true;
            this.runeIDLabel.Location = new System.Drawing.Point(27, 19);
            this.runeIDLabel.Name = "runeIDLabel";
            this.runeIDLabel.Size = new System.Drawing.Size(39, 13);
            this.runeIDLabel.TabIndex = 4;
            this.runeIDLabel.Text = "runeID";
            // 
            // runeNumLabel
            // 
            this.runeNumLabel.AutoSize = true;
            this.runeNumLabel.Location = new System.Drawing.Point(27, 72);
            this.runeNumLabel.Name = "runeNumLabel";
            this.runeNumLabel.Size = new System.Drawing.Size(50, 13);
            this.runeNumLabel.TabIndex = 5;
            this.runeNumLabel.Text = "runeNum";
            // 
            // slotIDLabel
            // 
            this.slotIDLabel.AutoSize = true;
            this.slotIDLabel.Location = new System.Drawing.Point(27, 122);
            this.slotIDLabel.Name = "slotIDLabel";
            this.slotIDLabel.Size = new System.Drawing.Size(34, 13);
            this.slotIDLabel.TabIndex = 6;
            this.slotIDLabel.Text = "slotID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.slotIDLabel);
            this.Controls.Add(this.runeNumLabel);
            this.Controls.Add(this.runeIDLabel);
            this.Controls.Add(this.slotIDTextbox);
            this.Controls.Add(this.runeNumTextbox);
            this.Controls.Add(this.runeIDTextbox);
            this.Controls.Add(this.AddRuneButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddRuneButton;
        private System.Windows.Forms.TextBox runeIDTextbox;
        private System.Windows.Forms.TextBox runeNumTextbox;
        private System.Windows.Forms.TextBox slotIDTextbox;
        private System.Windows.Forms.Label runeIDLabel;
        private System.Windows.Forms.Label runeNumLabel;
        private System.Windows.Forms.Label slotIDLabel;
    }
}

