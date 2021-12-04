
namespace NFL.View
{
    partial class AddMatch
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
            this.components = new System.ComponentModel.Container();
            this.HomeClubNameLabel = new System.Windows.Forms.Label();
            this.AwayClubNameLabel = new System.Windows.Forms.Label();
            this.HomeFinalScoreLabel = new System.Windows.Forms.Label();
            this.AwayFinalScoreLabel = new System.Windows.Forms.Label();
            this.HomeNumberOfTDLabel = new System.Windows.Forms.Label();
            this.AwayNumberOfTDLabel = new System.Windows.Forms.Label();
            this.WeekLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.HomeClubNameTextBox = new System.Windows.Forms.TextBox();
            this.AwayClubNameTextBox = new System.Windows.Forms.TextBox();
            this.DoneButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.HomeFinalScoreTextBox = new System.Windows.Forms.TextBox();
            this.AwayFinalScoreTextBox = new System.Windows.Forms.TextBox();
            this.HomeNumberOfTDTextBox = new System.Windows.Forms.TextBox();
            this.AwayNumberOfTDTextBox = new System.Windows.Forms.TextBox();
            this.WeekNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.YearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.WeekNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeClubNameLabel
            // 
            this.HomeClubNameLabel.AutoSize = true;
            this.HomeClubNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HomeClubNameLabel.Location = new System.Drawing.Point(22, 14);
            this.HomeClubNameLabel.Name = "HomeClubNameLabel";
            this.HomeClubNameLabel.Size = new System.Drawing.Size(96, 21);
            this.HomeClubNameLabel.TabIndex = 0;
            this.HomeClubNameLabel.Text = "Hazai csapat";
            // 
            // AwayClubNameLabel
            // 
            this.AwayClubNameLabel.AutoSize = true;
            this.AwayClubNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AwayClubNameLabel.Location = new System.Drawing.Point(22, 60);
            this.AwayClubNameLabel.Name = "AwayClubNameLabel";
            this.AwayClubNameLabel.Size = new System.Drawing.Size(110, 21);
            this.AwayClubNameLabel.TabIndex = 1;
            this.AwayClubNameLabel.Text = "Vendég csapat";
            // 
            // HomeFinalScoreLabel
            // 
            this.HomeFinalScoreLabel.AutoSize = true;
            this.HomeFinalScoreLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HomeFinalScoreLabel.Location = new System.Drawing.Point(22, 103);
            this.HomeFinalScoreLabel.Name = "HomeFinalScoreLabel";
            this.HomeFinalScoreLabel.Size = new System.Drawing.Size(132, 21);
            this.HomeFinalScoreLabel.TabIndex = 2;
            this.HomeFinalScoreLabel.Text = "Hazai csapat pont";
            // 
            // AwayFinalScoreLabel
            // 
            this.AwayFinalScoreLabel.AutoSize = true;
            this.AwayFinalScoreLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AwayFinalScoreLabel.Location = new System.Drawing.Point(22, 150);
            this.AwayFinalScoreLabel.Name = "AwayFinalScoreLabel";
            this.AwayFinalScoreLabel.Size = new System.Drawing.Size(146, 21);
            this.AwayFinalScoreLabel.TabIndex = 3;
            this.AwayFinalScoreLabel.Text = "Vendég csapat pont";
            // 
            // HomeNumberOfTDLabel
            // 
            this.HomeNumberOfTDLabel.AutoSize = true;
            this.HomeNumberOfTDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HomeNumberOfTDLabel.Location = new System.Drawing.Point(22, 189);
            this.HomeNumberOfTDLabel.Name = "HomeNumberOfTDLabel";
            this.HomeNumberOfTDLabel.Size = new System.Drawing.Size(119, 21);
            this.HomeNumberOfTDLabel.TabIndex = 4;
            this.HomeNumberOfTDLabel.Text = "Hazai TD száma";
            // 
            // AwayNumberOfTDLabel
            // 
            this.AwayNumberOfTDLabel.AutoSize = true;
            this.AwayNumberOfTDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AwayNumberOfTDLabel.Location = new System.Drawing.Point(21, 229);
            this.AwayNumberOfTDLabel.Name = "AwayNumberOfTDLabel";
            this.AwayNumberOfTDLabel.Size = new System.Drawing.Size(133, 21);
            this.AwayNumberOfTDLabel.TabIndex = 5;
            this.AwayNumberOfTDLabel.Text = "Vendég TD száma";
            this.AwayNumberOfTDLabel.Click += new System.EventHandler(this.formValidation);
            // 
            // WeekLabel
            // 
            this.WeekLabel.AutoSize = true;
            this.WeekLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WeekLabel.Location = new System.Drawing.Point(22, 268);
            this.WeekLabel.Name = "WeekLabel";
            this.WeekLabel.Size = new System.Drawing.Size(34, 21);
            this.WeekLabel.TabIndex = 6;
            this.WeekLabel.Text = "Hét";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.YearLabel.Location = new System.Drawing.Point(22, 306);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(26, 21);
            this.YearLabel.TabIndex = 7;
            this.YearLabel.Text = "Év";
            // 
            // HomeClubNameTextBox
            // 
            this.HomeClubNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HomeClubNameTextBox.Location = new System.Drawing.Point(190, 11);
            this.HomeClubNameTextBox.Name = "HomeClubNameTextBox";
            this.HomeClubNameTextBox.PlaceholderText = "New England Patriots";
            this.HomeClubNameTextBox.Size = new System.Drawing.Size(372, 29);
            this.HomeClubNameTextBox.TabIndex = 1;
            this.HomeClubNameTextBox.TextChanged += new System.EventHandler(this.formValidation);
            // 
            // AwayClubNameTextBox
            // 
            this.AwayClubNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AwayClubNameTextBox.Location = new System.Drawing.Point(190, 57);
            this.AwayClubNameTextBox.Name = "AwayClubNameTextBox";
            this.AwayClubNameTextBox.PlaceholderText = "Las Vegas Raiders";
            this.AwayClubNameTextBox.Size = new System.Drawing.Size(372, 29);
            this.AwayClubNameTextBox.TabIndex = 2;
            this.AwayClubNameTextBox.TextChanged += new System.EventHandler(this.formValidation);
            // 
            // DoneButton
            // 
            this.DoneButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.DoneButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DoneButton.Location = new System.Drawing.Point(101, 360);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(97, 35);
            this.DoneButton.TabIndex = 9;
            this.DoneButton.Text = "Hozzáadás";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelButton.Location = new System.Drawing.Point(442, 360);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 35);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Mégse";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // HomeFinalScoreTextBox
            // 
            this.HomeFinalScoreTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HomeFinalScoreTextBox.Location = new System.Drawing.Point(190, 103);
            this.HomeFinalScoreTextBox.Name = "HomeFinalScoreTextBox";
            this.HomeFinalScoreTextBox.PlaceholderText = "24";
            this.HomeFinalScoreTextBox.Size = new System.Drawing.Size(372, 29);
            this.HomeFinalScoreTextBox.TabIndex = 3;
            this.HomeFinalScoreTextBox.TextChanged += new System.EventHandler(this.formValidation);
            // 
            // AwayFinalScoreTextBox
            // 
            this.AwayFinalScoreTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AwayFinalScoreTextBox.Location = new System.Drawing.Point(190, 147);
            this.AwayFinalScoreTextBox.Name = "AwayFinalScoreTextBox";
            this.AwayFinalScoreTextBox.PlaceholderText = "22";
            this.AwayFinalScoreTextBox.Size = new System.Drawing.Size(372, 29);
            this.AwayFinalScoreTextBox.TabIndex = 4;
            this.AwayFinalScoreTextBox.TextChanged += new System.EventHandler(this.formValidation);
            // 
            // HomeNumberOfTDTextBox
            // 
            this.HomeNumberOfTDTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HomeNumberOfTDTextBox.Location = new System.Drawing.Point(190, 186);
            this.HomeNumberOfTDTextBox.Name = "HomeNumberOfTDTextBox";
            this.HomeNumberOfTDTextBox.PlaceholderText = "3";
            this.HomeNumberOfTDTextBox.Size = new System.Drawing.Size(372, 29);
            this.HomeNumberOfTDTextBox.TabIndex = 5;
            this.HomeNumberOfTDTextBox.TextChanged += new System.EventHandler(this.formValidation);
            // 
            // AwayNumberOfTDTextBox
            // 
            this.AwayNumberOfTDTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AwayNumberOfTDTextBox.Location = new System.Drawing.Point(190, 226);
            this.AwayNumberOfTDTextBox.Name = "AwayNumberOfTDTextBox";
            this.AwayNumberOfTDTextBox.PlaceholderText = "2";
            this.AwayNumberOfTDTextBox.Size = new System.Drawing.Size(372, 29);
            this.AwayNumberOfTDTextBox.TabIndex = 6;
            this.AwayNumberOfTDTextBox.TextChanged += new System.EventHandler(this.formValidation);
            // 
            // WeekNumericUpDown
            // 
            this.WeekNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WeekNumericUpDown.Location = new System.Drawing.Point(190, 266);
            this.WeekNumericUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.WeekNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WeekNumericUpDown.Name = "WeekNumericUpDown";
            this.WeekNumericUpDown.Size = new System.Drawing.Size(372, 29);
            this.WeekNumericUpDown.TabIndex = 7;
            this.WeekNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // YearNumericUpDown
            // 
            this.YearNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.YearNumericUpDown.Location = new System.Drawing.Point(190, 304);
            this.YearNumericUpDown.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.YearNumericUpDown.Minimum = new decimal(new int[] {
            2011,
            0,
            0,
            0});
            this.YearNumericUpDown.Name = "YearNumericUpDown";
            this.YearNumericUpDown.Size = new System.Drawing.Size(372, 29);
            this.YearNumericUpDown.TabIndex = 8;
            this.YearNumericUpDown.Value = new decimal(new int[] {
            2011,
            0,
            0,
            0});
            // 
            // AddMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 419);
            this.Controls.Add(this.YearNumericUpDown);
            this.Controls.Add(this.WeekNumericUpDown);
            this.Controls.Add(this.AwayNumberOfTDTextBox);
            this.Controls.Add(this.HomeNumberOfTDTextBox);
            this.Controls.Add(this.AwayFinalScoreTextBox);
            this.Controls.Add(this.HomeFinalScoreTextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.AwayClubNameTextBox);
            this.Controls.Add(this.HomeClubNameTextBox);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.WeekLabel);
            this.Controls.Add(this.AwayNumberOfTDLabel);
            this.Controls.Add(this.HomeNumberOfTDLabel);
            this.Controls.Add(this.AwayFinalScoreLabel);
            this.Controls.Add(this.HomeFinalScoreLabel);
            this.Controls.Add(this.AwayClubNameLabel);
            this.Controls.Add(this.HomeClubNameLabel);
            this.Name = "AddMatch";
            this.Text = "NFL - Új Mérkőzés";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WeekNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HomeClubNameLabel;
        private System.Windows.Forms.Label AwayClubNameLabel;
        private System.Windows.Forms.Label HomeFinalScoreLabel;
        private System.Windows.Forms.Label AwayFinalScoreLabel;
        private System.Windows.Forms.Label HomeNumberOfTDLabel;
        private System.Windows.Forms.Label AwayNumberOfTDLabel;
        private System.Windows.Forms.Label WeekLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.TextBox HomeClubNameTextBox;
        private System.Windows.Forms.TextBox AwayClubNameTextBox;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox HomeFinalScoreTextBox;
        private System.Windows.Forms.TextBox AwayFinalScoreTextBox;
        private System.Windows.Forms.TextBox HomeNumberOfTDTextBox;
        private System.Windows.Forms.TextBox AwayNumberOfTDTextBox;
        private System.Windows.Forms.NumericUpDown WeekNumericUpDown;
        private System.Windows.Forms.NumericUpDown YearNumericUpDown;
    }
}