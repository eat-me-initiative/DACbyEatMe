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



        //user name text box
        private void username_TextChanged(object sender, EventArgs e)
        {

        }


        //invite text box
        private void inviteBox_TextChanged(object sender, EventArgs e)
        {

        }


        //text box 3
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        //check box for random user names
        private void randomChecked_CheckedChanged(object sender, EventArgs e)
        {

        }


        //check box 2
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }


        //start button
        private void Start_Click(object sender, EventArgs e)
        {

        }


        //get proxies button
        private void getProxies_Click(object sender, EventArgs e)
        {

        }

        //close button to close the program
        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
