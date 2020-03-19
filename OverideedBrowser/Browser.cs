using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.WinForms;

namespace OverideedBrowser
{
    public partial class Browser : UserControl
    {
        public delegate void DoIt(Browser sender);

        public event DoIt Exit;
        private ChromiumWebBrowser _browser;
        public Browser()
        {
            InitializeComponent();
        }

        public Browser(string add):this()
        {
            _browser = new ChromiumWebBrowser(add);
            _browser.Dock = DockStyle.Fill;
            pnlBrowser.Controls.Add(_browser);
            lblCurrentWebsite.Text = add;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Exit?.Invoke(this);
        }
    }
}
