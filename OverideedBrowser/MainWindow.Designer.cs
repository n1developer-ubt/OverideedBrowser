namespace OverriddenBrowser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLink1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLink2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bcAnimation = new Bunifu.Framework.UI.BunifuColorTransition(this.components);
            this.bwAnimation = new System.ComponentModel.BackgroundWorker();
            this.pnlBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.Controls.Add(this.label1);
            this.pnlBackground.Controls.Add(this.btnLink1);
            this.pnlBackground.Controls.Add(this.btnLink2);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(783, 451);
            this.pnlBackground.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 73);
            this.label1.TabIndex = 2;
            this.label1.Text = "Free Version";
            // 
            // btnLink1
            // 
            this.btnLink1.Active = false;
            this.btnLink1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLink1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLink1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLink1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLink1.BorderRadius = 0;
            this.btnLink1.ButtonText = "EcoPayz.com";
            this.btnLink1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLink1.DisabledColor = System.Drawing.Color.Gray;
            this.btnLink1.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLink1.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLink1.Iconimage")));
            this.btnLink1.Iconimage_right = null;
            this.btnLink1.Iconimage_right_Selected = null;
            this.btnLink1.Iconimage_Selected = null;
            this.btnLink1.IconMarginLeft = 0;
            this.btnLink1.IconMarginRight = 0;
            this.btnLink1.IconRightVisible = false;
            this.btnLink1.IconRightZoom = 0D;
            this.btnLink1.IconVisible = false;
            this.btnLink1.IconZoom = 90D;
            this.btnLink1.IsTab = false;
            this.btnLink1.Location = new System.Drawing.Point(395, 155);
            this.btnLink1.Name = "btnLink1";
            this.btnLink1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLink1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnLink1.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLink1.selected = false;
            this.btnLink1.Size = new System.Drawing.Size(240, 140);
            this.btnLink1.TabIndex = 1;
            this.btnLink1.Text = "EcoPayz.com";
            this.btnLink1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLink1.Textcolor = System.Drawing.Color.White;
            this.btnLink1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLink1.Click += new System.EventHandler(this.btnLink2_Click);
            // 
            // btnLink2
            // 
            this.btnLink2.Active = false;
            this.btnLink2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLink2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLink2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLink2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLink2.BorderRadius = 0;
            this.btnLink2.ButtonText = "Champs77.com";
            this.btnLink2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLink2.DisabledColor = System.Drawing.Color.Gray;
            this.btnLink2.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLink2.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLink2.Iconimage")));
            this.btnLink2.Iconimage_right = null;
            this.btnLink2.Iconimage_right_Selected = null;
            this.btnLink2.Iconimage_Selected = null;
            this.btnLink2.IconMarginLeft = 0;
            this.btnLink2.IconMarginRight = 0;
            this.btnLink2.IconRightVisible = false;
            this.btnLink2.IconRightZoom = 0D;
            this.btnLink2.IconVisible = false;
            this.btnLink2.IconZoom = 90D;
            this.btnLink2.IsTab = false;
            this.btnLink2.Location = new System.Drawing.Point(148, 155);
            this.btnLink2.Name = "btnLink2";
            this.btnLink2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLink2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnLink2.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLink2.selected = false;
            this.btnLink2.Size = new System.Drawing.Size(240, 140);
            this.btnLink2.TabIndex = 1;
            this.btnLink2.Text = "Champs77.com";
            this.btnLink2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLink2.Textcolor = System.Drawing.Color.White;
            this.btnLink2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLink2.Click += new System.EventHandler(this.btnLink2_Click);
            // 
            // bcAnimation
            // 
            this.bcAnimation.Color1 = System.Drawing.Color.Red;
            this.bcAnimation.Color2 = System.Drawing.Color.Orange;
            this.bcAnimation.ProgessValue = 0;
            this.bcAnimation.OnValueChange += new System.EventHandler(this.bcAnimation_OnValueChange);
            // 
            // bwAnimation
            // 
            this.bwAnimation.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwAnimation_DoWork);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 451);
            this.Controls.Add(this.pnlBackground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "OverriddenBrowser";
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBackground;
        private Bunifu.Framework.UI.BunifuColorTransition bcAnimation;
        private System.ComponentModel.BackgroundWorker bwAnimation;
        private Bunifu.Framework.UI.BunifuFlatButton btnLink2;
        private Bunifu.Framework.UI.BunifuFlatButton btnLink1;
        private System.Windows.Forms.Label label1;
    }
}

