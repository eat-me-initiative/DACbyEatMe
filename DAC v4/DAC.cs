// Decompiled with JetBrains decompiler
// Type: DAC_v4.DAC
// Assembly: DAC v4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: ADCD26C7-7115-49CB-A171-B101A2567B86
// Assembly location: C:\Users\Yssentrick\Desktop\DAC v4\DAC v4.exe

using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace DAC_v4
{
  public class DAC : MetroForm
  {
    public string[] proxies = new WebClient().DownloadString("https://proxyscrape.com/api?request=getproxies&proxytype=http&timeout=10000&country=all&ssl=all&anonymity=all").Split('\n');
    public string fileName = string.Format("tokens/{0:yyyy-MM-dd_HH-mm-ss}.txt", (object) DateTime.Now);
    private IContainer components = (IContainer) null;
    private MetroButton start;
    private MetroLabel label;
    private MetroTextBox username;
    private MetroCheckBox random;
    private MetroTextBox metroTextBox1;
    private MetroTextBox invite;
    private MetroLabel metroLabel1;
    private MetroCheckBox metroCheckBox2;
    private MetroButton getProxies;

    public DAC()
    {
      this.InitializeComponent();
      Control.CheckForIllegalCrossThreadCalls = false;
      Process.Start("https://twitter.com/eletrulian");
    }

    private void metroLabel1_Click(object sender, EventArgs e)
    {
    }

    private void metroTextBox1_Click(object sender, EventArgs e)
    {
    }

    private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
    {
      switch (this.random.CheckState)
      {
        case CheckState.Unchecked:
        case CheckState.Indeterminate:
          this.username.Enabled = true;
          break;
        case CheckState.Checked:
          this.username.Enabled = false;
          break;
      }
    }

    private void metroTextBox1_Click_1(object sender, EventArgs e)
    {
    }

    private void start_Click(object sender, EventArgs e)
    {
      string upper = this.start.Text.ToUpper();
      if (!(upper == "START"))
      {
        if (!(upper == "STOP"))
          return;
        this.start.Text = "Start";
      }
      else
      {
        this.start.Text = "Stop";
        new Thread((ThreadStart) (() => this.startThreads()))
        {
          IsBackground = true
        }.Start();
      }
    }

    public string createAccount(string username, string invite, string host, int port)
    {
      if (this.start.Text.ToUpper() == "START")
        return (string) null;
      string address = "https://discordapp.com/api/auth/register";
      WebClient webClient = new WebClient();
      webClient.Proxy = (IWebProxy) new WebProxy(host, port);
      string data = "{\"username\":\"" + username + "\",\"invite\":" + invite + ",\"consent\":true,\"captcha_key\":null}";
      webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
      try
      {
        object obj1 = (object) JObject.Parse(webClient.UploadString(address, data));
        // ISSUE: reference to a compiler-generated field
        if (DAC.\u003C\u003Eo__6.\u003C\u003Ep__2 == null)
        {
          // ISSUE: reference to a compiler-generated field
          DAC.\u003C\u003Eo__6.\u003C\u003Ep__2 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof (string), typeof (DAC)));
        }
        // ISSUE: reference to a compiler-generated field
        Func<CallSite, object, string> target1 = DAC.\u003C\u003Eo__6.\u003C\u003Ep__2.Target;
        // ISSUE: reference to a compiler-generated field
        CallSite<Func<CallSite, object, string>> p2 = DAC.\u003C\u003Eo__6.\u003C\u003Ep__2;
        // ISSUE: reference to a compiler-generated field
        if (DAC.\u003C\u003Eo__6.\u003C\u003Ep__1 == null)
        {
          // ISSUE: reference to a compiler-generated field
          DAC.\u003C\u003Eo__6.\u003C\u003Ep__1 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", (IEnumerable<System.Type>) null, typeof (DAC), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
          }));
        }
        // ISSUE: reference to a compiler-generated field
        Func<CallSite, object, object> target2 = DAC.\u003C\u003Eo__6.\u003C\u003Ep__1.Target;
        // ISSUE: reference to a compiler-generated field
        CallSite<Func<CallSite, object, object>> p1 = DAC.\u003C\u003Eo__6.\u003C\u003Ep__1;
        // ISSUE: reference to a compiler-generated field
        if (DAC.\u003C\u003Eo__6.\u003C\u003Ep__0 == null)
        {
          // ISSUE: reference to a compiler-generated field
          DAC.\u003C\u003Eo__6.\u003C\u003Ep__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "token", typeof (DAC), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
          }));
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        object obj2 = DAC.\u003C\u003Eo__6.\u003C\u003Ep__0.Target((CallSite) DAC.\u003C\u003Eo__6.\u003C\u003Ep__0, obj1);
        object obj3 = target2((CallSite) p1, obj2);
        string str = target1((CallSite) p2, obj3);
        this.metroTextBox1.AppendText(str + "\r\n");
        System.IO.File.AppendAllText(this.fileName, str + "\r\n");
      }
      catch (Exception ex)
      {
      }
      new Thread((ThreadStart) (() => this.sendAnother()))
      {
        IsBackground = true
      }.Start();
      return (string) null;
    }

    public string getName()
    {
      return Regex.Replace(Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Substring(0, 12), "[^0-9A-Za-z]+", "");
    }

    private void metroTextBox2_Click(object sender, EventArgs e)
    {
    }

    public string sendAnother()
    {
      try
      {
        string u = this.random.Checked ? this.getName() : this.username.Text;
        string i = this.metroCheckBox2.Checked ? "\"" + this.invite.Text + "\"" : "null";
        string str = this.proxies[new Random().Next(this.proxies.Length)].ToString();
        string h = str.Split(':')[0];
        int p2 = int.Parse(str.Split(':')[1]);
        new Thread((ThreadStart) (() => this.createAccount(u, i, h, p2)))
        {
          IsBackground = true
        }.Start();
      }
      catch (Exception ex)
      {
      }
      return (string) null;
    }

    private void metroCheckBox1_CheckedChanged_1(object sender, EventArgs e)
    {
      switch (this.metroCheckBox2.CheckState)
      {
        case CheckState.Unchecked:
        case CheckState.Indeterminate:
          this.invite.Enabled = false;
          break;
        case CheckState.Checked:
          this.invite.Enabled = true;
          break;
      }
    }

    public string startThreads()
    {
      int num = (int) MessageBox.Show("Started Account Creator");
      string u = this.random.Checked ? this.getName() : this.username.Text;
      string i = this.metroCheckBox2.Checked ? "\"" + this.invite.Text + "\"" : "null";
      for (int index = 0; index < 500; ++index)
      {
        try
        {
          string str = this.proxies[new Random().Next(this.proxies.Length)].ToString();
          string h = str.Split(':')[0];
          int p2 = int.Parse(str.Split(':')[1]);
          new Thread((ThreadStart) (() => this.createAccount(u, i, h, p2)))
          {
            IsBackground = true
          }.Start();
        }
        catch (Exception ex)
        {
        }
      }
      return (string) null;
    }

    private void DAC_Load(object sender, EventArgs e)
    {
    }

    private void getProxies_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "Text Files (*.txt)|*.txt";
      openFileDialog.Title = "Select your proxy list";
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      this.proxies = System.IO.File.ReadAllText(openFileDialog.FileName.ToString()).Split('\n');
      int num = (int) MessageBox.Show("Proxy file selected!");
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (DAC));
      this.start = new MetroButton();
      this.label = new MetroLabel();
      this.username = new MetroTextBox();
      this.random = new MetroCheckBox();
      this.metroTextBox1 = new MetroTextBox();
      this.invite = new MetroTextBox();
      this.metroLabel1 = new MetroLabel();
      this.metroCheckBox2 = new MetroCheckBox();
      this.getProxies = new MetroButton();
      this.SuspendLayout();
      this.start.Highlight = true;
      this.start.Location = new Point(48, 345);
      this.start.Name = "start";
      this.start.Size = new Size(315, 60);
      this.start.TabIndex = 0;
      this.start.Text = "Start";
      this.start.Theme = MetroThemeStyle.Dark;
      this.start.Click += new EventHandler(this.start_Click);
      this.label.AutoSize = true;
      this.label.BackColor = Color.White;
      this.label.ForeColor = SystemColors.ControlText;
      this.label.Location = new Point(48, 296);
      this.label.Name = "label";
      this.label.Size = new Size(75, 19);
      this.label.Style = MetroColorStyle.Teal;
      this.label.TabIndex = 1;
      this.label.Text = "Username: ";
      this.label.Theme = MetroThemeStyle.Dark;
      this.label.Click += new EventHandler(this.metroLabel1_Click);
      this.username.Location = new Point(129, 296);
      this.username.MaxLength = 30;
      this.username.Name = "username";
      this.username.Size = new Size(234, 23);
      this.username.TabIndex = 2;
      this.username.Text = "allthefoxes";
      this.username.Theme = MetroThemeStyle.Dark;
      this.username.Click += new EventHandler(this.metroTextBox1_Click);
      this.random.AutoSize = true;
      this.random.Location = new Point(48, 213);
      this.random.Name = "random";
      this.random.Size = new Size(129, 15);
      this.random.TabIndex = 3;
      this.random.Text = "Random Usernames";
      this.random.Theme = MetroThemeStyle.Dark;
      this.random.UseVisualStyleBackColor = true;
      this.random.CheckedChanged += new EventHandler(this.metroCheckBox1_CheckedChanged);
      this.metroTextBox1.Location = new Point(416, 38);
      this.metroTextBox1.Multiline = true;
      this.metroTextBox1.Name = "metroTextBox1";
      this.metroTextBox1.ScrollBars = ScrollBars.Vertical;
      this.metroTextBox1.Size = new Size(495, 486);
      this.metroTextBox1.TabIndex = 4;
      this.metroTextBox1.Theme = MetroThemeStyle.Dark;
      this.invite.Location = new Point(96, 250);
      this.invite.MaxLength = 20;
      this.invite.Name = "invite";
      this.invite.Size = new Size(267, 23);
      this.invite.TabIndex = 6;
      this.invite.Text = "qJq5C";
      this.invite.Theme = MetroThemeStyle.Dark;
      this.invite.Click += new EventHandler(this.metroTextBox2_Click);
      this.metroLabel1.AutoSize = true;
      this.metroLabel1.Location = new Point(48, 254);
      this.metroLabel1.Name = "metroLabel1";
      this.metroLabel1.Size = new Size(42, 19);
      this.metroLabel1.TabIndex = 7;
      this.metroLabel1.Text = "Invite:";
      this.metroLabel1.Theme = MetroThemeStyle.Dark;
      this.metroCheckBox2.AutoSize = true;
      this.metroCheckBox2.Checked = true;
      this.metroCheckBox2.CheckState = CheckState.Checked;
      this.metroCheckBox2.Location = new Point(48, 180);
      this.metroCheckBox2.Name = "metroCheckBox2";
      this.metroCheckBox2.Size = new Size(97, 15);
      this.metroCheckBox2.TabIndex = 5;
      this.metroCheckBox2.Text = "Custom Invite";
      this.metroCheckBox2.Theme = MetroThemeStyle.Dark;
      this.metroCheckBox2.UseVisualStyleBackColor = true;
      this.metroCheckBox2.CheckedChanged += new EventHandler(this.metroCheckBox1_CheckedChanged_1);
      this.getProxies.Highlight = true;
      this.getProxies.Location = new Point(209, 180);
      this.getProxies.Name = "getProxies";
      this.getProxies.Size = new Size(154, 48);
      this.getProxies.TabIndex = 10;
      this.getProxies.Text = "Select Proxies (optional)";
      this.getProxies.Theme = MetroThemeStyle.Dark;
      this.getProxies.Click += new EventHandler(this.getProxies_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(934, 547);
      this.Controls.Add((Control) this.getProxies);
      this.Controls.Add((Control) this.metroLabel1);
      this.Controls.Add((Control) this.invite);
      this.Controls.Add((Control) this.metroCheckBox2);
      this.Controls.Add((Control) this.metroTextBox1);
      this.Controls.Add((Control) this.random);
      this.Controls.Add((Control) this.username);
      this.Controls.Add((Control) this.label);
      this.Controls.Add((Control) this.start);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (DAC);
      this.Text = "Discord Account Creator";
      this.Theme = MetroThemeStyle.Dark;
      this.Load += new EventHandler(this.DAC_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
