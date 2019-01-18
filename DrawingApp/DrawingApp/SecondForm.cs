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
    public partial class SecondForm : Form
    {
        public float SelectedFontSize { get; private set; }
        public SecondForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cbxFontSize_SelectedValueChanged(object sender, EventArgs e)
        {
            SelectedFontSize = float.Parse(cbxFontSize.Text);
        }
    }
}
