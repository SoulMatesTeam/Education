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
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbTools = new System.Windows.Forms.GroupBox();
            this.btErase = new System.Windows.Forms.Button();
            this.btDrawByDots = new System.Windows.Forms.Button();
            this.btPen = new System.Windows.Forms.Button();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.tbPenSize = new System.Windows.Forms.TrackBar();
            this.lbPenSize = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.cbBgColor = new System.Windows.Forms.ComboBox();
            this.lblBgColor = new System.Windows.Forms.Label();
            this.gbTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPenSize)).BeginInit();
            this.SuspendLayout();
            // 
            // cbColor
            // 
            this.cbColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "Black",
            "Green",
            "Blue",
            "Pink",
            "Yellow",
            "Red"});
            this.cbColor.Location = new System.Drawing.Point(691, 74);
            this.cbColor.Margin = new System.Windows.Forms.Padding(2);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(158, 21);
            this.cbColor.TabIndex = 1;
            this.cbColor.SelectedIndexChanged += new System.EventHandler(this.cbColor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(652, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Color:";
            // 
            // gbTools
            // 
            this.gbTools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTools.Controls.Add(this.btErase);
            this.gbTools.Controls.Add(this.btDrawByDots);
            this.gbTools.Controls.Add(this.btPen);
            this.gbTools.Location = new System.Drawing.Point(647, 3);
            this.gbTools.Margin = new System.Windows.Forms.Padding(2);
            this.gbTools.Name = "gbTools";
            this.gbTools.Padding = new System.Windows.Forms.Padding(2);
            this.gbTools.Size = new System.Drawing.Size(200, 66);
            this.gbTools.TabIndex = 3;
            this.gbTools.TabStop = false;
            this.gbTools.Text = "Tools";
            // 
            // btErase
            // 
            this.btErase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btErase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btErase.Image = global::DrawingApp.Properties.Resources.eraser;
            this.btErase.Location = new System.Drawing.Point(88, 17);
            this.btErase.Margin = new System.Windows.Forms.Padding(2);
            this.btErase.Name = "btErase";
            this.btErase.Size = new System.Drawing.Size(38, 41);
            this.btErase.TabIndex = 1;
            this.btErase.UseVisualStyleBackColor = true;
            this.btErase.Click += new System.EventHandler(this.btErase_Click);
            // 
            // btDrawByDots
            // 
            this.btDrawByDots.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDrawByDots.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDrawByDots.Image = global::DrawingApp.Properties.Resources.triangle;
            this.btDrawByDots.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btDrawByDots.Location = new System.Drawing.Point(46, 17);
            this.btDrawByDots.Margin = new System.Windows.Forms.Padding(2);
            this.btDrawByDots.Name = "btDrawByDots";
            this.btDrawByDots.Size = new System.Drawing.Size(38, 41);
            this.btDrawByDots.TabIndex = 1;
            this.btDrawByDots.UseVisualStyleBackColor = true;
            this.btDrawByDots.Click += new System.EventHandler(this.btDrawByDots_Click);
            // 
            // btPen
            // 
            this.btPen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btPen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btPen.Image = global::DrawingApp.Properties.Resources.pen;
            this.btPen.Location = new System.Drawing.Point(4, 17);
            this.btPen.Margin = new System.Windows.Forms.Padding(2);
            this.btPen.Name = "btPen";
            this.btPen.Size = new System.Drawing.Size(38, 41);
            this.btPen.TabIndex = 0;
            this.btPen.UseVisualStyleBackColor = true;
            this.btPen.Click += new System.EventHandler(this.BtPen_Click);
            // 
            // pbCanvas
            // 
            this.pbCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCanvas.Location = new System.Drawing.Point(9, 6);
            this.pbCanvas.Margin = new System.Windows.Forms.Padding(2);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(634, 483);
            this.pbCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCanvas.TabIndex = 4;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbCanvas_MouseClick);
            this.pbCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlCanvas_MouseDown);
            this.pbCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlCanvas_MouseMove);
            this.pbCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlCanvas_MouseUp);
            // 
            // tbPenSize
            // 
            this.tbPenSize.LargeChange = 1;
            this.tbPenSize.Location = new System.Drawing.Point(655, 117);
            this.tbPenSize.Margin = new System.Windows.Forms.Padding(2);
            this.tbPenSize.Maximum = 15;
            this.tbPenSize.Minimum = 1;
            this.tbPenSize.Name = "tbPenSize";
            this.tbPenSize.Size = new System.Drawing.Size(193, 45);
            this.tbPenSize.TabIndex = 5;
            this.tbPenSize.Value = 1;
            this.tbPenSize.ValueChanged += new System.EventHandler(this.tbPenSize_ValueChanged);
            // 
            // lbPenSize
            // 
            this.lbPenSize.AutoSize = true;
            this.lbPenSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPenSize.Location = new System.Drawing.Point(741, 149);
            this.lbPenSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPenSize.Name = "lbPenSize";
            this.lbPenSize.Size = new System.Drawing.Size(15, 15);
            this.lbPenSize.TabIndex = 6;
            this.lbPenSize.Text = "1";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(655, 465);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(769, 465);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 8;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cbBgColor
            // 
            this.cbBgColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBgColor.FormattingEnabled = true;
            this.cbBgColor.Items.AddRange(new object[] {
            "white",
            "black",
            "blue",
            "red",
            "green",
            "yellow",
            "pink"});
            this.cbBgColor.Location = new System.Drawing.Point(705, 189);
            this.cbBgColor.Name = "cbBgColor";
            this.cbBgColor.Size = new System.Drawing.Size(138, 21);
            this.cbBgColor.TabIndex = 9;
            this.cbBgColor.SelectedIndexChanged += new System.EventHandler(this.cbBgColor_SelectedIndexChanged);
            // 
            // lblBgColor
            // 
            this.lblBgColor.AutoSize = true;
            this.lblBgColor.Location = new System.Drawing.Point(654, 192);
            this.lblBgColor.Name = "lblBgColor";
            this.lblBgColor.Size = new System.Drawing.Size(45, 13);
            this.lblBgColor.TabIndex = 10;
            this.lblBgColor.Text = "BGcolor";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 500);
            this.Controls.Add(this.lblBgColor);
            this.Controls.Add(this.cbBgColor);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbPenSize);
            this.Controls.Add(this.tbPenSize);
            this.Controls.Add(this.pbCanvas);
            this.Controls.Add(this.gbTools);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbColor);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.gbTools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPenSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbTools;
        private System.Windows.Forms.Button btPen;
        private System.Windows.Forms.Button btDrawByDots;
        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Button btErase;
        private System.Windows.Forms.TrackBar tbPenSize;
        private System.Windows.Forms.Label lbPenSize;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox cbBgColor;
        private System.Windows.Forms.Label lblBgColor;
    }
}