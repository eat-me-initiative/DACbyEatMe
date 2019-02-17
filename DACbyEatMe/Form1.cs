using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Net;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.CSharp.RuntimeBinder;









namespace DACbyEatMe
{
    public partial class Form1 : Form
    {  //place holder
       //public string[] proxies = new WebClient().DownloadString("https://proxyscrape.com/api?request=getproxies&proxytype=http&timeout=10000&country=all&ssl=all&anonymity=all").Split('\n');
        public string fileName = string.Format("tokens/{0:yyyy-MM-dd_HH-mm-ss}.txt", (object)DateTime.Now);
        private IContainer components = (IContainer)null;
        private Button start;
        private Button getProxies;
        private TextBox username;
        private TextBox inviteBox;
        private TextBox textBox3;
        private CheckBox randomChecked;
        private CheckBox checkBox2;
        


       
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        //  be careful about adding any objects above here
        //
        //  be aware of the hierarchy of private classes so the
        //  program runs smooth and efficient
        //
        //
        //the initial load up of the form
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
