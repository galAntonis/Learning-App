namespace ekpLog
{
    partial class Test
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
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.questionTxt = new System.Windows.Forms.Label();
            this.questionContentTxt = new System.Windows.Forms.Label();
            this.answer1Radio = new System.Windows.Forms.RadioButton();
            this.answer2Radio = new System.Windows.Forms.RadioButton();
            this.answer3Radio = new System.Windows.Forms.RadioButton();
            this.checkButton = new System.Windows.Forms.Button();
            this.answer4Radio = new System.Windows.Forms.RadioButton();
            this.countTxt = new System.Windows.Forms.Label();
            this.wrongTxt = new System.Windows.Forms.Label();
            this.correctTxt = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.scoreTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 16;
            this.kryptonPalette1.HeaderGroup.StateCommon.PrimaryHeaderPadding = new System.Windows.Forms.Padding(10);
            // 
            // questionTxt
            // 
            this.questionTxt.AutoSize = true;
            this.questionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.questionTxt.Location = new System.Drawing.Point(51, 25);
            this.questionTxt.Name = "questionTxt";
            this.questionTxt.Size = new System.Drawing.Size(77, 17);
            this.questionTxt.TabIndex = 0;
            this.questionTxt.Text = "Ερώτηση:";
            // 
            // questionContentTxt
            // 
            this.questionContentTxt.AutoSize = true;
            this.questionContentTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.questionContentTxt.Location = new System.Drawing.Point(134, 25);
            this.questionContentTxt.MaximumSize = new System.Drawing.Size(500, 0);
            this.questionContentTxt.Name = "questionContentTxt";
            this.questionContentTxt.Size = new System.Drawing.Size(477, 17);
            this.questionContentTxt.TabIndex = 1;
            this.questionContentTxt.Text = "Ποιο από τα παρακάτω δεν επιστρέφει το ίδιο αποτέλεσμα με τα υπόλοιπα;";
            this.questionContentTxt.Click += new System.EventHandler(this.questionContentTxt_Click);
            // 
            // answer1Radio
            // 
            this.answer1Radio.AutoSize = true;
            this.answer1Radio.Location = new System.Drawing.Point(137, 111);
            this.answer1Radio.MaximumSize = new System.Drawing.Size(500, 0);
            this.answer1Radio.Name = "answer1Radio";
            this.answer1Radio.Size = new System.Drawing.Size(96, 17);
            this.answer1Radio.TabIndex = 2;
            this.answer1Radio.TabStop = true;
            this.answer1Radio.Text = "print 5+100100";
            this.answer1Radio.UseVisualStyleBackColor = true;
            // 
            // answer2Radio
            // 
            this.answer2Radio.AutoSize = true;
            this.answer2Radio.Location = new System.Drawing.Point(137, 143);
            this.answer2Radio.MaximumSize = new System.Drawing.Size(500, 0);
            this.answer2Radio.Name = "answer2Radio";
            this.answer2Radio.Size = new System.Drawing.Size(106, 17);
            this.answer2Radio.TabIndex = 3;
            this.answer2Radio.TabStop = true;
            this.answer2Radio.Text = "print \"5+100100\"";
            this.answer2Radio.UseVisualStyleBackColor = true;
            // 
            // answer3Radio
            // 
            this.answer3Radio.AutoSize = true;
            this.answer3Radio.Location = new System.Drawing.Point(137, 177);
            this.answer3Radio.MaximumSize = new System.Drawing.Size(500, 0);
            this.answer3Radio.Name = "answer3Radio";
            this.answer3Radio.Size = new System.Drawing.Size(116, 17);
            this.answer3Radio.TabIndex = 4;
            this.answer3Radio.TabStop = true;
            this.answer3Radio.Text = "print \"5\"+\"100100\"";
            this.answer3Radio.UseVisualStyleBackColor = true;
            // 
            // checkButton
            // 
            this.checkButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkButton.BackColor = System.Drawing.Color.PowderBlue;
            this.checkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkButton.FlatAppearance.BorderSize = 0;
            this.checkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.checkButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkButton.Location = new System.Drawing.Point(142, 321);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(196, 43);
            this.checkButton.TabIndex = 17;
            this.checkButton.Text = "Έλεγχος";
            this.checkButton.UseVisualStyleBackColor = false;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // answer4Radio
            // 
            this.answer4Radio.AutoSize = true;
            this.answer4Radio.Location = new System.Drawing.Point(137, 210);
            this.answer4Radio.MaximumSize = new System.Drawing.Size(500, 0);
            this.answer4Radio.Name = "answer4Radio";
            this.answer4Radio.Size = new System.Drawing.Size(242, 17);
            this.answer4Radio.TabIndex = 19;
            this.answer4Radio.TabStop = true;
            this.answer4Radio.Text = "όλα επιστρέφουν διαφορετικό αποτέλεσμα";
            this.answer4Radio.UseVisualStyleBackColor = true;
            // 
            // countTxt
            // 
            this.countTxt.AutoSize = true;
            this.countTxt.Location = new System.Drawing.Point(21, 29);
            this.countTxt.Name = "countTxt";
            this.countTxt.Size = new System.Drawing.Size(24, 13);
            this.countTxt.TabIndex = 20;
            this.countTxt.Text = "1/5";
            // 
            // wrongTxt
            // 
            this.wrongTxt.AutoSize = true;
            this.wrongTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.wrongTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.wrongTxt.Location = new System.Drawing.Point(139, 288);
            this.wrongTxt.Name = "wrongTxt";
            this.wrongTxt.Size = new System.Drawing.Size(54, 17);
            this.wrongTxt.TabIndex = 21;
            this.wrongTxt.Text = "Λάθος";
            // 
            // correctTxt
            // 
            this.correctTxt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.correctTxt.AutoSize = true;
            this.correctTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.correctTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.correctTxt.Location = new System.Drawing.Point(142, 288);
            this.correctTxt.Name = "correctTxt";
            this.correctTxt.Size = new System.Drawing.Size(54, 17);
            this.correctTxt.TabIndex = 22;
            this.correctTxt.Text = "Σωστό";
            // 
            // nextButton
            // 
            this.nextButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nextButton.BackColor = System.Drawing.Color.Maroon;
            this.nextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextButton.Enabled = false;
            this.nextButton.FlatAppearance.BorderSize = 0;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nextButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nextButton.Location = new System.Drawing.Point(344, 321);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(196, 43);
            this.nextButton.TabIndex = 23;
            this.nextButton.Text = "Επόμενο";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // scoreTxt
            // 
            this.scoreTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreTxt.AutoSize = true;
            this.scoreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.scoreTxt.Location = new System.Drawing.Point(600, 347);
            this.scoreTxt.Name = "scoreTxt";
            this.scoreTxt.Size = new System.Drawing.Size(110, 17);
            this.scoreTxt.TabIndex = 24;
            this.scoreTxt.Text = "Βαθμολογία: 0/5";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 376);
            this.Controls.Add(this.scoreTxt);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.correctTxt);
            this.Controls.Add(this.wrongTxt);
            this.Controls.Add(this.countTxt);
            this.Controls.Add(this.answer4Radio);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.answer3Radio);
            this.Controls.Add(this.answer2Radio);
            this.Controls.Add(this.answer1Radio);
            this.Controls.Add(this.questionContentTxt);
            this.Controls.Add(this.questionTxt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Test";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Label questionTxt;
        private System.Windows.Forms.Label questionContentTxt;
        private System.Windows.Forms.RadioButton answer1Radio;
        private System.Windows.Forms.RadioButton answer2Radio;
        private System.Windows.Forms.RadioButton answer3Radio;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.RadioButton answer4Radio;
        private System.Windows.Forms.Label countTxt;
        private System.Windows.Forms.Label wrongTxt;
        private System.Windows.Forms.Label correctTxt;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label scoreTxt;
    }
}