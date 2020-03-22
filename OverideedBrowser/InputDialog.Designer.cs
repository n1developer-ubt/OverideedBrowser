namespace OverideedBrowser
{
    partial class InputDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputDialog));
            this.txtDone = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtInput = new UBTStandardLibrary.UBTTextBox();
            this.SuspendLayout();
            // 
            // txtDone
            // 
            this.txtDone.Active = false;
            this.txtDone.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.txtDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.txtDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtDone.BorderRadius = 0;
            this.txtDone.ButtonText = "Done";
            this.txtDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDone.DisabledColor = System.Drawing.Color.Gray;
            this.txtDone.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDone.Iconcolor = System.Drawing.Color.Transparent;
            this.txtDone.Iconimage = ((System.Drawing.Image)(resources.GetObject("txtDone.Iconimage")));
            this.txtDone.Iconimage_right = null;
            this.txtDone.Iconimage_right_Selected = null;
            this.txtDone.Iconimage_Selected = null;
            this.txtDone.IconMarginLeft = 0;
            this.txtDone.IconMarginRight = 0;
            this.txtDone.IconRightVisible = false;
            this.txtDone.IconRightZoom = 0D;
            this.txtDone.IconVisible = false;
            this.txtDone.IconZoom = 90D;
            this.txtDone.IsTab = false;
            this.txtDone.Location = new System.Drawing.Point(5, 113);
            this.txtDone.Name = "txtDone";
            this.txtDone.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.txtDone.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.txtDone.OnHoverTextColor = System.Drawing.Color.White;
            this.txtDone.selected = false;
            this.txtDone.Size = new System.Drawing.Size(350, 39);
            this.txtDone.TabIndex = 2;
            this.txtDone.Text = "Done";
            this.txtDone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtDone.Textcolor = System.Drawing.Color.White;
            this.txtDone.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDone.Click += new System.EventHandler(this.txtDone_Click);
            // 
            // txtInput
            // 
            this.txtInput.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txtInput.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.txtInput.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtInput.BorderThickness = 2;
            this.txtInput.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtInput.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtInput.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtInput.Hint = "ubtTextBox1";
            this.txtInput.isPassword = true;
            this.txtInput.Location = new System.Drawing.Point(5, 5);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4);
            this.txtInput.MaxLength = 32767;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(350, 40);
            this.txtInput.TabIndex = 3;
            this.txtInput.Text = "ubtTextBox1";
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
            // 
            // InputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 157);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtDone);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InputDialog";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Input Password";
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton txtDone;
        private UBTStandardLibrary.UBTTextBox txtInput;
    }
}