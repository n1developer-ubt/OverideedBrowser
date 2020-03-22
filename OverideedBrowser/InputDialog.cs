using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverideedBrowser
{
    public partial class InputDialog : Form
    {
        public delegate void DoIt(string value);

        public event DoIt Done;
        public InputDialog()
        {
            InitializeComponent();
            txtDone.Focus();
        }

        private void txtDone_Click(object sender, EventArgs e)
        {
            Done?.Invoke(txtInput.Text);
            this.Hide();
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDone_Click(null,null);
            }
        }
    }
}
