namespace DACbyEatMe
{
    partial class Form1
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
            this.getProxies = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.inviteBox = new System.Windows.Forms.TextBox();
            this.randomChecked = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // getProxies
            // 
            this.getProxies.Location = new System.Drawing.Point(268, 102);
            this.getProxies.Name = "getProxies";
            this.getProxies.Size = new System.Drawing.Size(75, 23);
            this.getProxies.TabIndex = 0;
            this.getProxies.Text = "get proxies";
            this.getProxies.UseVisualStyleBackColor = true;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(268, 29);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 1;
            this.Start.Text = "start";
            this.Start.UseVisualStyleBackColor = true;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(12, 12);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 20);
            this.username.TabIndex = 2;
            this.username.Text = "username";
            // 
            // inviteBox
            // 
            this.inviteBox.Location = new System.Drawing.Point(12, 66);
            this.inviteBox.Name = "inviteBox";
            this.inviteBox.Size = new System.Drawing.Size(100, 20);
            this.inviteBox.TabIndex = 3;
            this.inviteBox.Text = "invites";
            // 
            // randomChecked
            // 
            this.randomChecked.AutoSize = true;
            this.randomChecked.Location = new System.Drawing.Point(118, 12);
            this.randomChecked.Name = "randomChecked";
            this.randomChecked.Size = new System.Drawing.Size(61, 17);
            this.randomChecked.TabIndex = 4;
            this.randomChecked.Text = "random";
            this.randomChecked.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 126);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(118, 68);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 178);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.randomChecked);
            this.Controls.Add(this.inviteBox);
            this.Controls.Add(this.username);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.getProxies);
            this.Name = "Form1";
            this.Text = "DAC by Eat Me";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getProxies;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox inviteBox;
        private System.Windows.Forms.CheckBox randomChecked;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

