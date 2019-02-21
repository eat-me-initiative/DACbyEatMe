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
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getProxies
            // 
            this.getProxies.Location = new System.Drawing.Point(307, 114);
            this.getProxies.Name = "getProxies";
            this.getProxies.Size = new System.Drawing.Size(75, 23);
            this.getProxies.TabIndex = 0;
            this.getProxies.Text = "Get Proxies";
            this.getProxies.UseVisualStyleBackColor = true;
            this.getProxies.Click += new System.EventHandler(this.getProxies_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(307, 85);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(12, 12);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(129, 20);
            this.username.TabIndex = 2;
            this.username.Text = "Username";
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // inviteBox
            // 
            this.inviteBox.Location = new System.Drawing.Point(12, 66);
            this.inviteBox.Name = "inviteBox";
            this.inviteBox.Size = new System.Drawing.Size(129, 20);
            this.inviteBox.TabIndex = 3;
            this.inviteBox.Text = "Invite Links";
            this.inviteBox.TextChanged += new System.EventHandler(this.inviteBox_TextChanged);
            // 
            // randomChecked
            // 
            this.randomChecked.AutoSize = true;
            this.randomChecked.Location = new System.Drawing.Point(147, 14);
            this.randomChecked.Name = "randomChecked";
            this.randomChecked.Size = new System.Drawing.Size(117, 17);
            this.randomChecked.TabIndex = 4;
            this.randomChecked.Text = "Random Username";
            this.randomChecked.UseVisualStyleBackColor = true;
            this.randomChecked.CheckedChanged += new System.EventHandler(this.randomChecked_CheckedChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 126);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(129, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Another Stupid Textbox";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(147, 66);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(147, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Another Stupid Checkbox";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(307, 143);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 178);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.randomChecked);
            this.Controls.Add(this.inviteBox);
            this.Controls.Add(this.username);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.getProxies);
            this.Name = "Form1";
            this.ShowIcon = false;
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
        private System.Windows.Forms.Button closeButton;
    }
}

