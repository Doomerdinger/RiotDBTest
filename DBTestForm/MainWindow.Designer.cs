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
            this.SearchButton = new System.Windows.Forms.Button();
            this.SummonerNameTextBox = new System.Windows.Forms.TextBox();
            this.RegionCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(12, 65);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(130, 23);
            this.SearchButton.TabIndex = 7;
            this.SearchButton.Text = "Search Summoner";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SummonerNameTextBox
            // 
            this.SummonerNameTextBox.Location = new System.Drawing.Point(12, 12);
            this.SummonerNameTextBox.MaxLength = 20;
            this.SummonerNameTextBox.Name = "SummonerNameTextBox";
            this.SummonerNameTextBox.Size = new System.Drawing.Size(130, 20);
            this.SummonerNameTextBox.TabIndex = 8;
            // 
            // RegionCombo
            // 
            this.RegionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RegionCombo.FormattingEnabled = true;
            this.RegionCombo.Items.AddRange(new object[] {
            "na",
            "euw"});
            this.RegionCombo.Location = new System.Drawing.Point(148, 11);
            this.RegionCombo.Name = "RegionCombo";
            this.RegionCombo.Size = new System.Drawing.Size(121, 21);
            this.RegionCombo.TabIndex = 9;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 120);
            this.Controls.Add(this.RegionCombo);
            this.Controls.Add(this.SummonerNameTextBox);
            this.Controls.Add(this.SearchButton);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SummonerNameTextBox;
        private System.Windows.Forms.ComboBox RegionCombo;
    }
}

