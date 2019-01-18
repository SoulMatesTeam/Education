namespace DrawingApp
{
    partial class MainForm
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
            this.btnOk = new System.Windows.Forms.Button();
            this.tbText = new System.Windows.Forms.TextBox();
            this.rbtRed = new System.Windows.Forms.RadioButton();
            this.rbtGreen = new System.Windows.Forms.RadioButton();
            this.cbxFontSize = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxColor = new System.Windows.Forms.GroupBox();
            this.rbtBlue = new System.Windows.Forms.RadioButton();
            this.rbtYellow = new System.Windows.Forms.RadioButton();
            this.lblText = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShowSecondForm = new System.Windows.Forms.Button();
            this.gbxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.Control;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOk.Location = new System.Drawing.Point(292, 24);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 27);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Apply";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(27, 29);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(246, 22);
            this.tbText.TabIndex = 1;
            // 
            // rbtRed
            // 
            this.rbtRed.AutoSize = true;
            this.rbtRed.Location = new System.Drawing.Point(6, 21);
            this.rbtRed.Name = "rbtRed";
            this.rbtRed.Size = new System.Drawing.Size(55, 21);
            this.rbtRed.TabIndex = 2;
            this.rbtRed.TabStop = true;
            this.rbtRed.Text = "Red";
            this.rbtRed.UseVisualStyleBackColor = true;
            this.rbtRed.CheckedChanged += new System.EventHandler(this.rbtRed_CheckedChanged);
            // 
            // rbtGreen
            // 
            this.rbtGreen.AutoSize = true;
            this.rbtGreen.Location = new System.Drawing.Point(6, 48);
            this.rbtGreen.Name = "rbtGreen";
            this.rbtGreen.Size = new System.Drawing.Size(69, 21);
            this.rbtGreen.TabIndex = 3;
            this.rbtGreen.TabStop = true;
            this.rbtGreen.Text = "Green";
            this.rbtGreen.UseVisualStyleBackColor = true;
            this.rbtGreen.CheckedChanged += new System.EventHandler(this.rbtGreen_CheckedChanged);
            // 
            // cbxFontSize
            // 
            this.cbxFontSize.FormattingEnabled = true;
            this.cbxFontSize.Items.AddRange(new object[] {
            "14",
            "18",
            "24",
            "48"});
            this.cbxFontSize.Location = new System.Drawing.Point(185, 78);
            this.cbxFontSize.Name = "cbxFontSize";
            this.cbxFontSize.Size = new System.Drawing.Size(88, 24);
            this.cbxFontSize.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Font size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter text:";
            // 
            // gbxColor
            // 
            this.gbxColor.Controls.Add(this.rbtRed);
            this.gbxColor.Controls.Add(this.rbtBlue);
            this.gbxColor.Controls.Add(this.rbtYellow);
            this.gbxColor.Controls.Add(this.rbtGreen);
            this.gbxColor.Location = new System.Drawing.Point(27, 57);
            this.gbxColor.Name = "gbxColor";
            this.gbxColor.Size = new System.Drawing.Size(133, 133);
            this.gbxColor.TabIndex = 6;
            this.gbxColor.TabStop = false;
            this.gbxColor.Text = "Color";
            // 
            // rbtBlue
            // 
            this.rbtBlue.AutoSize = true;
            this.rbtBlue.Location = new System.Drawing.Point(7, 102);
            this.rbtBlue.Name = "rbtBlue";
            this.rbtBlue.Size = new System.Drawing.Size(57, 21);
            this.rbtBlue.TabIndex = 3;
            this.rbtBlue.TabStop = true;
            this.rbtBlue.Text = "Blue";
            this.rbtBlue.UseVisualStyleBackColor = true;
            this.rbtBlue.CheckedChanged += new System.EventHandler(this.rbtBlue_CheckedChanged);
            // 
            // rbtYellow
            // 
            this.rbtYellow.AutoSize = true;
            this.rbtYellow.Location = new System.Drawing.Point(7, 75);
            this.rbtYellow.Name = "rbtYellow";
            this.rbtYellow.Size = new System.Drawing.Size(69, 21);
            this.rbtYellow.TabIndex = 3;
            this.rbtYellow.TabStop = true;
            this.rbtYellow.Text = "Yellow";
            this.rbtYellow.UseVisualStyleBackColor = true;
            this.rbtYellow.CheckedChanged += new System.EventHandler(this.rbtYellow_CheckedChanged);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblText.Location = new System.Drawing.Point(182, 173);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(0, 17);
            this.lblText.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(27, 224);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 27);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShowSecondForm
            // 
            this.btnShowSecondForm.Location = new System.Drawing.Point(292, 57);
            this.btnShowSecondForm.Name = "btnShowSecondForm";
            this.btnShowSecondForm.Size = new System.Drawing.Size(68, 42);
            this.btnShowSecondForm.TabIndex = 8;
            this.btnShowSecondForm.Text = "SecondForm";
            this.btnShowSecondForm.UseVisualStyleBackColor = true;
            this.btnShowSecondForm.Click += new System.EventHandler(this.btnShowSecondForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 263);
            this.Controls.Add(this.btnShowSecondForm);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.gbxColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxFontSize);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOk);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.gbxColor.ResumeLayout(false);
            this.gbxColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.RadioButton rbtRed;
        private System.Windows.Forms.RadioButton rbtGreen;
        private System.Windows.Forms.ComboBox cbxFontSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxColor;
        private System.Windows.Forms.RadioButton rbtBlue;
        private System.Windows.Forms.RadioButton rbtYellow;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnShowSecondForm;
    }
}

