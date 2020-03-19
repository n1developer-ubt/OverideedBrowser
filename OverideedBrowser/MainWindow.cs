using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using OverideedBrowser;

namespace OverriddenBrowser
{
    public partial class MainWindow : Form
    {
        private static readonly Random Rand = new Random();
        public MainWindow()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            bwAnimation.RunWorkerAsync();
        }

        private Color GetRandomColor()
        {
            return Color.FromArgb(Rand.Next(255), Rand.Next(255), Rand.Next(255));
        }

        private void bwChangeGradient_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void bcAnimation_OnValueChange(object sender, EventArgs e)
        {
            pnlBackground.BackColor = bcAnimation.Value;
            SetButtonColor(bcAnimation.Value);
        }

        private void SetButtonColor(Color pc)
        {
            double h;
            double s;
            double v;

            ColorToHSV(pc,out h, out s, out v);

            v = (v + 0.5f) % 1.0f;
            //v = v < 0.5 ? 0.7f : 0.3f;
            //s = s * 0.2f;
            h = (h+ 0.5f) % 1.0f;

            Color newColor = ColorFromHSV(h, s, v);
            foreach (Control control in pnlBackground.Controls)
            {
                if (control is BunifuFlatButton b)
                {
                    b.Normalcolor = newColor;
                    b.OnHovercolor= newColor;
                    b.Activecolor= newColor;
                    b.BackColor = newColor;
                    b.ForeColor = pc;
                }
            }

        }

        private void bwAnimation_DoWork(object sender, DoWorkEventArgs e)
        {
            int i = 0;
            while (true)
            {
                if (i == 101)
                {
                    bcAnimation.Color1 = bcAnimation.Color2;
                    bcAnimation.Color2 = GetRandomColor();
                    i = 0;
                }
                bcAnimation.ProgessValue = i++;
                Thread.Sleep(200);
            }
        }

        public void ColorToHSV(Color color, out double hue, out double saturation, out double value)
        {
            int max = Math.Max(color.R, Math.Max(color.G, color.B));
            int min = Math.Min(color.R, Math.Min(color.G, color.B));

            hue = color.GetHue();
            saturation = (max == 0) ? 0 : 1d - (1d * min / max);
            value = max / 255d;
        }

        public Color ColorFromHSV(double hue, double saturation, double value)
        {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            if (hi == 0)
                return Color.FromArgb(255, v, t, p);
            else if (hi == 1)
                return Color.FromArgb(255, q, v, p);
            else if (hi == 2)
                return Color.FromArgb(255, p, v, t);
            else if (hi == 3)
                return Color.FromArgb(255, p, q, v);
            else if (hi == 4)
                return Color.FromArgb(255, t, p, v);
            else
                return Color.FromArgb(255, v, p, q);
        }

        private void btnLink2_Click(object sender, EventArgs e)
        {
            if (sender is BunifuFlatButton b)
            {
                Browser br = new Browser(b.Text);
                br.Dock = DockStyle.Fill;
                this.Controls.Add(br);
                br.BringToFront();
                br.Exit += BrOnExit;
            }
        }

        private void BrOnExit(Browser sender)
        {
            sender.Exit -= BrOnExit;
            this.Controls.Remove(sender);
        }
    }

}
