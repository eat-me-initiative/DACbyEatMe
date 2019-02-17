using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void closeWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void refreshBrows_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        
        }

        private void goBackBrows_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void goForwardBrows_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }
    }
}
