using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrawingApp
{
    public partial class MainForm : Form
    {
        Color textColor;

        public MainForm()
        {
            InitializeComponent();
            textColor = Color.Black;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            lblText.Text = tbText.Text;
            lblText.ForeColor = textColor;
            var fontSize = float.Parse(cbxFontSize.Text);
            lblText.Font = new Font("Microsoft Sans Serif", fontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

        }

        private void rbtRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtRed.Checked)
                textColor = Color.Red;
        }

        private void rbtGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtGreen.Checked)
                textColor = Color.Green;
        }

        private void rbtYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtYellow.Checked)
                textColor = Color.Yellow;
        }

        private void rbtBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtBlue.Checked)
                textColor = Color.Blue;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShowSecondForm_Click(object sender, EventArgs e)
        {
            SecondForm secondForm = new SecondForm();
            var result = secondForm.ShowDialog();
            lblText.Font = new Font("Microsoft Sans Serif", secondForm.SelectedFontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

            if (result == DialogResult.OK)
                lblText.Text = "Dialog was OK!";
            else if (result == DialogResult.Cancel)
                lblText.Text = "Dialog was not so good!";
        }
    }
}
