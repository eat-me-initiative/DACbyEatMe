namespace WindowsFormsApp2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fileToolStrip = new System.Windows.Forms.ToolStripDropDownButton();
            this.closeWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshBrows = new System.Windows.Forms.ToolStripLabel();
            this.goBackBrows = new System.Windows.Forms.ToolStripLabel();
            this.goForwardBrows = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(800, 450);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://allthefoxes.000webhostapp.com/", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStrip,
            this.refreshBrows,
            this.goBackBrows,
            this.goForwardBrows});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // fileToolStrip
            // 
            this.fileToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeWindowToolStripMenuItem});
            this.fileToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("fileToolStrip.Image")));
            this.fileToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileToolStrip.Name = "fileToolStrip";
            this.fileToolStrip.Size = new System.Drawing.Size(38, 22);
            this.fileToolStrip.Text = "File";
            // 
            // closeWindowToolStripMenuItem
            // 
            this.closeWindowToolStripMenuItem.Name = "closeWindowToolStripMenuItem";
            this.closeWindowToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeWindowToolStripMenuItem.Text = "Close Window";
            this.closeWindowToolStripMenuItem.Click += new System.EventHandler(this.closeWindowToolStripMenuItem_Click);
            // 
            // refreshBrows
            // 
            this.refreshBrows.Name = "refreshBrows";
            this.refreshBrows.Size = new System.Drawing.Size(46, 22);
            this.refreshBrows.Text = "Refresh";
            this.refreshBrows.Click += new System.EventHandler(this.refreshBrows_Click);
            // 
            // goBackBrows
            // 
            this.goBackBrows.Name = "goBackBrows";
            this.goBackBrows.Size = new System.Drawing.Size(50, 22);
            this.goBackBrows.Text = "<--Back";
            this.goBackBrows.Click += new System.EventHandler(this.goBackBrows_Click);
            // 
            // goForwardBrows
            // 
            this.goForwardBrows.Name = "goForwardBrows";
            this.goForwardBrows.Size = new System.Drawing.Size(68, 22);
            this.goForwardBrows.Text = "Forward-->";
            this.goForwardBrows.Click += new System.EventHandler(this.goForwardBrows_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton fileToolStrip;
        private System.Windows.Forms.ToolStripMenuItem closeWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel refreshBrows;
        private System.Windows.Forms.ToolStripLabel goBackBrows;
        private System.Windows.Forms.ToolStripLabel goForwardBrows;
    }
}